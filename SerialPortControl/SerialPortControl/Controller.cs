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

            icon = new TrayIcon();

            icon.ShowSettings += new EventHandler(OnShowSettings);

            if (SerialPort.Configurations.PortNames.Count() == 0)
            {
                MessageBox.Show("Unable to find any available COM ports on your system. Serial Port Control is cannot function.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            _theWatcher = new SerialPortWatcher(SerialPort);
            _theWatcher.ReceivedData += new EventHandler<ReceivedDataEventArgs>(OnReceivedData);
            _theWatcher.StartedListening += new EventHandler(OnConnected);
            _theWatcher.StoppedListening += new EventHandler(OnDisconnected);
            _theWatcher.Start();
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
            ShowMainForm();
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
