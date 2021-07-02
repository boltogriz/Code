using System;
using System.IO;

namespace ConsoleApp1
{
    class MyClass
    {
        public int field;
        public void Method() 
        {
            Console.WriteLine(field);
        }
        public void Filename(string PathToFolder)
        {
            string[] allfiles = Directory.GetFiles(PathToFolder);
            foreach (string filename in allfiles)
            {
                Console.WriteLine(filename);
            }
        }
        public void Folder(string PathToFolder)
        {
            string[] allfolders = Directory.GetDirectories(PathToFolder);
            foreach (string folder in allfolders)
            {
                Console.WriteLine(folder);
            }
        }
    }
    public class Watcher
    {

        public static void Main()
        {
            Run();
        }

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public static void Run()
        {
            string[] args = System.Environment.GetCommandLineArgs();

            // If a directory is not specified, exit program.
            if (args.Length != 2)
            {
                // Display the proper way to call the program.
                Console.WriteLine("Usage: Watcher.exe (directory)");
                return;
            }

            // Create a new FileSystemWatcher and set its properties.
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = args[1];
            /* Watch for changes in LastAccess and LastWrite times, and
               the renaming of files or directories. */
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            // Only watch text files.
            watcher.Filter = "*.txt";

            // Add event handlers.
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            // Begin watching.
            watcher.EnableRaisingEvents = true;

            // Wait for the user to quit the program.
            Console.WriteLine("Press \'q\' to quit the sample.");
            while (Console.Read() != 'q') ;
        }

        // Define the event handlers.
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            // Specify what is done when a file is changed, created, or deleted.
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
        }

        private static void OnRenamed(object source, RenamedEventArgs e)
        {
            // Specify what is done when a file is renamed.
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.field = 1;
            a.Method();

            MyClass b = new MyClass();
            b.field = 2;
            b.Method();

            //a.Folder("\\\\tal\\mail\\2021\\Июль\\02_07_2021");
        }
    }
}
