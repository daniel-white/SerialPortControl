// a multi-threaded implementation for a serial port watcher
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
            // copy in the settings
            _serialPortSettings = portOptions;
            // setup blocking
            _stopThreadEvent = new ManualResetEvent(false);
            // setup the thread
            SetupThread();
        }

        ~SerialPortWatcher()
        {
            // clean up the thread
            Stop();
        }

        protected SerialPort SetupSerialPort(SerialPortSettings settings)
        {
            // Configure a standard serial port based on the options
            SerialPort serialPort = new SerialPort();

            serialPort.PortName = settings.PortName;
            serialPort.BaudRate = (int)settings.BaudRate;
            serialPort.Parity = settings.Parity;
            serialPort.DataBits = settings.DataBits;
            serialPort.StopBits = settings.StopBits;
            serialPort.Handshake = settings.Handshake;

            serialPort.Encoding = Encoding.ASCII;

            // ends a transmission
            serialPort.NewLine = "\r\n";

            serialPort.ReadTimeout = 500;
            serialPort.WriteTimeout = 500;

            return serialPort;
        }

        protected void SetupThread()
        {
            // start a new thread
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
            // block and notify
            _stopThreadEvent.Set();
            _readingThread.Abort();
            StoppedListening(this, new EventArgs());
        }
        public void Start()
        {
            // if active, ignore
            if (_readingThread.IsAlive)
                return;

            // set itup again
            SetupThread();
            _readingThread.Start();

            // notify
            StartedListening(this, new EventArgs());
        }

        protected void ReadData()
        {
            // the thread
            SerialPort serialPort = null;
            try
            {
                // try to load the serial port
                serialPort = SetupSerialPort(_serialPortSettings);
                serialPort.Open();

                string data;

                // loop to see if its open
                while (serialPort.IsOpen)
                {
                    try
                    {
                        // read data in from the serial port, if found, notify with event
                        data = serialPort.ReadLine();
                        if (data.Length > 0)
                            ReceivedData(serialPort, new ReceivedDataEventArgs(data));

                    }
                    catch (TimeoutException)
                    {
                        //  No action/ignore
                    }
                    if (_stopThreadEvent.WaitOne(0))
                    {
                        break;
                        // fall through the end of the thread
                    }
                }

            }
            catch (Exception)
            {
            }
            finally
            {
                // clean up on any exceptions
                if (serialPort != null)
                    serialPort.Close();
            }

        }
    }
}
