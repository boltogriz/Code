using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            Product product = factory.FactoryMethod();
            Product product2 = factory.FactoryMethod();
            Product product3 = factory.FactoryMethod();
            Product product4 = factory.FactoryMethod();

            product.Plus();
            product.Show();
            product2.Show();

            Console.ReadKey();
        }
    }
}
