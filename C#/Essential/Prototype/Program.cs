 using Prototype.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype1 p1 = new ConcretePrototype1("1");
            ConcretePrototype1 c1 = p1.Clone() as ConcretePrototype1;
            Console.WriteLine("Cloned: {0}", c1.Id);

            ConcretePrototype2 p2 = new ConcretePrototype2("2");
            ConcretePrototype2 c2 = p2.Clone() as ConcretePrototype2;
            Console.WriteLine("Cloned: {0}", c2.Id);

            Console.ReadKey();
        }
    }
}
