using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Windows.Forms;
using SerialPortControl.Model;
using SerialPortControl.IO;

namespace SerialPortControl
{
    public class Controller : IController
    {
        SettingsRepository settings;
        MainForm _mainForm;
        ISerialPortWatcher _theWatcher;
        ILog _theLogger;
        TrayIcon icon;

        public Controller()
        {
            _mainForm = new MainForm(this);
            settings = new SettingsRepository("SerialPortControl.xml");
            _theLogger = new Log();
            icon = new TrayIcon();

            icon.ShowSettings += new EventHandler(OnShowSettings);
            icon.Exit += new EventHandler(OnExitRequest);
            icon.ToggleListening += new EventHandler(OnToggleListening);
            ShowTrayIcon();

            if (settings.SettingsFileExists)
            {
                settings.Load();
                Commands = settings.Commands;
                SerialPort = settings.SerialPort;
                WriteLog = settings.WriteLog;
                _theLogger.Enabled = WriteLog;
                _theLogger.Write("Settings loaded from XML file.");
            }
            else
            {
                ShowMainForm();
                _theLogger.Write("Settings XML file created.");
            }

            

            if (SerialPort.Configurations.PortNames.Count() == 0)
            {
                MessageBox.Show("Unable to find any available COM ports on your system. Serial Port Control is cannot function.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                throw new IOException();
            }

            if (!settings.SettingsFileExists)
            {
                MessageBox.Show("Unable to find any configuration on your system. Serial Port Control is cannot function.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception();
            }

            _theWatcher = new SerialPortWatcher(SerialPort);
            _theWatcher.ReceivedData += new EventHandler<ReceivedDataEventArgs>(OnReceivedData);
            _theWatcher.StartedListening += new EventHandler(OnConnected);
            _theWatcher.StoppedListening += new EventHandler(OnDisconnected);

            if (settings.Listening)
                _theWatcher.Start();

        }

        void OnToggleListening(object sender, EventArgs e)
        {
            _theWatcher.Listening = !_theWatcher.Listening;
        }

        void OnExitRequest(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Are you sure you want to exit?", "Serial Port Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                icon.Visible = false;
                settings.Listening = _theWatcher.Listening;
                _theWatcher.Stop();
                Application.Exit();
            }
        }

        ~Controller()
        {
            icon.Visible = false;
            _theWatcher.Stop();
            settings.Save();
            _theLogger.Write("Controller is shutting down.");
        }

        public bool WriteLog { get; set; }
        public SerialPortSettings SerialPort { get; private set; }
        public ICommandDictionary Commands { get; private set; }

        public void ShowMainForm()
        {
            if (settings.SettingsFileExists)
            {
                settings.Load();
            }
            else
            {
                settings.CreateDefaultSettings();
            }
            Commands = settings.Commands;
            SerialPort = settings.SerialPort;
            WriteLog = settings.WriteLog;


            var result = _mainForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                settings.Commands = Commands;
                settings.SerialPort = SerialPort;
                settings.WriteLog = WriteLog;
                _theLogger.Enabled = WriteLog;
                settings.Save();

                if (_theWatcher != null)
                    _theWatcher.PortOptions = SerialPort;
            }
        }

        protected void OnReceivedData(object sender, ReceivedDataEventArgs e)
        {
            _theLogger.Write("Command \"{0}\" received.", e.Data);

            Command commandToRun = settings.Commands.SingleOrDefault(c => c.Key == e.Data).Value;

            if (commandToRun != null)
            {
                _theLogger.Write("Command \"{0}\" found. Executing target.", e.Data);
                try
                {
                    commandToRun.Run();
                }
                catch (Exception ex)
                {
                    _theLogger.Write("ERROR: Unable to run target - {0}", ex.Message);
                }
            }
            else
            {
                _theLogger.Write("ERROR: Command \"{0}\" not found.", e.Data);
            }
        }

        protected void OnShowSettings(object sender, EventArgs e)
        {
            if (_mainForm == null || !_mainForm.Visible)
                ShowMainForm();
            else
                _mainForm.Select();
        }

        protected void OnConnected(object sender, EventArgs e)
        {
            _theLogger.Write("Started listening.");
            
            icon.Listening = true;
        }

        protected void OnDisconnected(object sender, EventArgs e)
        {
            _theLogger.Write("Ended listening.");
            icon.Listening = false;
        }

        #region IController Members


        public void ShowTrayIcon()
        {
            icon.Visible = true;
        }

        public void HideTrayIcon()
        {
            icon.Visible = false;
        }

        #endregion
    }
}
