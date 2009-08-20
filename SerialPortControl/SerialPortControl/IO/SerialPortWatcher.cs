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
        private SerialPort _serialPort;
        public event EventHandler<ReceivedDataEventArgs> ReceivedData;
        public event EventHandler Connected;
        public event EventHandler Disconnected;

        Thread _readingThread;

        public SerialPortWatcher(SerialPortSettings portOptions)
        {
            _readingThread = new Thread(ReadData);
            _readingThread.Name = "SerialData";

            _serialPort = new SerialPort();

            _serialPort.PortName = portOptions.PortName;
            _serialPort.BaudRate = (int)portOptions.BaudRate;
            _serialPort.Parity = portOptions.Parity;
            _serialPort.DataBits = portOptions.DataBits;
            _serialPort.StopBits = portOptions.StopBits;
            _serialPort.Handshake = portOptions.Handshake;

            _serialPort.Encoding = Encoding.ASCII;

            _serialPort.NewLine = "\r\n";


            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;

        }

        ~SerialPortWatcher()
        {
            Stop();
            _readingThread.Abort();
        }

        public SerialPortSettings PortOptions
        {
            set
            {
                Stop();

                _serialPort.PortName = value.PortName;
                _serialPort.BaudRate = (int)value.BaudRate;
                _serialPort.Parity = value.Parity;
                _serialPort.DataBits = value.DataBits;
                _serialPort.StopBits = value.StopBits;
                _serialPort.Handshake = value.Handshake;

                Start();
            }
        }

        public bool Enabled
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
            Disconnected(this, new EventArgs());
            _serialPort.Close();
            
        }
        public void Start()
        {
            _serialPort.Open();
            Connected(this, new EventArgs());

            if (!_readingThread.IsAlive)
            {
                _readingThread.Start();
            }
        }

        protected void ReadData()
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
    }
}
