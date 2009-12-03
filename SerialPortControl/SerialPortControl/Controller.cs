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
        ISettingsRepository _settings;
        MainForm _mainForm;
        ISerialPortWatcher _theWatcher;
        ILog _theLogger;
        TrayIcon _trayIcon;

        public Controller()
        {
            _mainForm = new MainForm(this);
            _settings = new SettingsRepository("SerialPortControl.xml");
            _theLogger = new Log();
            _trayIcon = new TrayIcon();

            _trayIcon.ShowSettings += new EventHandler(OnShowSettings);
            _trayIcon.Exit += new EventHandler(OnExitRequest);
            _trayIcon.ToggleListening += new EventHandler(OnToggleListening);
            ShowTrayIcon();

            if (_settings.SettingsFileExists)
            {
                _settings.Load();
                Commands = _settings.Commands;
                SerialPort = _settings.SerialPort;
                WriteLog = _settings.WriteLog;
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
                Application.Exit();
            }

            if (!_settings.SettingsFileExists)
            {
                MessageBox.Show("Unable to find any configuration on your system. Serial Port Control is cannot function.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            _theWatcher = new SerialPortWatcher(SerialPort);
            _theWatcher.ReceivedData += new EventHandler<ReceivedDataEventArgs>(OnReceivedData);
            _theWatcher.StartedListening += new EventHandler(OnConnected);
            _theWatcher.StoppedListening += new EventHandler(OnDisconnected);

            if (_settings.Listening)
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
                _trayIcon.Visible = false;
                _settings.Listening = _theWatcher.Listening;
                _theWatcher.Stop();
                Application.Exit();
            }
        }

        ~Controller()
        {
            _trayIcon.Visible = false;
            _theWatcher.Stop();
            _settings.Save();
            _theLogger.Write("Controller is shutting down.");
        }

        public bool WriteLog { get; set; }
        public SerialPortSettings SerialPort { get; private set; }
        public ICommandDictionary Commands { get; private set; }

        public void ShowMainForm()
        {
            if (_settings.SettingsFileExists)
            {
                _settings.Load();
            }
            else
            {
                _settings.CreateDefaultSettings();
            }
            Commands = _settings.Commands;
            SerialPort = _settings.SerialPort;
            WriteLog = _settings.WriteLog;


            var result = _mainForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                _settings.Commands = Commands;
                _settings.SerialPort = SerialPort;
                _settings.WriteLog = WriteLog;
                _theLogger.Enabled = WriteLog;
                _settings.Save();

                if (_theWatcher != null)
                    _theWatcher.PortOptions = SerialPort;
            }
        }

        protected void OnReceivedData(object sender, ReceivedDataEventArgs e)
        {
            _theLogger.Write("Command \"{0}\" received.", e.Data);

            Command commandToRun = _settings.Commands.SingleOrDefault(c => c.Key == e.Data).Value;

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
            _trayIcon.Listening = true;
        }

        protected void OnDisconnected(object sender, EventArgs e)
        {
            _theLogger.Write("Ended listening.");
            _trayIcon.Listening = false;
        }

        #region IController Members


        public void ShowTrayIcon()
        {
            _trayIcon.Visible = true;
        }

        public void HideTrayIcon()
        {
            _trayIcon.Visible = false;
        }

        public void ShowLogFile()
        {
            _theLogger.Show();
        }
        public void EmptyLogFile()
        {
            _theLogger.Empty();
        }


        public void Start()
        {
            _theWatcher.Start();
        }

        public void Stop()
        {
            _theWatcher.Stop();
        }


        #endregion
    }
}
