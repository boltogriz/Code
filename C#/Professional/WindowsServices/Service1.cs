using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsServices
{
    public partial class Service1 : ServiceBase
    {
        FileInfo file;
        StreamWriter writer;
        FileSystemWatcher watcher;

        public Service1()
        {
            InitializeComponent();
            file = new FileInfo(@"C:\testserver\Log.txt");
            writer = file.CreateText();

            watcher = new FileSystemWatcher(@"C:\testserver\");
            watcher.Changed += WatcherChanged;
            watcher.Deleted += WatcherChanged;
            watcher.Renamed += WatcherChanged;
            watcher.Created += WatcherChanged;
        }

        private void WatcherChanged(object sender, FileSystemEventArgs e)
        {
            writer.WriteLine("Directory changed({0}): {1}", e.ChangeType, e.FullPath);
            writer.Flush();
        }

        protected override void OnStart(string[] args)
        {
            watcher.EnableRaisingEvents = true;
        }

        protected override void OnStop()
        {
            watcher.EnableRaisingEvents= false;
        }
    }
}
