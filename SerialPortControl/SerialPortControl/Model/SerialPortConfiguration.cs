using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace SerialPortControl.Model
{
    public class SerialPortConfiguration: ICloneable
    {
        public string PortName { get; set; }
        public BaudRate BaudRate { get; set; }
        public Parity Parity { get; set; }
        public int DataBits { get; set; }
        public StopBits StopBits { get; set; }
        public Handshake Handshake { get; set; }

        #region ICloneable Members

        public object Clone()
        {
            return new SerialPortConfiguration
            {
                PortName = this.PortName,
                BaudRate = this.BaudRate,
                Parity = this.Parity,
                DataBits = this.DataBits,
                StopBits = this.StopBits,
                Handshake = this.Handshake
            };
        }

        #endregion

        
    }


    public enum BaudRate
    {
        Rate2400 = 2400,
        Rate4800 = 4800,
        Rate9600 = 9600,
        Rate19200 = 19200,
        Rate38400 = 38400,
        Rate57600 = 57600,
        Rate115200 = 115200
    }

    public class AvailableSerialPortConfiguration
    {
        public IList<string> PortNames { get { return SerialPort.GetPortNames(); } }
        public IList<int> BaudRates { get { return new List<int>((int[]) Enum.GetValues(typeof(BaudRate))); } }
        public IList<string> Parities { get { return new List<string>((string[])Enum.GetNames(typeof(Parity))); } }
        public IList<string> StopBits { get { return new List<string>((string[])Enum.GetNames(typeof(StopBits))); } }
        public IList<string> Handshakes { get { return new List<string>((string[])Enum.GetNames(typeof(Handshake))); } }

    }
    
}
