﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerialPortControl.Model
{
    public class Command
    {
        public string IncomingCommand { get; set; }
        public string Target { get; set; }
        public string StartInDirectory { get; set; }
        public string Arguments { get; set; }

        public Command Clone()
        {
            return new Command
            {
                IncomingCommand = this.IncomingCommand,
                Target = this.Target,
                StartInDirectory = this.StartInDirectory,
                Arguments = this.Arguments
            };
        }
    }

    public interface ICommandDictionary : IDictionary<string, Command>
    {
        ICommandDictionary Clone();
    }

    public class CommandDictionary : Dictionary<string, Command>, ICommandDictionary
    {
        public ICommandDictionary Clone()
        {
            CommandDictionary returnValue = new CommandDictionary();
            foreach (var item in this.Values)
            {
                returnValue.Add(item.IncomingCommand, item);
            }

            return returnValue;
        }
    }
}
