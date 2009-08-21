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
using System.IO;
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
        }

        public new DialogResult ShowDialog()
        {
            LoadCommandsListView();
            LoadSettings();
            DisableEditCommand();

            okButton.Select();
            commandsTabPage.Select();

            return base.ShowDialog();
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

            commitEditCommandLinkLabel.Enabled = false;
        }

        protected void EnableEditCommand()
        {
            removeCommandButton.Enabled = true;

            incomingCommandLabel.Enabled = true;
            incomingCommandTextBox.Enabled = true;
            incomingCommandTextBox.Text = "";

            targetLabel.Enabled = true;
            targetTextBox.Enabled = true;
            targetButton.Enabled = true;
            targetTextBox.Text = "";

            argumentsLabel.Enabled = true;
            argumentsTextBox.Enabled = true;
            targetTextBox.Text = "";

            startInLabel.Enabled = true;
            startInTextBox.Enabled = true;
            startInButton.Enabled = true;
            targetTextBox.Text = "";

            commitEditCommandLinkLabel.Enabled = true;
        }

        protected void LoadSerialPortSettings()
        {
            portNameComboBox.Items.AddRange(_controller.SerialPort.Configurations.PortNames.Cast<object>().ToArray());
            baudRateComboBox.Items.AddRange(_controller.SerialPort.Configurations.BaudRates.Cast<object>().ToArray());
            parityComboBox.Items.AddRange(_controller.SerialPort.Configurations.Parities.Cast<object>().ToArray());
            stopBitsComboBox.Items.AddRange(_controller.SerialPort.Configurations.StopBits.Cast<object>().ToArray());
            handshakeComboBox.Items.AddRange(_controller.SerialPort.Configurations.Handshakes.Cast<object>().ToArray());

            portNameComboBox.SelectedItem = _controller.SerialPort.PortName;
            baudRateComboBox.SelectedItem = ((int)_controller.SerialPort.BaudRate);
            parityComboBox.SelectedIndex = (int)_controller.SerialPort.Parity;
            dataBitsTextBox.Text = _controller.SerialPort.DataBits.ToString();
            stopBitsComboBox.SelectedIndex = (int)_controller.SerialPort.StopBits;
            handshakeComboBox.SelectedIndex = (int)_controller.SerialPort.Handshake;
        }

        protected void LoadSettings()
        {
            writeLogFileCheckBox.Checked = _controller.WriteLog;
            LoadSerialPortSettings();
        }


        public void LoadCommandsListView()
        {
            commandsListView.Items.Clear();

            foreach (var command in _controller.Commands.Values.OrderBy(i => i.IncomingCommand))
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

            _controller.SerialPort.PortName = portNameComboBox.SelectedItem as string;
            _controller.SerialPort.BaudRate = (BaudRate)baudRateComboBox.SelectedItem;
            _controller.SerialPort.Parity = parityComboBox.SelectedItem.ToEnumValue<Parity>();
            _controller.SerialPort.DataBits = Convert.ToInt32(dataBitsTextBox.Text);
            _controller.SerialPort.StopBits = stopBitsComboBox.SelectedItem.ToEnumValue<StopBits>();
            _controller.SerialPort.Handshake = handshakeComboBox.SelectedItem.ToEnumValue<Handshake>();
            
            _controller.WriteLog = writeLogFileCheckBox.Checked;

            Close();
        }

        private void addCommandButton_Click(object sender, EventArgs e)
        {
            StartAddItem();
        }

        protected void StartAddItem()
        {
            commandsListView.SelectedItems.Clear();
            EnableEditCommand();
            removeCommandButton.Enabled = false;
        }

        private void commitEditCommandLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CommitEditCommand();
        }

        protected void CommitEditCommand()
        {
            try {
                if (incomingCommandTextBox.Text.Length == 0)
                    throw new Exception("Please enter an Incoming Command.");

                if (_controller.Commands.Where(i => i.Key == incomingCommandTextBox.Text).Count() > 0)
                    throw new DuplicateNameException("There already exists a Command with that Incoming Command. Choose a different string.");

                if (!File.Exists(targetTextBox.Text))
                    throw new FileNotFoundException("The Target cannot be found.");

                Command command = new Command
                {
                    IncomingCommand = incomingCommandTextBox.Text,
                    Target = targetTextBox.Text,
                    Arguments = argumentsTextBox.Text,
                    StartInDirectory = startInTextBox.Text
                };

                _controller.Commands.Add(command);

                LoadCommandsListView();
                DisableEditCommand();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void removeCommandButton_Click(object sender, EventArgs e)
        {
            RemoveCommand();
        }

        void RemoveCommand()
        {
            DialogResult dr = MessageBox.Show("Do you want to remove this Command?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                _controller.Commands.Remove(commandsListView.SelectedItems[0].Tag as string);

                LoadCommandsListView();
                DisableEditCommand();
            }

        }

    }
}
