using System;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double t = -28.5d;
            float pi = 3.14F;
            float c = -28F;
            int apple = 5;
            int pear = 3;
            bool log = true;
            int pineapple = 6, wildberries = 10;
            int SummFruit = apple + pear + pineapple + wildberries;
            byte bnumber = 255;
            Console.WriteLine("Temper: " + t);
            Console.WriteLine("C: " + c);
            Console.WriteLine("Fruits: " + SummFruit);
            SummFruit = sizeof(byte);
            Console.WriteLine("Sizeof byte: " + SummFruit);
            Console.WriteLine("byte: " + bnumber);
            t = (byte)t;
            Console.WriteLine("t: " + t);
            bnumber = (byte)t;
            Console.WriteLine("byte: " + bnumber);
            Console.WriteLine("bool: " + log);
            Console.WriteLine("pi: " + pi);
        }
    }
}
