using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SerialPortControl
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        static IController _controller;
        [STAThread]
        static void Main()
        {
            _controller = new Controller();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _controller.ShowMainForm();
            Application.Run(new MainForm(_controller));
        }
    }
}
