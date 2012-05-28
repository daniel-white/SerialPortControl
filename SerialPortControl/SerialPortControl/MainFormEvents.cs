using System;
using System.Collections.Generic;
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

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            SaveToController();

            Close();
        }

        private void addCommandButton_Click(object sender, EventArgs e)
        {
            StartAddItem();
        }

        private void commitEditCommandLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CommitEditCommand();
        }
        private void removeCommandButton_Click(object sender, EventArgs e)
        {
            RemoveCommand();
        }

        private void targetButton_Click(object sender, EventArgs e)
        {
            SelectTargetFromDialog();
        }

        private void startInButton_Click(object sender, EventArgs e)
        {
            SelectStartInFromDialog();
        }

        private void commandsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisableEditCommand();
            if (commandsListView.SelectedItems.Count > 0)
            {
                PopulateCommandForEditing(commandsListView.SelectedItems[0].Tag as string);
                removeCommandButton.Enabled = true;
            }
        }

    }
}
