using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WatcherMessageBox
{
    internal class Watcher
    {
        private Timer timer;
        private string talDir = @"C:\Users\admin\Documents\testw\mail";

        private FileSystemWatcher watcher;
        private string dir;
        private string setDir;

        public Watcher(string direction) 
        {
            setDir = direction;
        }
        public async Task StartWatch()
        {
            DateTime startTime = DateTime.Now;

            if (setDir == talDir)
                dir = MyData.GetData(talDir);


            while (!Directory.Exists(dir))
            {
                if ((DateTime.Now - startTime).TotalMinutes > 1000)//1800000
                {
                    return;
                }

                await Task.Delay(30000);
            }

            timer = new Timer() { Interval = 20000 };
            timer.Tick += CheckRestart;
            timer.Start();

            watcher = new FileSystemWatcher($@"{dir}");

            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;


            watcher.Created += OnCreated;
            watcher.Renamed += OnRenamed;

            watcher.Filter = "*.*";
            watcher.IncludeSubdirectories = false;
            watcher.EnableRaisingEvents = true;


        }

        private void CheckRestart(object sender, EventArgs e)
        {
            if (!IsStarted())
            {
                RestartWatch();
            }
        }

        public bool IsStarted()
        {
            if (setDir == talDir && dir != MyData.GetData(talDir))
            {
                return false;
            }
            else
            {
                return watcher != null && Directory.Exists(dir);
            }
        }

        public Task RestartWatch()
        {
            timer.Stop();
            StopWatch();
            return StartWatch();
        }

        private void StopWatch()
        {
            if (watcher != null)
            {
                watcher.Created -= OnCreated;
                watcher.Renamed -= OnRenamed;
            }
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            if (e.Name.Contains("~$"))
                return;

            string title = "Почта";
            string attribute = GetAttribute(e.Name);
            string value = $"{e.Name}";

            if (attribute != "")
            {
                title = "Репликация";
                value += $"\n{attribute}";
            }

            Application.Run(new CustomMessageBox(value, title));
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            if (e.Name.Contains("~$"))
                return;

            string title = "Переименовал";

            string value = $"Старое: {e.OldName}\n" +
                           $"Новое: {e.Name}";

            Application.Run(new CustomMessageBox(value, title));
        }

        private string GetAttribute(string name)
        {
            string attribute = "";

            if (name.Contains("UP_2331009400"))
                attribute = "Ейский КЦСОН";
            else if (name.Contains("UP_2331012265"))
                attribute = "Ейский МРЦ";
            else if (name.Contains("UP_2306021065"))
                attribute = "Ейский ДДИ";
            else if (name.Contains("UP_2306014452"))
                attribute = "Ейский ПНИ";
            else if (name.Contains("UP_2306021361"))
                attribute = "Ейский СРЦН";
            else if (name.Contains("UP_2331012280"))
                attribute = "Камышеватский СРЦН";
            else if (name.Contains("UP_2331005902"))
                attribute = "Камышеватский ДИПИ";

            return attribute;
        }
    }
}
