using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_Join
{
    internal class Program
    {
        static void Method1()
        {
            Console.WriteLine("Третичный поток # {0}", Thread.CurrentThread.GetHashCode());
            WriteChar('3', 80, ConsoleColor.Red);
        }

        private static void WriteChar(char chr, int count, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < count; i++)
            {
                Thread.Sleep(20);
                Console.Write(chr);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} поток завершился", chr);
        }

        static void Function()
        {
            Console.WriteLine("ID Вторичного потока: {0}", Thread.CurrentThread.ManagedThreadId);
            Console.ForegroundColor = ConsoleColor.Yellow;
            for(int i =0; i < 160; i++)
            {
                Thread.Sleep(20);
                Console.Write(".");
            }
            Console.ForegroundColor= ConsoleColor.Gray;
            Console.WriteLine("Вторичный поток завершился");
            Thread thread = new Thread(new ThreadStart(Method1));
            thread.Start();
            thread.Join();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ID Первичного потока: {0}", Thread.CurrentThread.ManagedThreadId);
            Thread thread = new Thread(new ThreadStart(Function));
            thread.Start();

            thread.Join();

            Console.ForegroundColor = ConsoleColor.Green;

            for( int i = 0; i < 160; i++) 
            {
                Thread.Sleep(20);
                Console.Write("-");
            }
            Console.ForegroundColor= ConsoleColor.Gray;
            Console.WriteLine("\nПервичный поток завершился");

            Console.ReadLine();

        }
    }
}
