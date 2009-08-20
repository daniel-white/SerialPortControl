using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO.Ports;

namespace SerialPortControl.IO
{
    public class SerialPortWatcher : ISerialPortWatcher
    {
        private SerialPort _serialPort;
        public event EventHandler<ReceivedDataEventArgs> ReceivedData;

        public SerialPortControl.Model.SerialPortSettings PortOptions
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

        public void Stop() { Enabled = false; }
        public void Start() { Enabled = true; }

    }
}
