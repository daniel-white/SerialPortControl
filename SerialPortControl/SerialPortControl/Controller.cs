using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Windows.Forms;
using SerialPortControl.Model;

namespace SerialPortControl
{
    public class Controller : IController
    {
        SettingsRepository settings;


        public Controller()
        {
            settings = new SettingsRepository("SerialPortControl.xml");
            
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

            MainForm mainForm = new MainForm(this);

            var result = mainForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                settings.Commands = Commands;
                settings.SerialPort = SerialPort;
                settings.WriteLog = WriteLog;
                settings.Save();
            }
        }

        #region IController Members

        

  



        #endregion

        #region IController Members


        public void UpdateCommand(string key, Command command)
        {
            throw new NotImplementedException();
        }

        

       

        #endregion
    }
}
