using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Xml.Linq;

namespace SerialPortControl.Model
{
    public class SettingsRepository
    {
        private IDictionary<string, Command> _commands;
 
        private readonly string _xmlFilePath;

        public SettingsRepository(string xmlFilePath)
        {
            _xmlFilePath = xmlFilePath;
        }

        public bool Dirty { get; private set; }

        public IEnumerable<Command> AllCommands()
        {
            return _commands.Values.ToList().OrderBy(c => c.IncomingCommand);
        }

        public Command SingleCommand(string key)
        {
            return _commands[key];
        }

        public void RemoveCommand(Command command)
        {
            _commands.Remove(command.IncomingCommand);
            Dirty = true;
        }

        public void AddCommand(Command command)
        {
            _commands.Add(command.IncomingCommand, command);
            Dirty = true;
        }

        public void Load()
        {
            _commands = new Dictionary<string, Command>();
            SerialPortConfiguration = new SerialPortConfiguration();

            if (File.Exists(_xmlFilePath))
            {
                XElement spcElement = XDocument.Load(_xmlFilePath).Element("SerialPortControl");
                XElement portConfigurationElement = spcElement.Element("SerialPortConfiguration");
                var commandElements = spcElement.Element("Commands").Elements("Command");

                SerialPortConfiguration.PortName = portConfigurationElement.Element("PortName").Value;
                SerialPortConfiguration.BaudRate = Convert.ToInt32(portConfigurationElement.Element("BaudRate").Value);
                //portConfigurationElement.Element("Parity",      _serialPortConfiguration.Parity
                //portConfigurationElement.Element("DataBits",    _serialPortConfiguration.DataBits
                //portConfigurationElement.Element("StopBits",    _serialPortConfiguration.StopBits
                //portConfigurationElement.Element("Encoding",    _serialPortConfiguration.Encoding
                //portConfigurationElement.Element("Handshake",   _serialPortConfiguration.Handshake


                foreach (var element in commandElements)
                {
                    Command command = new Command
                    {
                        IncomingCommand = element.Element("IncomingCommand").Value,
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

            XElement spcElement = new XElement("SerialPortControl");
            XElement serialPortConfiguration = new XElement("SerialPortConfiguration");
            XElement commandsElement = new XElement("Commands");

            serialPortConfiguration.Add(
                new XElement("PortName", SerialPortConfiguration.PortName),
                new XElement("BaudRate", SerialPortConfiguration.BaudRate),
                new XElement("Parity", SerialPortConfiguration.Parity),
                new XElement("DataBits", SerialPortConfiguration.DataBits),
                new XElement("StopBits", SerialPortConfiguration.StopBits),
                new XElement("Encoding", SerialPortConfiguration.Encoding),
                new XElement("Handshake", SerialPortConfiguration.Handshake)
                );

            foreach (var command in _commands.Values)
            {
                XElement commandElement = new XElement("Command",
                        new XElement("IncomingCommand", command.IncomingCommand),
                        new XElement("Target", command.Target),
                        new XElement("Arguments", command.Arguments),
                        new XElement("StartInDirectory", command.StartInDirectory)
                    );

                commandsElement.Add(commandElement);
            }

            spcElement.Add(serialPortConfiguration);
            spcElement.Add(commandsElement);

            spcElement.Save(_xmlFilePath);

            Dirty = false;
        }

        public SerialPortConfiguration SerialPortConfiguration { get; private set; }
    }
}
