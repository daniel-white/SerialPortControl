using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SerialPortControl.Model;

namespace SerialPortControl
{
    public interface IController
    {
        void ShowMainForm();

        ICommandDictionary Commands { get; }
        bool WriteLog { get; set; }
        SerialPortSettings SerialPort { get; }

        void ShowTrayIcon();
        void HideTrayIcon();

    }
}
