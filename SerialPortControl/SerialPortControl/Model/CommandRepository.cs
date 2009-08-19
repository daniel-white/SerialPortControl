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
        private IDictionary<string, Command> _commands;
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

        public void Load()
        {
            _commands = new Dictionary<string, Command>();
           
            if (File.Exists(_xmlFilePath))
            {
                XDocument xCommandsDocument = XDocument.Load(_xmlFilePath);

                    var commandElements = xCommandsDocument.Element("Commands").Elements("Command");

                    foreach (var element in commandElements)
                    {
                        Command command = new Command
                        {
                            IncomingCommand = element.Element("IncommingCommand").Value,
                            Target = element.Element("Target").Value,
                            StartInDirectory = element.Element("StartInDirectory").Value
                        };
                        _commands.Add(command.IncomingCommand, command);
                    }
                
            }

            Dirty = false;
        }

        public void Save()
        {
            XDocument xCommandsDocument = new XDocument();
            var commandsElement =  new XElement("Commands");

            foreach (var command in _commands.Values)
            {
                XElement commandElement = new XElement("Command",
                        new XElement("IncommingCommand", command.IncomingCommand),
                        new XElement("Target", command.Target),
                        new XElement("StartInDirectory", command.StartInDirectory)
                    );

                commandsElement.Add(commandElement);
            }

            xCommandsDocument.Add(commandsElement);
            xCommandsDocument.Save(_xmlFilePath);
            Dirty = false;
        }
    }
}
