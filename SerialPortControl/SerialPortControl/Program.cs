using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

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
            Application.ThreadException += new ThreadExceptionEventHandler(OnError);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            _controller = new Controller();
            
            Application.Run();
        }

        static void OnError(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString());
        }
        
    }
}
