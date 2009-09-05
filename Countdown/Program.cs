using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SingleInstance;

namespace Countdown
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GenericExceptions.InitializeExceptions();
            SingleApplication.Run(new Main());
        }
    }
}