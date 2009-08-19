using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SerialPortControl
{
    public partial class MainForm : Form
    {
        private readonly IController _controller;
        public MainForm(IController controller)
        {
            InitializeComponent();
            _controller = controller;
            LoadCommandsListView();
            LoadSerialPortConfigItems();
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

        protected void LoadSerialPortConfigItems()
        {
            portNameComboBox.Items.AddRange(_controller.GetAvailableSerialPortConfiguration().PortNames.ToArray());
            baudRateComboBox.Items.AddRange(_controller.GetAvailableSerialPortConfiguration().BaudRates.Cast<object>().ToArray());
        }

        public void LoadCommandsListView()
        {
            foreach (var command in _controller.GetAllCommands())
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
                var command = _controller.GetCommand(commandsListView.SelectedItems[0].Tag as string);
                incomingCommandTextBox.Text = command.IncomingCommand;
                targetTextBox.Text = command.Target;
            }
            else
            {
                DisableEditCommand();
            }
           
        }

        

      

    }
}
