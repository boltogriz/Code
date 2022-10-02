using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_Scope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                float t = 22.5f;
                int x = 5;
                Console.WriteLine($"temperature={t}");
                Console.WriteLine(x);
                Console.WriteLine(y);
            }
            int y = 10;
            {
                float t = 11.35f;
                Console.WriteLine($"time={t}");
                Console.WriteLine(x);
                Console.WriteLine(y);
            }
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
