using System;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double t = 28.5;
            float c = 28;
            int apple = 5;
            int pear = 3;
            int pineapple = 6, wildberries = 10;
            int SummFruit = apple + pear + pineapple + wildberries;
            Console.WriteLine("Temper: " + t);
            Console.WriteLine("C: " + c);
            Console.WriteLine("Fruits: " + SummFruit);
            SummFruit = sizeof(byte);
            Console.WriteLine("Sizeof byte: " + SummFruit);
        }
    }
}
