using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Component component = new ConcreteComponent1();
            Decorator decoratorA = new ConcreteDecoratorA();
            Decorator decoratorB = new ConcreteDecoratorB();
            Decorator decoratorC = new ConcreteDocoratorC();

            decoratorA.Component = component;
            decoratorB.Component = decoratorA;
            decoratorC.Component = decoratorB;
            decoratorC.Operation();

            Console.ReadKey();
        }
    }
}
