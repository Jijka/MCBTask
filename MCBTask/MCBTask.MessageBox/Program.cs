using System;
using System.Windows.Forms;

namespace MCBTask.MessageBox
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
            Application.Run(new MessageBoxImproved("Very Big long text about warning", "Caption of the messageBox", 5));
        }
    }
}
