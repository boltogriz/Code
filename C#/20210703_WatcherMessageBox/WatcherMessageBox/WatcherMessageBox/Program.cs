using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Text;


namespace WatcherMessageBox
{

    static class Program
    {


        [STAThread]
        static void Main(string[] args)
        {
            string def = @"\\tal\mail";
            var watcher = new Watcher();

            if (args.Length != 0)
            {
                foreach (string arg in args)
                {
                    watcher.StartWatch(arg);
                }
            }
            else
            {
                watcher.StartWatch(def);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run();
        }
    }
}
