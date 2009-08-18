using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Xml.Linq;

namespace SerialPortControl.Model
{
    public class CommandRepository
    {
        private readonly IDictionary<string, Command> _commands;
        private readonly string _xmlFilePath;

        public CommandRepository(string xmlFilePath)
        {
            _xmlFilePath = xmlFilePath;
        }

        public bool Dirty { get; private set; }

        public IEnumerable<Command> All()
        {
            return _commands.Values.ToList().OrderBy(c => c.IncomingCommand);
        }

        public Command Single(string key)
        {
            return _commands[key];
        }

        public void Remove(Command command)
        {
            _commands.Remove(command.IncomingCommand);
            Dirty = true;
        }

        public void Add(Command command)
        {
            _commands.Add(command.IncomingCommand, command);
            Dirty = true;
        }

        public void Load(string xmlFilePath)
        {
            Dirty = false;
        }

        public void Save()
        {
            Dirty = false;
        }
    }
}
