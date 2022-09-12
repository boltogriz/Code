using System;

namespace Color
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Title = "Console";
            Console.WriteLine("Hello world!");
            Console.Write("Hello friends!\n");
            Console.ResetColor();
            Console.Write("Goodbye!");
            Console.ReadKey();
        }
    }
}
