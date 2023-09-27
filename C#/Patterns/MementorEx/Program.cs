using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementorEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Man David = new Man();
            Robot ASIMO = new Robot();

            David.Clothes = "Футболка, Джинсы, Кеды";
            ASIMO.Backpack = David.Undress();
            David.Clothes = "Шорты спортивные";
            David.Dress(ASIMO.Backpack);

            Console.ReadKey();
        }
    }
}
