using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float T_mo = 3.5F, T_tu = 3.5F;
            int daysInWeek = 7;

            float T_sum = T_mo + T_tu;

            float T_avg = T_sum / daysInWeek;

            Console.WriteLine(T_avg);
            Console.ReadKey();
        }
    }
}
