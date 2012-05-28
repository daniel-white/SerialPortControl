// An implementation for log writing using a stream reader
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Diagnostics;

namespace SerialPortControl.IO
{
    public class Log : ILog
    {
        StreamWriter _logWriter;

        public Log()
        {
            // Open up the log file
            _logWriter = new StreamWriter("Log.txt", true);
        }

        #region ILog Members

        public void Write(string message)
        {
            // Make sure logging is turned on and the stream is a able to be written to.
            if (!Enabled || !_logWriter.BaseStream.CanWrite) return;

            // generate the entry
            string entry = string.Format("[{0:G}] {1}", DateTime.Now, message);

            // write the log to disk
            _logWriter.WriteLine(entry);
            _logWriter.Flush();
        }

        public void Write(string format, params object[] args)
        {
            // Use string formatting to make it easier
            Write(string.Format(format, args));
        }

        public void Empty()
        {
            // store the setting a way to restore later
            bool wasEnabled = Enabled;
            Enabled = false;

            // close and start a new file
            _logWriter.Close();
            _logWriter = new StreamWriter("Log.txt", false);

            // restore the enabled state
            Enabled = wasEnabled;
        }

        public void Show()
        {
            // show the log file with the default program
            Process.Start("Log.txt");
        }

        public bool Enabled { get; set; }

        #endregion
    }
}
