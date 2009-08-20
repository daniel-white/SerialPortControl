using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace SerialPortControl.Model
{
    public class SerialPortSettings: ICloneable
    {
        public SerialPortSettings()
        {
            Configurations = new SerialPortConfigurations();
        }

        public string PortName { get; set; }
        public BaudRate BaudRate { get; set; }
        public Parity Parity { get; set; }
        public int DataBits { get; set; }
        public StopBits StopBits { get; set; }
        public Handshake Handshake { get; set; }


        public object Clone()
        {
            return new SerialPortSettings
            {
                PortName = this.PortName,
                BaudRate = this.BaudRate,
                Parity = this.Parity,
                DataBits = this.DataBits,
                StopBits = this.StopBits,
                Handshake = this.Handshake,
                Configurations = this.Configurations
            };
        }

        public SerialPortConfigurations Configurations { get; private set; }
        
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

    public class SerialPortConfigurations
    {
        public IEnumerable<string> PortNames { get { return SerialPort.GetPortNames(); } }
        public IEnumerable<int> BaudRates { get { return new List<int>((int[])Enum.GetValues(typeof(BaudRate))); } }
        public IEnumerable<string> Parities { get { return new List<string>((string[])Enum.GetNames(typeof(Parity))); } }
        public IEnumerable<string> StopBits { get { return new List<string>((string[])Enum.GetNames(typeof(StopBits))); } }
        public IEnumerable<string> Handshakes { get { return new List<string>((string[])Enum.GetNames(typeof(Handshake))); } }

    }
    
}
