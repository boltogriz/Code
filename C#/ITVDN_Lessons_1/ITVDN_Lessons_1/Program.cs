using Microsoft.VisualBasic;
using System;

namespace ITVDN_Lessons_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 MyC = new Class1();
            MyC.Name = "Toha";
            MyC.MyConsole(MyC.Name);
            Console.WriteLine("Hello World!!");
        }
    }
}
