using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatcherMessageBox
{
    internal class Watcher
    {
        private string talDir = @"\\tal\mail";
        private double timeOutWaitExistDir = 1800000;
        private int timeCheckExistDri = 30000;
        private int timeCheckRestartWatcher = 600000;

        private Timer timer;
        private FileSystemWatcher watcher;
        private string dir;
        private readonly string setDir;

        public Watcher(string direction) 
        {
            setDir = direction;
        }
        public async Task StartWatch()
        {
            DateTime startTime = DateTime.Now;

            dir = setDir;

            if (setDir == talDir)
                dir = MyData.GetData(talDir);


            while (!Directory.Exists(dir))
            {
                if ((DateTime.Now - startTime).TotalMinutes > timeOutWaitExistDir)
                {
                    return;
                }

                await Task.Delay(timeCheckExistDri);
            }

            timer = new Timer() { Interval = timeCheckRestartWatcher };
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

            string title = dir != null ? Path.GetFileName(dir) : "почта";
            string attributeRep = GetAttributeRep(e.Name);
            string value = $"{e.Name}";

            if (attributeRep != "")
            {
                title = "Репликация";
                value += $"\n{attributeRep}";
            }

            Application.Run(new CustomMessageBox(value, title));
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            if (e.Name.Contains("~$"))
                return;

            string title = "Переименовал в ";
            title += dir != null ? Path.GetFileName(dir) : "почта";

            string value = $"Старое: {e.OldName}\n" +
                           $"Новое: {e.Name}";

            Application.Run(new CustomMessageBox(value, title));
        }

        private string GetAttributeRep(string name)
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
