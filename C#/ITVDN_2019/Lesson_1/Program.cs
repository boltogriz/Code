using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
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
