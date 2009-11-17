// An interface to write to a log text file

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerialPortControl.IO
{
    public interface ILog
    {
        void Write(string message);
        void Write(string format, params object[] args);
        void Empty();
        void Show();

        bool Enabled { get; set; }
    }
}
