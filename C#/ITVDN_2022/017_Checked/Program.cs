using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Checked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint minutesQuarter;
            {
                Console.Write("Введите количетство минут разговоров за январь: ");
                uint minutesJanuary = Convert.ToUInt32(Console.ReadLine());
                Console.Write("Введите количетство минут разговоров за февраль: ");
                uint minutesFebruary = Convert.ToUInt32(Console.ReadLine());
                Console.Write("Введите количетство минут разговоров за март: ");
                uint minutesMarch = Convert.ToUInt32(Console.ReadLine());

                checked
                {
                    minutesQuarter = minutesFebruary + minutesJanuary + minutesMarch;
                }
            }
            decimal totalCost; // руб.
            {
                decimal price = 2; // руб.
                totalCost = minutesQuarter * price;
            }

            decimal tax;
            {
                decimal taxRate = 20; // %
                tax = totalCost / 100 * taxRate;
            }

            Console.WriteLine($"Всего               : {minutesQuarter} минут");
            Console.WriteLine($"Стоимость всех минут: {totalCost} рублей") ;
            Console.WriteLine($"Заплатить налог     : {tax} рублей");

            Console.ReadKey();
        }
    }
}
