using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_Unchecked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int a = int.MaxValue;
                int b = a + 1;
                Console.WriteLine(b);

                unchecked
                {
                    int c = int.MaxValue;
                    int d = c + 1;
                    Console.WriteLine(d);
                }
                int e = int.MinValue;
                int f = e - 1;
                Console.WriteLine(f);
            }
            int x = int.MinValue;
            int y = checked(x + 1);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
