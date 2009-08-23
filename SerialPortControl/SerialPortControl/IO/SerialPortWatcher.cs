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
        private static SerialPort _serialPort;
        private SerialPortSettings _serialPortSettings;
        public event EventHandler<ReceivedDataEventArgs> ReceivedData;
        public event EventHandler StartedListening;
        public event EventHandler StoppedListening;

        
        Thread _readingThread;

        public SerialPortWatcher(SerialPortSettings portOptions)
        {
            SetupSerialPort(portOptions);
            SetupThread();
        }

        ~SerialPortWatcher()
        {
            Stop();
            _readingThread.Abort();
        }

        protected void SetupSerialPort(SerialPortSettings settings)
        {
            _serialPort = new SerialPort();

            _serialPort.PortName = settings.PortName;
            _serialPort.BaudRate = (int)settings.BaudRate;
            _serialPort.Parity = settings.Parity;
            _serialPort.DataBits = settings.DataBits;
            _serialPort.StopBits = settings.StopBits;
            _serialPort.Handshake = settings.Handshake;

            _serialPort.Encoding = Encoding.ASCII;

            _serialPort.NewLine = "\r\n";

            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
        }

        protected void SetupThread()
        {
            _readingThread = new Thread(ReadData);
            _readingThread.Name = "SerialData";
        }

        public SerialPortSettings PortOptions
        {
            set
            {
                Stop();

                SetupSerialPort(value);

                Start();
            }
        }

        public bool Listening
        {
            get { return _serialPort.IsOpen; }
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
            _readingThread.Abort();
            _serialPort.Close();
            StoppedListening(this, new EventArgs());
        }
        public void Start()
        {
            if (_readingThread.IsAlive || _serialPort.IsOpen)
                return;

            _serialPort.Open();

            SetupThread();
            _readingThread.Start();

            StartedListening(this, new EventArgs());
        }

        protected void ReadData()
        {
            try
            {
                string data;
                while (true)
                {
                    try
                    {
                        if (_serialPort.IsOpen)
                        {
                            data = _serialPort.ReadLine();
                            if (data.Length > 0)
                                ReceivedData(_serialPort, new ReceivedDataEventArgs(data));
                        }
                    }
                    catch (TimeoutException)
                    {
                        //  No action
                    }
                }
            }
            catch (ThreadAbortException)
            {
                // Fall through
            }
            
        }
    }
}
