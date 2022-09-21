using System;

namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nober;
            string Comand = "start";
            SystemCount sys_count = new SystemCount();
            sys_count.ChengSysCount(); //вводит ситему счиление ввода и вывода, создает свойства которые потом используются
            while (Comand != "exit")
            {
                Console.WriteLine("Введите " + sys_count.SysCountEnter + " чило:");
                Comand = Console.ReadLine();
                if (Comand == "reset")
                {
                    sys_count.ChengSysCount(); 
                    continue;
                }
                if (Comand == "exit") break;
                try 
                {
                    Nober = Convert.ToInt32(Comand, Convert.ToInt32(sys_count.SysCountEnter));
                    Console.WriteLine(Convert.ToString(Nober, Convert.ToInt32(sys_count.SysCountWithdow)) + " - система счисления " + sys_count.SysCountWithdow + "\n");
                }
                catch { Console.WriteLine("Ошибка ввода\n"); }
            }
        }
    }
}
