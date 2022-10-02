using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Variable
{
    static class Program
    {
        static void Main(string[] args)
        {
            dynamic variable = 2;
            variable = "Hellow";
            Console.WriteLine(variable);

            var variable2 = "Hellow world!";
            Console.WriteLine(variable2);

            int l = 6, w = 5, a = l * w;
            Console.WriteLine($"Room area = {a}");

            int roomLength = 4;
            int roomWidth = 3;
            int roomArea = roomLength * roomWidth;
            Console.WriteLine($"Kitchen area = {roomArea}");

            MyCal Cal = new MyCal();
            int y = sum(20, 30);
            Console.WriteLine(Cal.Sum(2, 3));
            Console.WriteLine(y);
            Console.ReadKey();
        }
        public static int sum(int x, int y)
        {
            return x + y;
        }
    }
}
