using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SerialPortControl
{
    public class TrayIcon
    {
        private NotifyIcon icon;

        public event EventHandler ShowSettings;
        public event EventHandler ToggleListening;
        public event EventHandler Exit;

        public TrayIcon()
        {
            icon = new NotifyIcon();
            icon.Icon = global::SerialPortControl.Properties.Resources.NotConnected;
            icon.Text = "Serial Port Control - Not Listening";
            icon.DoubleClick += new EventHandler(OnSettingsMenuItemClick);

            icon.ContextMenu = new ContextMenu();
            icon.ContextMenu.MenuItems.Add("&Settings").Click += new EventHandler(OnSettingsMenuItemClick);
            icon.ContextMenu.MenuItems.Add("&Listen").Click += new EventHandler(OnListeningMenuItemClick);
            icon.ContextMenu.MenuItems.Add("-");
            icon.ContextMenu.MenuItems.Add("E&xit").Click += new EventHandler(OnExitMenuItemClick);
            
        }

        protected void OnSettingsMenuItemClick(object sender, EventArgs e)
        {
            ShowSettings(sender, e);
        }

        protected void OnListeningMenuItemClick(object sender, EventArgs e)
        {
            ToggleListening(sender, e);
        }
        protected void OnExitMenuItemClick(object sender, EventArgs e)
        {
            Exit(sender, e);
        }




        public bool Visible { get { return icon.Visible; } set { icon.Visible = value; } }

        ~TrayIcon()
        {
            Visible = false;
        }

        public bool Listening
        {
            set
            {
                if (value)
                {
                    icon.Icon = global::SerialPortControl.Properties.Resources.Connected;
                    icon.Text = "Serial Port Control - Listening";
                    icon.ContextMenu.MenuItems[1].Checked = true;
                }
                else
                {
                    icon.Icon = global::SerialPortControl.Properties.Resources.NotConnected;
                    icon.Text = "Serial Port Control - Not Listening";
                    icon.ContextMenu.MenuItems[1].Checked = false;
                }
            }
        }
    }
}
