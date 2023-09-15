using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBridge
{
    internal class Program
    {
        public static Abstraction abstraction
        {
            get;
            set;
        }

        static void Main(string[] args)
        {
            abstraction = new RefinedAbstration(new ConcreteImplementorA());
            abstraction.Operation();

            abstraction = new RefinedAbstration(new ConcreteImplementorB());
            abstraction.Operation();

            Console.ReadKey();
        }
    }
}
