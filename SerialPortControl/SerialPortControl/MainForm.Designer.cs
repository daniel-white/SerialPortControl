namespace SerialPortControl
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.commandsTabPage = new System.Windows.Forms.TabPage();
            this.commandsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.argumentsLabel = new System.Windows.Forms.Label();
            this.argumentsTextBox = new System.Windows.Forms.TextBox();
            this.startInTextBox = new System.Windows.Forms.TextBox();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.startInLabel = new System.Windows.Forms.Label();
            this.targetLabel = new System.Windows.Forms.Label();
            this.commandsListView = new System.Windows.Forms.ListView();
            this.commandListViewHeader = new System.Windows.Forms.ColumnHeader();
            this.targetListViewHeader = new System.Windows.Forms.ColumnHeader();
            this.addCommandButton = new System.Windows.Forms.Button();
            this.removeCommandButton = new System.Windows.Forms.Button();
            this.incomingCommandLabel = new System.Windows.Forms.Label();
            this.incomingCommandTextBox = new System.Windows.Forms.TextBox();
            this.targetButton = new System.Windows.Forms.Button();
            this.startInButton = new System.Windows.Forms.Button();
            this.commitEditCommandLinkLabel = new System.Windows.Forms.LinkLabel();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.writeLogFileCheckBox = new System.Windows.Forms.CheckBox();
            this.emptyLogLinkLabel = new System.Windows.Forms.LinkLabel();
            this.openLogLinkLabel = new System.Windows.Forms.LinkLabel();
            this.portConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.portConfigurationTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.handshakeLabel = new System.Windows.Forms.Label();
            this.handshakeComboBox = new System.Windows.Forms.ComboBox();
            this.stopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.stopBitsLabel = new System.Windows.Forms.Label();
            this.dataBitsLabel = new System.Windows.Forms.Label();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.parityLabel = new System.Windows.Forms.Label();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.portNameLabel = new System.Windows.Forms.Label();
            this.portNameComboBox = new System.Windows.Forms.ComboBox();
            this.dataBitsTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainTableLayoutPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.commandsTabPage.SuspendLayout();
            this.commandsTableLayoutPanel.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.portConfigurationGroupBox.SuspendLayout();
            this.portConfigurationTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTableLayoutPanel.Controls.Add(this.okButton, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.cancelButton, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.tabControl, 0, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(4, 4);
            this.mainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(376, 456);
            this.mainTableLayoutPanel.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(217, 429);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 24);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(298, 429);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 24);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.tabControl, 2);
            this.tabControl.Controls.Add(this.commandsTabPage);
            this.tabControl.Controls.Add(this.settingsTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(370, 420);
            this.tabControl.TabIndex = 0;
            // 
            // commandsTabPage
            // 
            this.commandsTabPage.Controls.Add(this.commandsTableLayoutPanel);
            this.commandsTabPage.Location = new System.Drawing.Point(4, 24);
            this.commandsTabPage.Name = "commandsTabPage";
            this.commandsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.commandsTabPage.Size = new System.Drawing.Size(362, 392);
            this.commandsTabPage.TabIndex = 0;
            this.commandsTabPage.Text = "Commands";
            this.commandsTabPage.UseVisualStyleBackColor = true;
            // 
            // commandsTableLayoutPanel
            // 
            this.commandsTableLayoutPanel.ColumnCount = 3;
            this.commandsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.commandsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.commandsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.commandsTableLayoutPanel.Controls.Add(this.argumentsLabel, 0, 6);
            this.commandsTableLayoutPanel.Controls.Add(this.argumentsTextBox, 0, 7);
            this.commandsTableLayoutPanel.Controls.Add(this.startInTextBox, 0, 9);
            this.commandsTableLayoutPanel.Controls.Add(this.targetTextBox, 0, 5);
            this.commandsTableLayoutPanel.Controls.Add(this.startInLabel, 0, 8);
            this.commandsTableLayoutPanel.Controls.Add(this.targetLabel, 0, 4);
            this.commandsTableLayoutPanel.Controls.Add(this.commandsListView, 0, 0);
            this.commandsTableLayoutPanel.Controls.Add(this.addCommandButton, 1, 1);
            this.commandsTableLayoutPanel.Controls.Add(this.removeCommandButton, 2, 1);
            this.commandsTableLayoutPanel.Controls.Add(this.incomingCommandLabel, 0, 2);
            this.commandsTableLayoutPanel.Controls.Add(this.incomingCommandTextBox, 0, 3);
            this.commandsTableLayoutPanel.Controls.Add(this.targetButton, 2, 5);
            this.commandsTableLayoutPanel.Controls.Add(this.startInButton, 2, 9);
            this.commandsTableLayoutPanel.Controls.Add(this.commitEditCommandLinkLabel, 1, 10);
            this.commandsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.commandsTableLayoutPanel.Name = "commandsTableLayoutPanel";
            this.commandsTableLayoutPanel.RowCount = 11;
            this.commandsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.commandsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.commandsTableLayoutPanel.Size = new System.Drawing.Size(356, 386);
            this.commandsTableLayoutPanel.TabIndex = 1;
            // 
            // argumentsLabel
            // 
            this.argumentsLabel.AutoSize = true;
            this.commandsTableLayoutPanel.SetColumnSpan(this.argumentsLabel, 3);
            this.argumentsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.argumentsLabel.Location = new System.Drawing.Point(3, 270);
            this.argumentsLabel.Name = "argumentsLabel";
            this.argumentsLabel.Size = new System.Drawing.Size(350, 15);
            this.argumentsLabel.TabIndex = 12;
            this.argumentsLabel.Text = "&Arguments:";
            // 
            // argumentsTextBox
            // 
            this.commandsTableLayoutPanel.SetColumnSpan(this.argumentsTextBox, 3);
            this.argumentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.argumentsTextBox.Location = new System.Drawing.Point(3, 288);
            this.argumentsTextBox.Name = "argumentsTextBox";
            this.argumentsTextBox.Size = new System.Drawing.Size(350, 23);
            this.argumentsTextBox.TabIndex = 11;
            // 
            // startInTextBox
            // 
            this.commandsTableLayoutPanel.SetColumnSpan(this.startInTextBox, 2);
            this.startInTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startInTextBox.Location = new System.Drawing.Point(3, 332);
            this.startInTextBox.Name = "startInTextBox";
            this.startInTextBox.Size = new System.Drawing.Size(320, 23);
            this.startInTextBox.TabIndex = 8;
            // 
            // targetTextBox
            // 
            this.commandsTableLayoutPanel.SetColumnSpan(this.targetTextBox, 2);
            this.targetTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetTextBox.Location = new System.Drawing.Point(3, 243);
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.Size = new System.Drawing.Size(320, 23);
            this.targetTextBox.TabIndex = 7;
            // 
            // startInLabel
            // 
            this.startInLabel.AutoSize = true;
            this.commandsTableLayoutPanel.SetColumnSpan(this.startInLabel, 3);
            this.startInLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startInLabel.Location = new System.Drawing.Point(3, 314);
            this.startInLabel.Name = "startInLabel";
            this.startInLabel.Size = new System.Drawing.Size(350, 15);
            this.startInLabel.TabIndex = 5;
            this.startInLabel.Text = "&Start In:";
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.commandsTableLayoutPanel.SetColumnSpan(this.targetLabel, 3);
            this.targetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetLabel.Location = new System.Drawing.Point(3, 225);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(350, 15);
            this.targetLabel.TabIndex = 4;
            this.targetLabel.Text = "&Target:";
            // 
            // commandsListView
            // 
            this.commandsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.commandListViewHeader,
            this.targetListViewHeader});
            this.commandsTableLayoutPanel.SetColumnSpan(this.commandsListView, 3);
            this.commandsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandsListView.FullRowSelect = true;
            this.commandsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.commandsListView.HideSelection = false;
            this.commandsListView.Location = new System.Drawing.Point(3, 3);
            this.commandsListView.MultiSelect = false;
            this.commandsListView.Name = "commandsListView";
            this.commandsListView.Size = new System.Drawing.Size(350, 145);
            this.commandsListView.TabIndex = 0;
            this.commandsListView.UseCompatibleStateImageBehavior = false;
            this.commandsListView.View = System.Windows.Forms.View.Details;
            this.commandsListView.SelectedIndexChanged += new System.EventHandler(this.commandsListView_SelectedIndexChanged);
            // 
            // commandListViewHeader
            // 
            this.commandListViewHeader.Text = "Command";
            this.commandListViewHeader.Width = 120;
            // 
            // targetListViewHeader
            // 
            this.targetListViewHeader.Text = "Target";
            this.targetListViewHeader.Width = 236;
            // 
            // addCommandButton
            // 
            this.addCommandButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addCommandButton.Image = global::SerialPortControl.Properties.Resources.edit_add;
            this.addCommandButton.Location = new System.Drawing.Point(299, 154);
            this.addCommandButton.Name = "addCommandButton";
            this.addCommandButton.Size = new System.Drawing.Size(24, 24);
            this.addCommandButton.TabIndex = 2;
            this.addCommandButton.UseVisualStyleBackColor = true;
            this.addCommandButton.Click += new System.EventHandler(this.addCommandButton_Click);
            // 
            // removeCommandButton
            // 
            this.removeCommandButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeCommandButton.Image = global::SerialPortControl.Properties.Resources.edit_delete_mail;
            this.removeCommandButton.Location = new System.Drawing.Point(329, 154);
            this.removeCommandButton.Name = "removeCommandButton";
            this.removeCommandButton.Size = new System.Drawing.Size(24, 24);
            this.removeCommandButton.TabIndex = 2;
            this.removeCommandButton.UseVisualStyleBackColor = true;
            this.removeCommandButton.Click += new System.EventHandler(this.removeCommandButton_Click);
            // 
            // incomingCommandLabel
            // 
            this.incomingCommandLabel.AutoSize = true;
            this.commandsTableLayoutPanel.SetColumnSpan(this.incomingCommandLabel, 3);
            this.incomingCommandLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incomingCommandLabel.Location = new System.Drawing.Point(3, 181);
            this.incomingCommandLabel.Name = "incomingCommandLabel";
            this.incomingCommandLabel.Size = new System.Drawing.Size(350, 15);
            this.incomingCommandLabel.TabIndex = 3;
            this.incomingCommandLabel.Text = "&Incoming Command:";
            // 
            // incomingCommandTextBox
            // 
            this.commandsTableLayoutPanel.SetColumnSpan(this.incomingCommandTextBox, 3);
            this.incomingCommandTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incomingCommandTextBox.Location = new System.Drawing.Point(3, 199);
            this.incomingCommandTextBox.Name = "incomingCommandTextBox";
            this.incomingCommandTextBox.Size = new System.Drawing.Size(350, 23);
            this.incomingCommandTextBox.TabIndex = 3;
            // 
            // targetButton
            // 
            this.targetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.targetButton.Image = global::SerialPortControl.Properties.Resources.folder_brown;
            this.targetButton.Location = new System.Drawing.Point(329, 243);
            this.targetButton.Name = "targetButton";
            this.targetButton.Size = new System.Drawing.Size(24, 24);
            this.targetButton.TabIndex = 9;
            this.targetButton.UseVisualStyleBackColor = true;
            this.targetButton.Click += new System.EventHandler(this.targetButton_Click);
            // 
            // startInButton
            // 
            this.startInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startInButton.Image = global::SerialPortControl.Properties.Resources.folder_brown;
            this.startInButton.Location = new System.Drawing.Point(329, 332);
            this.startInButton.Name = "startInButton";
            this.startInButton.Size = new System.Drawing.Size(24, 24);
            this.startInButton.TabIndex = 10;
            this.startInButton.UseVisualStyleBackColor = true;
            this.startInButton.Click += new System.EventHandler(this.startInButton_Click);
            // 
            // commitEditCommandLinkLabel
            // 
            this.commitEditCommandLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.commitEditCommandLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.commitEditCommandLinkLabel.AutoSize = true;
            this.commandsTableLayoutPanel.SetColumnSpan(this.commitEditCommandLinkLabel, 2);
            this.commitEditCommandLinkLabel.DisabledLinkColor = System.Drawing.SystemColors.ControlDark;
            this.commitEditCommandLinkLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.commitEditCommandLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.commitEditCommandLinkLabel.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.commitEditCommandLinkLabel.Location = new System.Drawing.Point(299, 362);
            this.commitEditCommandLinkLabel.Margin = new System.Windows.Forms.Padding(3);
            this.commitEditCommandLinkLabel.Name = "commitEditCommandLinkLabel";
            this.commitEditCommandLinkLabel.Padding = new System.Windows.Forms.Padding(0, 3, 2, 3);
            this.commitEditCommandLinkLabel.Size = new System.Drawing.Size(54, 21);
            this.commitEditCommandLinkLabel.TabIndex = 14;
            this.commitEditCommandLinkLabel.TabStop = true;
            this.commitEditCommandLinkLabel.Text = "Commit";
            this.commitEditCommandLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.commitEditCommandLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.commitEditCommandLinkLabel_LinkClicked);
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.groupBox1);
            this.settingsTabPage.Controls.Add(this.portConfigurationGroupBox);
            this.settingsTabPage.Location = new System.Drawing.Point(4, 24);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.settingsTabPage.Size = new System.Drawing.Size(362, 392);
            this.settingsTabPage.TabIndex = 1;
            this.settingsTabPage.Text = "Settings";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(6, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 72);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logging";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.writeLogFileCheckBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.emptyLogLinkLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.openLogLinkLabel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(344, 48);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // writeLogFileCheckBox
            // 
            this.writeLogFileCheckBox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.writeLogFileCheckBox, 2);
            this.writeLogFileCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.writeLogFileCheckBox.Location = new System.Drawing.Point(0, 0);
            this.writeLogFileCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.writeLogFileCheckBox.Name = "writeLogFileCheckBox";
            this.writeLogFileCheckBox.Size = new System.Drawing.Size(344, 19);
            this.writeLogFileCheckBox.TabIndex = 2;
            this.writeLogFileCheckBox.Text = "&Log all incoming commands";
            this.writeLogFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // emptyLogLinkLabel
            // 
            this.emptyLogLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.emptyLogLinkLabel.AutoSize = true;
            this.emptyLogLinkLabel.DisabledLinkColor = System.Drawing.SystemColors.ControlDark;
            this.emptyLogLinkLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emptyLogLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.emptyLogLinkLabel.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.emptyLogLinkLabel.Location = new System.Drawing.Point(175, 22);
            this.emptyLogLinkLabel.Margin = new System.Windows.Forms.Padding(3);
            this.emptyLogLinkLabel.Name = "emptyLogLinkLabel";
            this.emptyLogLinkLabel.Padding = new System.Windows.Forms.Padding(0, 3, 2, 3);
            this.emptyLogLinkLabel.Size = new System.Drawing.Size(102, 21);
            this.emptyLogLinkLabel.TabIndex = 16;
            this.emptyLogLinkLabel.TabStop = true;
            this.emptyLogLinkLabel.Text = "Empty the log file";
            this.emptyLogLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // openLogLinkLabel
            // 
            this.openLogLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.openLogLinkLabel.AutoSize = true;
            this.openLogLinkLabel.DisabledLinkColor = System.Drawing.SystemColors.ControlDark;
            this.openLogLinkLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openLogLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.openLogLinkLabel.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.openLogLinkLabel.Location = new System.Drawing.Point(3, 22);
            this.openLogLinkLabel.Margin = new System.Windows.Forms.Padding(3);
            this.openLogLinkLabel.Name = "openLogLinkLabel";
            this.openLogLinkLabel.Padding = new System.Windows.Forms.Padding(0, 3, 2, 3);
            this.openLogLinkLabel.Size = new System.Drawing.Size(97, 21);
            this.openLogLinkLabel.TabIndex = 15;
            this.openLogLinkLabel.TabStop = true;
            this.openLogLinkLabel.Text = "Open the log file";
            this.openLogLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // portConfigurationGroupBox
            // 
            this.portConfigurationGroupBox.Controls.Add(this.portConfigurationTableLayoutPanel);
            this.portConfigurationGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.portConfigurationGroupBox.Location = new System.Drawing.Point(6, 6);
            this.portConfigurationGroupBox.Name = "portConfigurationGroupBox";
            this.portConfigurationGroupBox.Size = new System.Drawing.Size(350, 199);
            this.portConfigurationGroupBox.TabIndex = 0;
            this.portConfigurationGroupBox.TabStop = false;
            this.portConfigurationGroupBox.Text = "Port Configuration";
            // 
            // portConfigurationTableLayoutPanel
            // 
            this.portConfigurationTableLayoutPanel.ColumnCount = 2;
            this.portConfigurationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.portConfigurationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.portConfigurationTableLayoutPanel.Controls.Add(this.handshakeLabel, 0, 6);
            this.portConfigurationTableLayoutPanel.Controls.Add(this.handshakeComboBox, 1, 6);
            this.portConfigurationTableLayoutPanel.Controls.Add(this.stopBitsComboBox, 2, 5);
            this.portConfigurationTableLayoutPanel.Controls.Add(this.stopBitsLabel, 0, 5);
            this.portConfigurationTableLayoutPanel.Controls.Add(this.dataBitsLabel, 0, 4);
            this.portConfigurationTableLayoutPanel.Controls.Add(this.parityComboBox, 2, 3);
            this.portConfigurationTableLayoutPanel.Controls.Add(this.parityLabel, 0, 3);
            this.portConfigurationTableLayoutPanel.Controls.Add(this.baudRateComboBox, 2, 2);
            this.portConfigurationTableLayoutPanel.Controls.Add(this.baudRateLabel, 0, 2);
            this.portConfigurationTableLayoutPanel.Controls.Add(this.portNameLabel, 0, 0);
            this.portConfigurationTableLayoutPanel.Controls.Add(this.portNameComboBox, 1, 0);
            this.portConfigurationTableLayoutPanel.Controls.Add(this.dataBitsTextBox, 1, 4);
            this.portConfigurationTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.portConfigurationTableLayoutPanel.Location = new System.Drawing.Point(3, 19);
            this.portConfigurationTableLayoutPanel.Name = "portConfigurationTableLayoutPanel";
            this.portConfigurationTableLayoutPanel.RowCount = 6;
            this.portConfigurationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.portConfigurationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.portConfigurationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.portConfigurationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.portConfigurationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.portConfigurationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.portConfigurationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.portConfigurationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.portConfigurationTableLayoutPanel.Size = new System.Drawing.Size(344, 175);
            this.portConfigurationTableLayoutPanel.TabIndex = 0;
            // 
            // handshakeLabel
            // 
            this.handshakeLabel.AutoSize = true;
            this.handshakeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.handshakeLabel.Location = new System.Drawing.Point(3, 145);
            this.handshakeLabel.Name = "handshakeLabel";
            this.handshakeLabel.Size = new System.Drawing.Size(69, 30);
            this.handshakeLabel.TabIndex = 15;
            this.handshakeLabel.Text = "&Handshake:";
            this.handshakeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // handshakeComboBox
            // 
            this.handshakeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.handshakeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.handshakeComboBox.FormattingEnabled = true;
            this.handshakeComboBox.Location = new System.Drawing.Point(86, 148);
            this.handshakeComboBox.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.handshakeComboBox.Name = "handshakeComboBox";
            this.handshakeComboBox.Size = new System.Drawing.Size(255, 23);
            this.handshakeComboBox.TabIndex = 14;
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopBitsComboBox.FormattingEnabled = true;
            this.stopBitsComboBox.Location = new System.Drawing.Point(86, 119);
            this.stopBitsComboBox.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            this.stopBitsComboBox.Size = new System.Drawing.Size(255, 23);
            this.stopBitsComboBox.TabIndex = 13;
            // 
            // stopBitsLabel
            // 
            this.stopBitsLabel.AutoSize = true;
            this.stopBitsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopBitsLabel.Location = new System.Drawing.Point(3, 116);
            this.stopBitsLabel.Name = "stopBitsLabel";
            this.stopBitsLabel.Size = new System.Drawing.Size(69, 29);
            this.stopBitsLabel.TabIndex = 12;
            this.stopBitsLabel.Text = "&Stop bits:";
            this.stopBitsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataBitsLabel
            // 
            this.dataBitsLabel.AutoSize = true;
            this.dataBitsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataBitsLabel.Location = new System.Drawing.Point(3, 87);
            this.dataBitsLabel.Name = "dataBitsLabel";
            this.dataBitsLabel.Size = new System.Drawing.Size(69, 29);
            this.dataBitsLabel.TabIndex = 11;
            this.dataBitsLabel.Text = "&Data bits:";
            this.dataBitsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // parityComboBox
            // 
            this.parityComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.Location = new System.Drawing.Point(86, 61);
            this.parityComboBox.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Size = new System.Drawing.Size(255, 23);
            this.parityComboBox.TabIndex = 10;
            // 
            // parityLabel
            // 
            this.parityLabel.AutoSize = true;
            this.parityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parityLabel.Location = new System.Drawing.Point(3, 58);
            this.parityLabel.Name = "parityLabel";
            this.parityLabel.Size = new System.Drawing.Size(69, 29);
            this.parityLabel.TabIndex = 8;
            this.parityLabel.Text = "P&arity:";
            this.parityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Location = new System.Drawing.Point(86, 32);
            this.baudRateComboBox.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(255, 23);
            this.baudRateComboBox.TabIndex = 7;
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baudRateLabel.Location = new System.Drawing.Point(3, 29);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(69, 29);
            this.baudRateLabel.TabIndex = 5;
            this.baudRateLabel.Text = "&Baud rate:";
            this.baudRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // portNameLabel
            // 
            this.portNameLabel.AutoSize = true;
            this.portNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portNameLabel.Location = new System.Drawing.Point(3, 0);
            this.portNameLabel.Name = "portNameLabel";
            this.portNameLabel.Size = new System.Drawing.Size(69, 29);
            this.portNameLabel.TabIndex = 4;
            this.portNameLabel.Text = "&COM port:";
            this.portNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // portNameComboBox
            // 
            this.portNameComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portNameComboBox.FormattingEnabled = true;
            this.portNameComboBox.Location = new System.Drawing.Point(86, 3);
            this.portNameComboBox.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.portNameComboBox.Name = "portNameComboBox";
            this.portNameComboBox.Size = new System.Drawing.Size(255, 23);
            this.portNameComboBox.TabIndex = 6;
            // 
            // dataBitsTextBox
            // 
            this.dataBitsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataBitsTextBox.Location = new System.Drawing.Point(86, 90);
            this.dataBitsTextBox.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.dataBitsTextBox.Name = "dataBitsTextBox";
            this.dataBitsTextBox.Size = new System.Drawing.Size(255, 23);
            this.dataBitsTextBox.TabIndex = 9;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All files|*.*";
            this.openFileDialog.SupportMultiDottedExtensions = true;
            // 
            // MainForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(384, 464);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Port Control";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.commandsTabPage.ResumeLayout(false);
            this.commandsTableLayoutPanel.ResumeLayout(false);
            this.commandsTableLayoutPanel.PerformLayout();
            this.settingsTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.portConfigurationGroupBox.ResumeLayout(false);
            this.portConfigurationTableLayoutPanel.ResumeLayout(false);
            this.portConfigurationTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage commandsTabPage;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TableLayoutPanel commandsTableLayoutPanel;
        private System.Windows.Forms.ListView commandsListView;
        private System.Windows.Forms.Button addCommandButton;
        private System.Windows.Forms.Button removeCommandButton;
        private System.Windows.Forms.Label startInLabel;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.Label incomingCommandLabel;
        private System.Windows.Forms.TextBox startInTextBox;
        private System.Windows.Forms.TextBox targetTextBox;
        private System.Windows.Forms.TextBox incomingCommandTextBox;
        private System.Windows.Forms.Button targetButton;
        private System.Windows.Forms.Button startInButton;
        private System.Windows.Forms.ColumnHeader commandListViewHeader;
        private System.Windows.Forms.ColumnHeader targetListViewHeader;
        private System.Windows.Forms.Label argumentsLabel;
        private System.Windows.Forms.TextBox argumentsTextBox;
        private System.Windows.Forms.GroupBox portConfigurationGroupBox;
        private System.Windows.Forms.TableLayoutPanel portConfigurationTableLayoutPanel;
        private System.Windows.Forms.Label portNameLabel;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.ComboBox portNameComboBox;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.Label parityLabel;
        private System.Windows.Forms.TextBox dataBitsTextBox;
        private System.Windows.Forms.Label dataBitsLabel;
        private System.Windows.Forms.ComboBox parityComboBox;
        private System.Windows.Forms.Label handshakeLabel;
        private System.Windows.Forms.ComboBox handshakeComboBox;
        private System.Windows.Forms.ComboBox stopBitsComboBox;
        private System.Windows.Forms.Label stopBitsLabel;
        private System.Windows.Forms.LinkLabel commitEditCommandLinkLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.LinkLabel emptyLogLinkLabel;
        private System.Windows.Forms.LinkLabel openLogLinkLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox writeLogFileCheckBox;


    }
}

