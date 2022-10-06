using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint quotiti, price;
            {
                Console.Write("Количество плитки: ");
                quotiti = Convert.ToUInt32(Console.ReadLine());
                Console.Write("Цена за 1 м.кв. плитки: ");
                price = Convert.ToUInt32(Console.ReadLine());
            }
            decimal cost = quotiti * price;
            decimal discount;
            bool discountAvailable = quotiti >= 100;
            if (discountAvailable)
            {
                const decimal DISCOUNT_PERSENTAGE = 10;
                discount = cost / 100 * DISCOUNT_PERSENTAGE;
            }
            else
            {
                discount = 0;
            }
            decimal paymentAmount = cost - discount;
            Console.WriteLine($"Общая стоимость: {cost} руб.");
            Console.WriteLine($"Скидка         : {discount} руб.");
            Console.WriteLine($"Сумма к оплате : {paymentAmount} руб.");
            Console.ReadKey();
        }
    }
}
