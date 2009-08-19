using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace SerialPortControl.Model
{
    public class SerialPortConfiguration
    {
        public string PortName { get; set; }
        public int BaudRate { get; set; }
        public Parity Parity { get; set; }
        public int DataBits { get; set; }
        public StopBits StopBits { get; set; }
        public Encoding Encoding { get; set; }
        public Handshake Handshake { get; set; }
    }
}
