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
            decimal quotiti, price;
            {
                Console.Write("Количество плитки: ");
                string stringQuontiti = Console.ReadLine();
                quotiti = Convert.ToUInt32(stringQuontiti);
                
                Console.Write("Цена за 1 м.кв. плитки: ");
                string stringPrice = Console.ReadLine();
                price = Convert.ToUInt32(stringPrice);
            }
            decimal cost = quotiti * price;
            decimal discount; // руб
            {
                const decimal MIN_QUANTITY_FOR_DISCOUNT = 100; // м.кв.
                bool discountAvailable = quotiti >= MIN_QUANTITY_FOR_DISCOUNT;
                if (discountAvailable)
                {
                    const decimal DISCOUNT_PERSENTAGE = 10;
                    discount = cost / 100 * DISCOUNT_PERSENTAGE;
                }
                else
                {
                    discount = 0;
                }
            }
            decimal paymentAmount = cost - discount;
            Console.WriteLine($"Общая стоимость: {cost} руб.");
            Console.WriteLine($"Скидка         : {discount} руб.");
            Console.WriteLine($"Сумма к оплате : {paymentAmount} руб.");
            Console.ReadKey();
        }
    }
}
