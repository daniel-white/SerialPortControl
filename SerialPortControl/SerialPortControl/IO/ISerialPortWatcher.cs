using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SerialPortControl.Model;

namespace SerialPortControl.IO
{
    public interface ISerialPortWatcher
    {
        event EventHandler<ReceivedDataEventArgs> OnReceivedData;

        SerialPortSettings SerialPort { set; }
    }

    public class ReceivedDataEventArgs : EventArgs
    {
        public ReceivedDataEventArgs(string data)
        {
            Data = data;
        }
        public string Data { get; private set; }
    }
}
