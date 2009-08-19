using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerialPortControl
{
    public interface IController
    {
        void ShowMainForm();
        IEnumerable<Model.Command> GetAllCommands();
        Model.Command GetCommand(string key);
        void AddCommand(Model.Command command);
        void RemoveCommand(string key);

        
    }
}
