using Microsoft.VisualBasic;
using System;
using System.IO;

namespace ITVDN_Lessons_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             UNDONE: Many
             TODO: Work
             HACK: My console adds words

             */
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Class1 MyC = new Class1();
            do
            {
                Console.WriteLine("\nWrite your name:");
                MyC.Name = Console.ReadLine();
                MyC.MyConsole();
            } while (MyC.Name != "exit");
        }
    }
}
