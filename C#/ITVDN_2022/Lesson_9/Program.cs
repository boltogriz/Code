using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Hellow world!");

            Console.ForegroundColor++;
            Console.WriteLine("Hellow world!");
            Console.WriteLine(-0d / +0d);
            Console.WriteLine(double.NegativeInfinity / double.PositiveInfinity);
            Console.WriteLine(2 + double.NaN);
            Console.WriteLine(Math.Pow(6, 2));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Log(36, 6));
            Console.WriteLine(Math.Sqrt(-36));
            int a = 2, b = a++ * 5 + a;
            Console.WriteLine($"a = {a}, b = {b}");
            Console.ReadLine();//wait
        }
    }
}
