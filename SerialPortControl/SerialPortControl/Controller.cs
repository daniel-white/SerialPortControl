using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

using SerialPortControl.Model;

namespace SerialPortControl
{
    public class Controller : IController
    {
        SettingsRepository settings;
        AvailableSerialPortConfiguration aspc;

        IList<Command> _commands;

        public Controller()
        {
            settings = new SettingsRepository("SerialPortControl.xml");
            settings.Load();
            _commands = settings.AllCommands().ToList();
            //settings.AddCommand(new Command { Arguments = "1234", IncomingCommand = "Josh", Target = ">> explorer.exe", StartInDirectory = "c:\\" });
            settings.Save();
            aspc = new AvailableSerialPortConfiguration();
            
        }

       

        public void ShowMainForm()
        {
            MainForm mainForm = new MainForm(this);
            mainForm.ShowDialog();
        }

        #region IController Members


        public IEnumerable<Command> GetAllCommands()
        {
            return settings.AllCommands();
        }


        public IList<Command> Commands
        {
            get
            {
                return _commands;
            }
        }

        public void AddCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public void RemoveCommand(string key)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IController Members


        public Command GetCommand(string key)
        {
            return settings.SingleCommand(key);
        }



        #endregion

        #region IController Members


        public void UpdateCommand(string key, Command command)
        {
            throw new NotImplementedException();
        }

        public SerialPortConfiguration GetSerialPortConfiguration()
        {
            return settings.SerialPortConfiguration.Clone() as SerialPortConfiguration;
        }

        public AvailableSerialPortConfiguration GetAvailableSerialPortConfiguration()
        {
            return aspc;
        }

       

        #endregion
    }
}
