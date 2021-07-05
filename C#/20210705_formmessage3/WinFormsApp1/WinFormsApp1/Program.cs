using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;

namespace WinFormsApp1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ToastContentBuilder MyMessage = new ToastContentBuilder();
            MyMessage.AddArgument("Почта");
            MyMessage.AddText("Hello");
            MyMessage.Show();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
