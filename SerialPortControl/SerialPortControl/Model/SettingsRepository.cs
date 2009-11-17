using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.IO.Ports;
using System.Xml.Linq;

namespace SerialPortControl.Model
{
    // An xml repository
    public class SettingsRepository : ISettingsRepository
    {
        private readonly string _xmlFilePath;

        public SettingsRepository(string xmlFilePath)
        {
            _xmlFilePath = xmlFilePath;
        }

        ~SettingsRepository()
        {
            Save();
        }

        public ICommandDictionary Commands { get; set; }
        public bool WriteLog { get; set; }
        public SerialPortSettings SerialPort { get; set; }
        public bool Listening { get; set; }

        public bool SettingsFileExists { get { return File.Exists(_xmlFilePath); } }

        public void Load()
        {
            SerialPort = new SerialPortSettings();
            Commands = new CommandDictionary();
            if (SettingsFileExists)
            {
                XElement spcElement = XDocument.Load(_xmlFilePath).Element("SerialPortControl");
                XElement settingsElement = spcElement.Element("Settings");
                XElement serialPortElement = settingsElement.Element("SerialPort");
                var commandElements = spcElement.Element("Commands").Elements("Command");

                WriteLog = (bool)settingsElement.Element("WriteLog");
                Listening = (bool)settingsElement.Element("Listening");

                SerialPort.PortName = serialPortElement.Element("PortName").Value;
                SerialPort.BaudRate = (BaudRate)Convert.ToInt32(serialPortElement.Element("BaudRate").Value);
                SerialPort.Parity = serialPortElement.Element("Parity").ToEnumValue<Parity>();
                SerialPort.DataBits = Convert.ToInt32(serialPortElement.Element("DataBits").Value);
                SerialPort.StopBits = serialPortElement.Element("StopBits").ToEnumValue<StopBits>();
                SerialPort.Handshake = serialPortElement.Element("Handshake").ToEnumValue<Handshake>();


                foreach (var element in commandElements)
                {
                    Command command = new Command
                    {
                        IncomingCommand = element.Element("IncomingCommand").Value,
                        Target = element.Element("Target").Value,
                        Arguments = element.Element("Arguments").Value,
                        StartInDirectory = element.Element("StartInDirectory").Value
                    };
                    Commands.Add(command.IncomingCommand, command);
                }
            }
        }

        public void Save()
        {
            XElement spcElement = new XElement("SerialPortControl");
            XElement serialPortElement = new XElement("SerialPort");
            XElement settingsElement = new XElement("Settings");
            XElement commandsElement = new XElement("Commands");

            settingsElement.Add(new XElement("WriteLog", WriteLog));
            settingsElement.Add(new XElement("Listening", Listening));
            settingsElement.Add(serialPortElement);

            serialPortElement.Add(
                new XElement("PortName", SerialPort.PortName),
                new XElement("BaudRate", (int)SerialPort.BaudRate),
                new XElement("Parity", SerialPort.Parity),
                new XElement("DataBits", SerialPort.DataBits),
                new XElement("StopBits", SerialPort.StopBits),
                new XElement("Handshake", SerialPort.Handshake)
                );

            foreach (var command in Commands.Values)
            {
                XElement commandElement = new XElement("Command",
                        new XElement("IncomingCommand", command.IncomingCommand),
                        new XElement("Target", command.Target),
                        new XElement("Arguments", command.Arguments),
                        new XElement("StartInDirectory", command.StartInDirectory)
                    );

                commandsElement.Add(commandElement);
            }

            spcElement.Add(settingsElement);
            spcElement.Add(commandsElement);

            spcElement.Save(_xmlFilePath);
        }

        public void CreateDefaultSettings()
        {
            WriteLog = false;
            SerialPort = new SerialPortSettings();
            Commands = new CommandDictionary();

            SerialPort defaultConfig = new SerialPort();

            defaultConfig.Encoding = Encoding.ASCII;

            var portNames = System.IO.Ports.SerialPort.GetPortNames();
            if (portNames.Count() == 0)
                throw new Exception("No ports found");

            SerialPort.PortName = portNames[0];
            SerialPort.BaudRate = (BaudRate)defaultConfig.BaudRate;
            SerialPort.Parity = defaultConfig.Parity;
            SerialPort.DataBits = defaultConfig.DataBits;
            SerialPort.StopBits = defaultConfig.StopBits;
            SerialPort.Handshake = defaultConfig.Handshake;
        }
    }
}
