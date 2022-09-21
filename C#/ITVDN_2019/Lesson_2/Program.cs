using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float T_m = 3, T_tu = -1;
            int daysInWeek = 7;
            float T_avg = (T_m + T_tu) / daysInWeek;

            Console.WriteLine(T_avg);
            Console.ReadKey();
        }
    }
}
