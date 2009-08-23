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
            _logWriter = new StreamWriter("Log.txt", true);
        }

        #region ILog Members

        public void Write(string message)
        {
            if (!Enabled || !_logWriter.BaseStream.CanWrite) return;

            string entry = string.Format("[{0:G}] {1}", DateTime.Now, message);

            _logWriter.WriteLine(entry);
            _logWriter.Flush();
        }

        public void Write(string format, params object[] args)
        {
            Write(string.Format(format, args));
        }

        public void Empty()
        {
            bool wasEnabled = Enabled;
            Enabled = false;
            _logWriter.Close();
            _logWriter = new StreamWriter("Log.txt", false);
            Enabled = wasEnabled;
        }

        public void Show()
        {
            Process.Start("Log.txt");
        }

        public bool Enabled { get; set; }

        #endregion
    }
}
