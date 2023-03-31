using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneableWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            Point p1 = new Point(1, 1);
            timer.Stop();
            Console.WriteLine(p1 + " Время: " + timer.Elapsed.Ticks);
            timer.Reset();
            timer.Start();
            Point c1 = p1.Clone() as Point;
            timer.Stop();
            Console.WriteLine(c1 + " Время: " + timer.Elapsed.Ticks);

            c1.x = 2;
            c1.y = 3;
            Console.WriteLine(p1);
            Console.WriteLine(c1);

            Console.ReadKey();
        }
    }
}
