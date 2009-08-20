﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Windows.Forms;
using SerialPortControl.Model;
using SerialPortControl.IO;

namespace SerialPortControl
{
    public class Controller : IController
    {
        SettingsRepository settings;
        MainForm _mainForm;
        ISerialPortWatcher _theWatcher;

        public Controller()
        {
            settings = new SettingsRepository("SerialPortControl.xml");
            settings.Load();
            Commands = settings.Commands;
            SerialPort = settings.SerialPort;
            WriteLog = settings.WriteLog;

            _theWatcher = new SerialPortWatcher(SerialPort);
            _theWatcher.Start();
        }

        public bool WriteLog { get; set; }
        public SerialPortSettings SerialPort { get; private set; }
        public ICommandDictionary Commands { get; private set; }

        public void ShowMainForm()
        {
            settings.Load();
            Commands = settings.Commands;
            SerialPort = settings.SerialPort;
            WriteLog = settings.WriteLog;

            _mainForm = new MainForm(this);

            var result = _mainForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                settings.Commands = Commands;
                settings.SerialPort = SerialPort;
                settings.WriteLog = WriteLog;
                settings.Save();
                _theWatcher.PortOptions = SerialPort;
            }
        }

    }
}
