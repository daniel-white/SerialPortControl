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
            bool createdNew = false;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (new Mutex(true, "SerialPortControl", out createdNew))
            {
                if (createdNew)
                {

                    _controller = new Controller();

                    Application.Run();
                }
                else
                {
                    MessageBox.Show("Serial Port Control is already running.", "Serial Port Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        static void OnError(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString());
        }
        
    }
}
