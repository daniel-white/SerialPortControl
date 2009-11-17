using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.IO.Ports;
using System.Xml.Linq;

namespace SerialPortControl.Model
{
    public interface ISettingsRepository
    {

        ICommandDictionary Commands { get; set; }
        bool WriteLog { get; set; }
        SerialPortSettings SerialPort { get; set; }
        bool Listening { get; set; }

        bool SettingsFileExists { get; }

        void Load();

        void Save();

        void CreateDefaultSettings();
    }
}
