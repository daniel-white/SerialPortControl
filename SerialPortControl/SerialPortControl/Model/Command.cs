using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerialPortControl.Model
{
    public class Command
    {
        public string IncomingCommand { get; set; }
        public string Target { get; set; }
        public string StartInDirectory { get; set; }
    }
}
