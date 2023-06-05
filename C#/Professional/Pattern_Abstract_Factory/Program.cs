using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Abstract_Factory
{
    static class Program
    {
        public static void ToShow(this AbstractProduct str)
        {
            Console.WriteLine(str.ToString());
        }

        static void Main(string[] args)
        {
            AbstractFactory factory = new ConcreteFactory();
            AbstractProduct product = factory.CreatProduct();
            product.Operation();
            product.ToShow();

            Console.ReadKey();
        }
    }
}
