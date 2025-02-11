using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;


namespace WatcherMessageBox
{

    static class Program
    {

        [STAThread]
        static async Task Main(string[] args)
        {
            List<Watcher> watchers = new List<Watcher>();
            List<Task> tasks = new List<Task>();
            string def = @"C:\Users\admin\Documents\testw\mail";

            if (args.Length != 0)
            {
                foreach (string arg in args)
                {
                    Watcher watcher = new Watcher(arg);
                    watchers.Add(watcher);

                    tasks.Add(watcher.StartWatch());
                }
            }
            else
            {
                Watcher watcher = new Watcher(def);
                watchers.Add(watcher);

                tasks.Add(watcher.StartWatch());
            }

            Application.EnableVisualStyles();
            Application.Run();
        }
    }
}
