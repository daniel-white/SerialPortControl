using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerialPortControl
{
    public class Controller : IController
    {
        Model.CommandRepository commandRepository;

        public Controller()
        {
            commandRepository = new Model.CommandRepository("commands.xml");
            commandRepository.Load();
        }

        public void ShowMainForm()
        {
            MainForm mainForm = new MainForm(this);
            mainForm.ShowDialog();
        }

        #region IController Members


        public IEnumerable<SerialPortControl.Model.Command> GetAllCommands()
        {
            return commandRepository.All();
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
    }
}
