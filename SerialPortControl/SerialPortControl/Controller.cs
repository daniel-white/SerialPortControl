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
        AvailableSerialPortConfiguration aspc;


        public Controller()
        {
            settings = new SettingsRepository("SerialPortControl.xml");
            settings.Load();
    
            //settings.AddCommand(new Command { Arguments = "1234", IncomingCommand = "Josh", Target = ">> explorer.exe", StartInDirectory = "c:\\" });
            settings.Save();
            aspc = new AvailableSerialPortConfiguration();
            
        }

        public bool WriteLog { get; set; }

        public SerialPortConfiguration SerialPort { get; private set; }

        public void ShowMainForm()
        {
            Commands = settings.Commands;
            SerialPort = settings.SerialPort;

            MainForm mainForm = new MainForm(this);

            var result = mainForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                settings.Commands = Commands;
                settings.SerialPort = SerialPort;
                settings.Save();
            }
        }

        #region IController Members

        public ICommandDictionary Commands
        {
            get;
            private set;
        }

  



        #endregion

        #region IController Members


        public void UpdateCommand(string key, Command command)
        {
            throw new NotImplementedException();
        }

        

        public AvailableSerialPortConfiguration GetAvailableSerialPortConfiguration()
        {
            return aspc;
        }

       

        #endregion
    }
}
