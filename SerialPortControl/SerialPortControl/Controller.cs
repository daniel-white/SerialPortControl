using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace SerialPortControl
{
    public class Controller : IController
    {
        Model.SettingsRepository commandRepository;

        public Controller()
        {
            commandRepository = new Model.SettingsRepository("SerialPortControl.xml");
            commandRepository.Load();
            commandRepository.AddCommand(new Model.Command { IncomingCommand = "test", StartInDirectory = "test", Target = "test /somearg" });
            commandRepository.Save();
            
        }

       

        public void ShowMainForm()
        {
            MainForm mainForm = new MainForm(this);
            mainForm.ShowDialog();
        }

        #region IController Members


        public IEnumerable<SerialPortControl.Model.Command> GetAllCommands()
        {
            return commandRepository.AllCommands();
        }

        public void AddCommand(SerialPortControl.Model.Command command)
        {
            throw new NotImplementedException();
        }

        public void RemoveCommand(string key)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IController Members


        public SerialPortControl.Model.Command GetCommand(string key)
        {
            return commandRepository.SingleCommand(key);
        }

        #endregion
    }
}
