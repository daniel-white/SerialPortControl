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
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.portConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.applicationSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.portConfigurationTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.portNameLabel = new System.Windows.Forms.Label();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.portNameComboBox = new System.Windows.Forms.ComboBox();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.commandsTabPage.SuspendLayout();
            this.commandsTableLayoutPanel.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
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
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(386, 466);
            this.mainTableLayoutPanel.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(227, 439);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 24);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(308, 439);
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
            this.tabControl.Size = new System.Drawing.Size(380, 430);
            this.tabControl.TabIndex = 0;
            // 
            // commandsTabPage
            // 
            this.commandsTabPage.Controls.Add(this.commandsTableLayoutPanel);
            this.commandsTabPage.Location = new System.Drawing.Point(4, 24);
            this.commandsTabPage.Name = "commandsTabPage";
            this.commandsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.commandsTabPage.Size = new System.Drawing.Size(372, 402);
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
            this.commandsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.commandsTableLayoutPanel.Name = "commandsTableLayoutPanel";
            this.commandsTableLayoutPanel.RowCount = 10;
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
            this.commandsTableLayoutPanel.Size = new System.Drawing.Size(366, 396);
            this.commandsTableLayoutPanel.TabIndex = 1;
            // 
            // argumentsLabel
            // 
            this.argumentsLabel.AutoSize = true;
            this.commandsTableLayoutPanel.SetColumnSpan(this.argumentsLabel, 3);
            this.argumentsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.argumentsLabel.Location = new System.Drawing.Point(3, 307);
            this.argumentsLabel.Name = "argumentsLabel";
            this.argumentsLabel.Size = new System.Drawing.Size(360, 15);
            this.argumentsLabel.TabIndex = 12;
            this.argumentsLabel.Text = "&Arguments:";
            // 
            // argumentsTextBox
            // 
            this.commandsTableLayoutPanel.SetColumnSpan(this.argumentsTextBox, 3);
            this.argumentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.argumentsTextBox.Location = new System.Drawing.Point(3, 325);
            this.argumentsTextBox.Name = "argumentsTextBox";
            this.argumentsTextBox.Size = new System.Drawing.Size(360, 23);
            this.argumentsTextBox.TabIndex = 11;
            // 
            // startInTextBox
            // 
            this.commandsTableLayoutPanel.SetColumnSpan(this.startInTextBox, 2);
            this.startInTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startInTextBox.Location = new System.Drawing.Point(3, 369);
            this.startInTextBox.Name = "startInTextBox";
            this.startInTextBox.Size = new System.Drawing.Size(330, 23);
            this.startInTextBox.TabIndex = 8;
            // 
            // targetTextBox
            // 
            this.commandsTableLayoutPanel.SetColumnSpan(this.targetTextBox, 2);
            this.targetTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetTextBox.Location = new System.Drawing.Point(3, 280);
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.Size = new System.Drawing.Size(330, 23);
            this.targetTextBox.TabIndex = 7;
            // 
            // startInLabel
            // 
            this.startInLabel.AutoSize = true;
            this.commandsTableLayoutPanel.SetColumnSpan(this.startInLabel, 3);
            this.startInLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startInLabel.Location = new System.Drawing.Point(3, 351);
            this.startInLabel.Name = "startInLabel";
            this.startInLabel.Size = new System.Drawing.Size(360, 15);
            this.startInLabel.TabIndex = 5;
            this.startInLabel.Text = "&Start In:";
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.commandsTableLayoutPanel.SetColumnSpan(this.targetLabel, 3);
            this.targetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetLabel.Location = new System.Drawing.Point(3, 262);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(360, 15);
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
            this.commandsListView.Size = new System.Drawing.Size(360, 182);
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
            this.addCommandButton.Location = new System.Drawing.Point(309, 191);
            this.addCommandButton.Name = "addCommandButton";
            this.addCommandButton.Size = new System.Drawing.Size(24, 24);
            this.addCommandButton.TabIndex = 2;
            this.addCommandButton.UseVisualStyleBackColor = true;
            // 
            // removeCommandButton
            // 
            this.removeCommandButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeCommandButton.Image = global::SerialPortControl.Properties.Resources.edit_delete_mail;
            this.removeCommandButton.Location = new System.Drawing.Point(339, 191);
            this.removeCommandButton.Name = "removeCommandButton";
            this.removeCommandButton.Size = new System.Drawing.Size(24, 24);
            this.removeCommandButton.TabIndex = 2;
            this.removeCommandButton.UseVisualStyleBackColor = true;
            // 
            // incomingCommandLabel
            // 
            this.incomingCommandLabel.AutoSize = true;
            this.commandsTableLayoutPanel.SetColumnSpan(this.incomingCommandLabel, 3);
            this.incomingCommandLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incomingCommandLabel.Location = new System.Drawing.Point(3, 218);
            this.incomingCommandLabel.Name = "incomingCommandLabel";
            this.incomingCommandLabel.Size = new System.Drawing.Size(360, 15);
            this.incomingCommandLabel.TabIndex = 3;
            this.incomingCommandLabel.Text = "&Incoming Command:";
            // 
            // incomingCommandTextBox
            // 
            this.commandsTableLayoutPanel.SetColumnSpan(this.incomingCommandTextBox, 3);
            this.incomingCommandTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incomingCommandTextBox.Location = new System.Drawing.Point(3, 236);
            this.incomingCommandTextBox.Name = "incomingCommandTextBox";
            this.incomingCommandTextBox.Size = new System.Drawing.Size(360, 23);
            this.incomingCommandTextBox.TabIndex = 3;
            // 
            // targetButton
            // 
            this.targetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.targetButton.Image = global::SerialPortControl.Properties.Resources.folder_brown;
            this.targetButton.Location = new System.Drawing.Point(339, 280);
            this.targetButton.Name = "targetButton";
            this.targetButton.Size = new System.Drawing.Size(24, 24);
            this.targetButton.TabIndex = 9;
            this.targetButton.UseVisualStyleBackColor = true;
            // 
            // startInButton
            // 
            this.startInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startInButton.Image = global::SerialPortControl.Properties.Resources.folder_brown;
            this.startInButton.Location = new System.Drawing.Point(339, 369);
            this.startInButton.Name = "startInButton";
            this.startInButton.Size = new System.Drawing.Size(24, 24);
            this.startInButton.TabIndex = 10;
            this.startInButton.UseVisualStyleBackColor = true;
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.applicationSettingsGroupBox);
            this.settingsTabPage.Controls.Add(this.portConfigurationGroupBox);
            this.settingsTabPage.Location = new System.Drawing.Point(4, 24);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.settingsTabPage.Size = new System.Drawing.Size(372, 402);
            this.settingsTabPage.TabIndex = 1;
            this.settingsTabPage.Text = "Settings";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // portConfigurationGroupBox
            // 
            this.portConfigurationGroupBox.Controls.Add(this.portConfigurationTableLayoutPanel);
            this.portConfigurationGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.portConfigurationGroupBox.Location = new System.Drawing.Point(6, 6);
            this.portConfigurationGroupBox.Name = "portConfigurationGroupBox";
            this.portConfigurationGroupBox.Size = new System.Drawing.Size(360, 199);
            this.portConfigurationGroupBox.TabIndex = 0;
            this.portConfigurationGroupBox.TabStop = false;
            this.portConfigurationGroupBox.Text = "Port Configuration";
            // 
            // applicationSettingsGroupBox
            // 
            this.applicationSettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.applicationSettingsGroupBox.Location = new System.Drawing.Point(6, 205);
            this.applicationSettingsGroupBox.Name = "applicationSettingsGroupBox";
            this.applicationSettingsGroupBox.Size = new System.Drawing.Size(360, 100);
            this.applicationSettingsGroupBox.TabIndex = 1;
            this.applicationSettingsGroupBox.TabStop = false;
            this.applicationSettingsGroupBox.Text = "Application";
            // 
            // portConfigurationTableLayoutPanel
            // 
            this.portConfigurationTableLayoutPanel.ColumnCount = 2;
            this.portConfigurationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.portConfigurationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.portConfigurationTableLayoutPanel.Controls.Add(this.label4, 0, 6);
            this.portConfigurationTableLayoutPanel.Controls.Add(this.comboBox5, 1, 6);
            this.portConfigurationTableLayoutPanel.Controls.Add(this.comboBox4, 2, 5);
            this.portConfigurationTableLayoutPanel.Controls.Add(this.label3, 0, 5);
            this.portConfigurationTableLayoutPanel.Controls.Add(this.label2, 0, 4);
            this.portConfigurationTableLayoutPanel.Controls.Add(this.comboBox3, 2, 3);
            this.portConfigurationTableLayoutPanel.Controls.Add(this.label1, 0, 3);
            this.portConfigurationTableLayoutPanel.Controls.Add(this.baudRateComboBox, 2, 2);
            this.portConfigurationTableLayoutPanel.Controls.Add(this.baudRateLabel, 0, 2);
            this.portConfigurationTableLayoutPanel.Controls.Add(this.portNameLabel, 0, 0);
            this.portConfigurationTableLayoutPanel.Controls.Add(this.portNameComboBox, 1, 0);
            this.portConfigurationTableLayoutPanel.Controls.Add(this.textBox1, 1, 4);
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
            this.portConfigurationTableLayoutPanel.Size = new System.Drawing.Size(354, 175);
            this.portConfigurationTableLayoutPanel.TabIndex = 0;
            // 
            // portNameLabel
            // 
            this.portNameLabel.AutoSize = true;
            this.portNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portNameLabel.Location = new System.Drawing.Point(3, 0);
            this.portNameLabel.Name = "portNameLabel";
            this.portNameLabel.Size = new System.Drawing.Size(69, 29);
            this.portNameLabel.TabIndex = 4;
            this.portNameLabel.Text = "&Port name:";
            this.portNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // portNameComboBox
            // 
            this.portNameComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portNameComboBox.FormattingEnabled = true;
            this.portNameComboBox.Location = new System.Drawing.Point(86, 3);
            this.portNameComboBox.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.portNameComboBox.Name = "portNameComboBox";
            this.portNameComboBox.Size = new System.Drawing.Size(265, 23);
            this.portNameComboBox.TabIndex = 6;
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Location = new System.Drawing.Point(86, 32);
            this.baudRateComboBox.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(265, 23);
            this.baudRateComboBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "P&arity:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(86, 90);
            this.textBox1.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 23);
            this.textBox1.TabIndex = 9;
            // 
            // comboBox3
            // 
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(86, 61);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(265, 23);
            this.comboBox3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "&Data bits:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "P&arity:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox4
            // 
            this.comboBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(86, 119);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(265, 23);
            this.comboBox4.TabIndex = 13;
            // 
            // comboBox5
            // 
            this.comboBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(86, 148);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(265, 23);
            this.comboBox5.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "&Handshake:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(394, 474);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.GroupBox applicationSettingsGroupBox;
        private System.Windows.Forms.TableLayoutPanel portConfigurationTableLayoutPanel;
        private System.Windows.Forms.Label portNameLabel;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.ComboBox portNameComboBox;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label3;


    }
}

