using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var directory = new DirectoryInfo(@"C:\Windows\assembly");
            if (directory.Exists)
            {
                Console.WriteLine("FullName     : {0}", directory.FullName);
                Console.WriteLine("Name         : {0}", directory.Name);
                Console.WriteLine("Parent       : {0}", directory.Parent);
                Console.WriteLine("CreationTime : {0}", directory.CreationTime);
                Console.WriteLine("Attributes   : {0}", directory.Attributes);
            }
            else
            {
                Console.WriteLine("Директория с имене: {0} не существует", directory.FullName);
            }
            Console.ReadKey();
        }
    }
}
