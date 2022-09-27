using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_LogicalOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isTrue;
            double x = double.NaN, y = double.NaN;

            isTrue = x == y;
            Console.WriteLine($"{x} == {y}: {isTrue}");

            isTrue = x != y;
            Console.WriteLine($"{x} != {y}: {isTrue}");

            // Delay
            Console.ReadKey();
        }
    }
}
