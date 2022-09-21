using System;

namespace Lesson_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte apples = 16;
            byte pears = 16;

            byte fruits = (byte)(apples + pears);

            Console.WriteLine(fruits);
            Console.ReadKey();
        }
    }
}
