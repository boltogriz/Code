using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatcherMessageBox
{

    static class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            List<Watcher> watchers = new List<Watcher>();
            List<Task> tasks = new List<Task>();
            string def = @"C:\Users\Toha\Documents\testwatcher\norm";

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

            //TestCreateFolder(def);

            Application.EnableVisualStyles();
            Application.Run();
        }

        //private static void TestCreateFolder(string def)
        //{
        //    Timer timer = new Timer();
            
        //    timer.Interval = 500;
        //    timer.Tick += (object sender, EventArgs e) => { Directory.CreateDirectory($@"{def}\{DateTime.Now.Ticks}"); };
        //    timer.Start();
        //}
    }
}
