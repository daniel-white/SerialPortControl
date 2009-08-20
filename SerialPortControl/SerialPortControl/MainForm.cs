using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using SerialPortControl.Model;
using System.IO.Ports;
using System.Reflection;

namespace SerialPortControl
{
    public partial class MainForm : Form
    {
        private readonly IController _controller;
        public MainForm(IController controller)
        {
            InitializeComponent();
            _controller = controller;
           // commandsListView.DataBindings

            writeLogFileCheckBox.Checked = _controller.WriteLog;

            LoadCommandsListView();
            LoadSerialPortSettings();
            LoadSerialPortConfiguration();
            DisableEditCommand();
        }

        protected void DisableEditCommand()
        {
            removeCommandButton.Enabled = false;

            incomingCommandLabel.Enabled = false;
            incomingCommandTextBox.Enabled = false;
            incomingCommandTextBox.Text = "";

            targetLabel.Enabled = false;
            targetTextBox.Enabled = false;
            targetTextBox.Text = "";
            targetButton.Enabled = false;

            argumentsLabel.Enabled = false;
            argumentsTextBox.Enabled = false;
            argumentsTextBox.Text = "";

            startInLabel.Enabled = false;
            startInTextBox.Enabled = false;
            startInTextBox.Text = "";
            startInButton.Enabled = false;
        }

        protected void EnableEditCommand()
        {
            removeCommandButton.Enabled = true;

            incomingCommandLabel.Enabled = true;
            incomingCommandTextBox.Enabled = true;

            targetLabel.Enabled = true;
            targetTextBox.Enabled = true;
            targetButton.Enabled = true;

            argumentsLabel.Enabled = true;
            argumentsTextBox.Enabled = true;

            startInLabel.Enabled = true;
            startInTextBox.Enabled = true;
            startInButton.Enabled = true;
        }

        protected void LoadSerialPortSettings()
        {
            portNameComboBox.Items.AddRange(_controller.SerialPort.Configurations.PortNames.Cast<object>().ToArray());
            baudRateComboBox.Items.AddRange(_controller.SerialPort.Configurations.BaudRates.Cast<object>().ToArray());
            parityComboBox.Items.AddRange(_controller.SerialPort.Configurations.Parities.Cast<object>().ToArray());
            stopBitsComboBox.Items.AddRange(_controller.SerialPort.Configurations.StopBits.Cast<object>().ToArray());
            handshakeComboBox.Items.AddRange(_controller.SerialPort.Configurations.Handshakes.Cast<object>().ToArray());

            dataBitsTextBox.Text = _controller.SerialPort.DataBits.ToString();
            baudRateComboBox.SelectedItem = ((int)_controller.SerialPort.BaudRate);
            parityComboBox.SelectedIndex = (int)_controller.SerialPort.Parity;
            stopBitsComboBox.SelectedIndex = (int)_controller.SerialPort.StopBits;
            handshakeComboBox.SelectedIndex = (int)_controller.SerialPort.Handshake;
        }

        protected void LoadSerialPortConfiguration()
        {
            
            //portNameComboBox.SelectedValue = spc.PortName;
            //baudRateComboBox.SelectedValue = spc.BaudRate;
            parityComboBox.SelectedItem = _controller.SerialPort.Parity;
            ;
        }

        public void LoadCommandsListView()
        {
            foreach (var command in _controller.Commands.Values)
            {
                ListViewItem lvi = new ListViewItem(command.IncomingCommand);
                lvi.Tag = command.IncomingCommand;
                lvi.SubItems.Add(command.Target);
                commandsListView.Items.Add(lvi);
            }

            commandsListView.Columns[0].Width = (commandsListView.Width - 2) / 3;
            commandsListView.Columns[1].Width = -2;
        }

        private void commandsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (commandsListView.SelectedItems.Count > 0)
            {
                EnableEditCommand();
                var command = _controller.Commands[commandsListView.SelectedItems[0].Tag as string];
                incomingCommandTextBox.Text = command.IncomingCommand;
                targetTextBox.Text = command.Target;
                argumentsTextBox.Text = command.Arguments;
                startInTextBox.Text = command.StartInDirectory;
            }
            else
            {
                DisableEditCommand();
            }
           
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            _controller.WriteLog = writeLogFileCheckBox.Checked;
            _controller.SerialPort.Handshake = handshakeComboBox.SelectedItem.ToEnumValue<Handshake>();

            Close();
        }

        

      

    }
}
