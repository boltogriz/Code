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
                decimal discountPersentage;
                {
                    bool discount20PctAvailabe, discoun50PctAvailable;
                    {
                        const decimal MIN_TILE_QTY_FOR_DISCOUNT_20_PCT = 500,
                                      MIN_TILE_QTY_FOR_DISCOUNT_50_PCT = 1000;// м.кв.
                        discount20PctAvailabe = quotiti >= MIN_TILE_QTY_FOR_DISCOUNT_20_PCT &&
                                                quotiti < MIN_TILE_QTY_FOR_DISCOUNT_50_PCT;
                        discoun50PctAvailable = quotiti >= MIN_TILE_QTY_FOR_DISCOUNT_50_PCT;
                    }
                    if (discount20PctAvailabe)
                    {
                        discountPersentage = 20; // %
                    }
                    else
                    {
                        if (discoun50PctAvailable)
                        {
                            discountPersentage = 50;
                        }
                        else
                        {
                            discountPersentage = 0;
                        }
                    }
                }
                discount = cost / 100 * discountPersentage;
            }
            decimal paymentAmount = cost - discount;
            Console.WriteLine($"Общая стоимость: {cost} руб.");
            Console.WriteLine($"Скидка         : {discount} руб.");
            Console.WriteLine($"Сумма к оплате : {paymentAmount} руб.");
            Console.ReadKey();
        }
    }
}
