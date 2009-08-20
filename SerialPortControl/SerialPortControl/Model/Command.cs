using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;



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

        public void Run()
        {
            Process.Start(
                new ProcessStartInfo { FileName = Target, WorkingDirectory = StartInDirectory, Arguments = Arguments }
            );
        }
    }

    public interface ICommandDictionary : IDictionary<string, Command>
    {
        ICommandDictionary Clone();
        void Add(Command command);
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

        public void Add(Command command)
        {
            Add(command.IncomingCommand, command);
        }
    }


}
