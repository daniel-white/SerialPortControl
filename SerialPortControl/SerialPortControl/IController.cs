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

        IEnumerable<Command> GetAllCommands();
        Model.Command GetCommand(string key);
        void AddCommand(Command command);
        void RemoveCommand(string key);
        void UpdateCommand(string key, Command command);

        SerialPortConfiguration GetSerialPortConfiguration();
        AvailableSerialPortConfiguration GetAvailableSerialPortConfiguration();

    }
}
