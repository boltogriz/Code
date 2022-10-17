using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_Distribution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "январь", "февраль", "март" };
            string[] tiles = { "Агат", "Оникс", "Малахит" };
            string[] distributors = { "Мир керамики", "Дом плитки" };
            decimal[,,] array = new decimal[ distributors.Length, tiles.Length, months.Length];
            for (int z = 0; z < array.GetLength(0); z++)
                for (int y = 0; y < array.GetLength(1); y++)
                    for (int x = 0; x < array.GetLength(2); x++)
                    {
                        Console.Write($"{distributors[z]} продала плитки {tiles[y]} за {months[x]}: ");
                        array[z, y, x] = Convert.ToDecimal(Console.ReadLine());
                    }
            while (true)
            {
                string distributorName;
                int distributorIdex;
                do
                {
                    Console.Write("Введите название дистрибьютора: ");
                    distributorName = Console.ReadLine();
                    distributorIdex = Array.IndexOf(distributors, distributorName);
                    if (distributorIdex == -1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введено неверное название компании, попробуйте снова");
                        Console.ResetColor();
                    }
                } while (distributorIdex == -1);
                string tileName;
                int tailIndex;
                do
                {
                    Console.Write("Введите название дистрибьютора: ");
                    tileName = Console.ReadLine();
                    tailIndex = Array.IndexOf(tiles, tileName);
                    if (tailIndex == -1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введено неверное название плитки, попробуйте снова");
                        Console.ResetColor();
                    }
                } while (tailIndex == -1);
                decimal numberOfTiles = 0;
                for (int x = 0; x < array.GetLength(2); x++)
                    numberOfTiles += array[distributorIdex, tailIndex, x];
                Console.WriteLine($"{distributorName} продал {numberOfTiles} шт. плитки {tileName} за квартал.");
            }
            //Console.ReadKey();
        }
    }
}
