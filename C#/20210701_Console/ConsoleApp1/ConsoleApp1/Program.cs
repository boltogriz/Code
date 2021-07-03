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

            a.Folder("\\\\tal\\mail\\2021\\Июль\\02_07_2021");
        }
    }
}
