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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.commandsTabPage = new System.Windows.Forms.TabPage();
            this.configurationTabPage = new System.Windows.Forms.TabPage();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.commandsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.commandsListView = new System.Windows.Forms.ListView();
            this.incomingCommandLabel = new System.Windows.Forms.Label();
            this.targetLabel = new System.Windows.Forms.Label();
            this.startInLabel = new System.Windows.Forms.Label();
            this.incomingCommandTextBox = new System.Windows.Forms.TextBox();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.startInTextBox = new System.Windows.Forms.TextBox();
            this.addCommandButton = new System.Windows.Forms.Button();
            this.removeCommandButton = new System.Windows.Forms.Button();
            this.targetButton = new System.Windows.Forms.Button();
            this.startInButton = new System.Windows.Forms.Button();
            this.commandListViewHeader = new System.Windows.Forms.ColumnHeader();
            this.targetListViewHeader = new System.Windows.Forms.ColumnHeader();
            this.mainTableLayoutPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.commandsTabPage.SuspendLayout();
            this.commandsTableLayoutPanel.SuspendLayout();
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
            // tabControl
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.tabControl, 2);
            this.tabControl.Controls.Add(this.commandsTabPage);
            this.tabControl.Controls.Add(this.configurationTabPage);
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
            // configurationTabPage
            // 
            this.configurationTabPage.Location = new System.Drawing.Point(4, 24);
            this.configurationTabPage.Name = "configurationTabPage";
            this.configurationTabPage.Size = new System.Drawing.Size(372, 402);
            this.configurationTabPage.TabIndex = 1;
            this.configurationTabPage.Text = "Configuration";
            this.configurationTabPage.UseVisualStyleBackColor = true;
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
            // commandsTableLayoutPanel
            // 
            this.commandsTableLayoutPanel.ColumnCount = 3;
            this.commandsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.commandsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.commandsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.commandsTableLayoutPanel.Controls.Add(this.startInTextBox, 0, 7);
            this.commandsTableLayoutPanel.Controls.Add(this.targetTextBox, 0, 5);
            this.commandsTableLayoutPanel.Controls.Add(this.startInLabel, 0, 6);
            this.commandsTableLayoutPanel.Controls.Add(this.targetLabel, 0, 4);
            this.commandsTableLayoutPanel.Controls.Add(this.commandsListView, 0, 0);
            this.commandsTableLayoutPanel.Controls.Add(this.addCommandButton, 1, 1);
            this.commandsTableLayoutPanel.Controls.Add(this.removeCommandButton, 2, 1);
            this.commandsTableLayoutPanel.Controls.Add(this.incomingCommandLabel, 0, 2);
            this.commandsTableLayoutPanel.Controls.Add(this.incomingCommandTextBox, 0, 3);
            this.commandsTableLayoutPanel.Controls.Add(this.targetButton, 2, 5);
            this.commandsTableLayoutPanel.Controls.Add(this.startInButton, 2, 7);
            this.commandsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.commandsTableLayoutPanel.Name = "commandsTableLayoutPanel";
            this.commandsTableLayoutPanel.RowCount = 8;
            this.commandsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            this.commandsListView.Size = new System.Drawing.Size(360, 226);
            this.commandsListView.TabIndex = 0;
            this.commandsListView.UseCompatibleStateImageBehavior = false;
            this.commandsListView.View = System.Windows.Forms.View.Details;
            this.commandsListView.SelectedIndexChanged += new System.EventHandler(this.commandsListView_SelectedIndexChanged);
            // 
            // incomingCommandLabel
            // 
            this.incomingCommandLabel.AutoSize = true;
            this.commandsTableLayoutPanel.SetColumnSpan(this.incomingCommandLabel, 3);
            this.incomingCommandLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incomingCommandLabel.Location = new System.Drawing.Point(3, 262);
            this.incomingCommandLabel.Name = "incomingCommandLabel";
            this.incomingCommandLabel.Size = new System.Drawing.Size(360, 15);
            this.incomingCommandLabel.TabIndex = 3;
            this.incomingCommandLabel.Text = "&Incoming Command:";
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.commandsTableLayoutPanel.SetColumnSpan(this.targetLabel, 3);
            this.targetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetLabel.Location = new System.Drawing.Point(3, 306);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(360, 15);
            this.targetLabel.TabIndex = 4;
            this.targetLabel.Text = "&Target:";
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
            // incomingCommandTextBox
            // 
            this.commandsTableLayoutPanel.SetColumnSpan(this.incomingCommandTextBox, 2);
            this.incomingCommandTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incomingCommandTextBox.Location = new System.Drawing.Point(3, 280);
            this.incomingCommandTextBox.Name = "incomingCommandTextBox";
            this.incomingCommandTextBox.Size = new System.Drawing.Size(330, 23);
            this.incomingCommandTextBox.TabIndex = 3;
            // 
            // targetTextBox
            // 
            this.commandsTableLayoutPanel.SetColumnSpan(this.targetTextBox, 2);
            this.targetTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetTextBox.Location = new System.Drawing.Point(3, 324);
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.Size = new System.Drawing.Size(330, 23);
            this.targetTextBox.TabIndex = 7;
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
            // addCommandButton
            // 
            this.addCommandButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addCommandButton.Image = global::SerialPortControl.Properties.Resources.edit_add;
            this.addCommandButton.Location = new System.Drawing.Point(309, 235);
            this.addCommandButton.Name = "addCommandButton";
            this.addCommandButton.Size = new System.Drawing.Size(24, 24);
            this.addCommandButton.TabIndex = 2;
            this.addCommandButton.UseVisualStyleBackColor = true;
            // 
            // removeCommandButton
            // 
            this.removeCommandButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeCommandButton.Image = global::SerialPortControl.Properties.Resources.edit_delete_mail;
            this.removeCommandButton.Location = new System.Drawing.Point(339, 235);
            this.removeCommandButton.Name = "removeCommandButton";
            this.removeCommandButton.Size = new System.Drawing.Size(24, 24);
            this.removeCommandButton.TabIndex = 2;
            this.removeCommandButton.UseVisualStyleBackColor = true;
            // 
            // targetButton
            // 
            this.targetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.targetButton.Image = global::SerialPortControl.Properties.Resources.folder_brown;
            this.targetButton.Location = new System.Drawing.Point(339, 324);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage commandsTabPage;
        private System.Windows.Forms.TabPage configurationTabPage;
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


    }
}

