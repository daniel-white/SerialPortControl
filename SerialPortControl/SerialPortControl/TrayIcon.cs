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

        public TrayIcon()
        {
            icon = new NotifyIcon();
            icon.Icon = global::SerialPortControl.Properties.Resources.NotConnected;
        }

        public bool Visible { get { return icon.Visible; } set { icon.Visible = value; } }

        public bool Connected
        {
            set
            {
                if (value)
                    icon.Icon = global::SerialPortControl.Properties.Resources.Connected;
                else
                    icon.Icon = global::SerialPortControl.Properties.Resources.NotConnected;
            }
        }
    }
}
