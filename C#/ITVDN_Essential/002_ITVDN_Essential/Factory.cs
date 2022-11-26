using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_ITVDN_Essential
{
    class Product
    {
        public Product()
        {
            Console.WriteLine("Создание экземпляра класса Product");
        }
    }
    class Factory
    {
        public Product FactoryMethod()
        {
            return new Product();
        }
    }
}
