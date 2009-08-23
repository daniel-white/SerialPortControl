using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;

using System.IO.Ports;
using SerialPortControl.Model;

namespace SerialPortControl.IO
{
    public class SerialPortWatcher : ISerialPortWatcher
    {
        private SerialPortSettings _serialPortSettings;
        protected ManualResetEvent _stopThreadEvent;
        public event EventHandler<ReceivedDataEventArgs> ReceivedData;
        public event EventHandler StartedListening;
        public event EventHandler StoppedListening;


        Thread _readingThread;

        public SerialPortWatcher(SerialPortSettings portOptions)
        {
            _serialPortSettings = portOptions;
            _stopThreadEvent = new ManualResetEvent(false);
            SetupThread();
        }

        ~SerialPortWatcher()
        {
            Stop();
        }

        protected SerialPort SetupSerialPort(SerialPortSettings settings)
        {
            SerialPort serialPort = new SerialPort();

            serialPort.PortName = settings.PortName;
            serialPort.BaudRate = (int)settings.BaudRate;
            serialPort.Parity = settings.Parity;
            serialPort.DataBits = settings.DataBits;
            serialPort.StopBits = settings.StopBits;
            serialPort.Handshake = settings.Handshake;

            serialPort.Encoding = Encoding.ASCII;

            serialPort.NewLine = "\r\n";

            serialPort.ReadTimeout = 500;
            serialPort.WriteTimeout = 500;

            return serialPort;
        }

        protected void SetupThread()
        {
            _stopThreadEvent.Reset();
            _readingThread = new Thread(ReadData);
            _readingThread.Name = "SerialData";
        }

        public SerialPortSettings PortOptions
        {
            set
            {
                Stop();
                _serialPortSettings = value;
                Start();
            }
            get
            {
                return _serialPortSettings;
            }
        }

        public bool Listening
        {
            get { return _readingThread.IsAlive; }
            set
            {
                if (value)
                    Start();
                else
                    Stop();
            }
        }

        public void Stop()
        {
            _stopThreadEvent.Set();
            StoppedListening(this, new EventArgs());
        }
        public void Start()
        {
            if (_readingThread.IsAlive)
                return;


            SetupThread();
            _readingThread.Start();

            StartedListening(this, new EventArgs());
        }

        protected void ReadData()
        {
            SerialPort serialPort = null;
            try
            {
                serialPort = SetupSerialPort(_serialPortSettings);
                serialPort.Open();

                string data;
                while (serialPort.IsOpen)
                {
                    try
                    {

                        data = serialPort.ReadLine();
                        if (data.Length > 0)
                            ReceivedData(serialPort, new ReceivedDataEventArgs(data));

                    }
                    catch (TimeoutException)
                    {
                        //  No action
                    }
                    if (_stopThreadEvent.WaitOne(0))
                        break;
                }

            }
            catch (Exception)
            {
            }
            finally
            {
                if (serialPort != null)
                    serialPort.Close();
            }

        }
    }
}
