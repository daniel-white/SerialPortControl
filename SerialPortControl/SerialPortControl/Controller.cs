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
        TrayIcon icon;

        public Controller()
        {
            settings = new SettingsRepository("SerialPortControl.xml");
            settings.Load();
            Commands = settings.Commands;
            SerialPort = settings.SerialPort;
            WriteLog = settings.WriteLog;

            

            if (SerialPort.Configurations.PortNames.Count() == 0)
            {
                MessageBox.Show("Unable to find any available COM ports on your system. Serial Port Control is cannot function.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            icon = new TrayIcon();

            icon.ShowSettings += new EventHandler(OnShowSettings);
            icon.Exit += new EventHandler(OnExitRequest);
            icon.ToggleListening += new EventHandler(OnToggleListening);
            ShowTrayIcon();

            _theWatcher = new SerialPortWatcher(SerialPort);
            _theWatcher.ReceivedData += new EventHandler<ReceivedDataEventArgs>(OnReceivedData);
            _theWatcher.StartedListening += new EventHandler(OnConnected);
            _theWatcher.StoppedListening += new EventHandler(OnDisconnected);
            _theWatcher.Start();

            
        }

        void OnToggleListening(object sender, EventArgs e)
        {
            _theWatcher.Enabled = !_theWatcher.Enabled;
        }

        void OnExitRequest(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Are you sure you want to exit?", "Serial Port Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                _theWatcher.Stop();
                Application.Exit();
            }
        }

        ~Controller()
        {
            icon.Visible = false;
            _theWatcher.Stop();
        }

        public bool WriteLog { get; set; }
        public SerialPortSettings SerialPort { get; private set; }
        public ICommandDictionary Commands { get; private set; }

        public void ShowMainForm()
        {
            settings.Load();
            Commands = settings.Commands;
            SerialPort = settings.SerialPort;
            WriteLog = settings.WriteLog;

            _mainForm = new MainForm(this);

            var result = _mainForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                settings.Commands = Commands;
                settings.SerialPort = SerialPort;
                settings.WriteLog = WriteLog;
                settings.Save();
                _theWatcher.PortOptions = SerialPort;
            }
        }

        protected void OnReceivedData(object sender, ReceivedDataEventArgs e)
        {
            settings.Commands[e.Data].Run();
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
            icon.Listening = true;
        }

        protected void OnDisconnected(object sender, EventArgs e)
        {
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
