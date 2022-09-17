using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class SystemCount
    {
        public string SysCountEnter { get; set; }
        public string SysCountWithdow { get; set; }
        public void ChengSysCount()
        {
            Console.WriteLine("Введите систему счисления ввода: ");
            SysCountEnter = Console.ReadLine();
            Console.WriteLine("Введите систему счисления вывода: ");
            SysCountWithdow = Console.ReadLine();
            Console.WriteLine("\n");
        }



    }
}
