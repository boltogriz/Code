using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatcherMessageBox
{
    internal class Watcher
    {
        public async Task StartWatch(string direction)
        {
            
            string dir = direction;
            MyData getDirekt = new MyData();
            DateTime startTime = DateTime.Now;

            if (direction == @"\\tal\mail")
                dir = getDirekt.GetData();

            while (!Directory.Exists(dir))
            {
                if ((DateTime.Now - startTime).TotalMinutes > 3600000)
                {
                    return;
                }

                await Task.Delay(30000);
            }

            FileSystemWatcher watcher = new FileSystemWatcher($@"{dir}");

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

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            if (e.Name.Contains("~$"))
                return;

            string title = "Почта";
            string attribute = GetAttribute(e.Name);
            string value = $"{e.Name}";

            value = FormatString(value, 60);

            if (attribute != "")
            {
                title = "Репликация";
                value += $"\n{attribute}";
            }

            NonBlockingMessageBox form = new NonBlockingMessageBox(value, title);

            MessageBox.Show(
                    value,
                    title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            if (e.Name.Contains("~$"))
                return;

            string title = "Переименовал";

            string value = $"Старое: {e.OldName}\n" +
                           $"Новое: {e.Name}";
            value = FormatString(value, 60);
            
            NonBlockingMessageBox form = new NonBlockingMessageBox(value, title);

            MessageBox.Show(
                    value,
                    title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
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

        private string FormatString(string str, int maxLength)
        {
            if (string.IsNullOrEmpty(str))
                return new string(' ', maxLength);

            if (str.Length <= maxLength)
            {
                return str.PadRight(maxLength);
            }

            return str;
        }
    }
}
