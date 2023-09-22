using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDecorator
{
    public class ConcreteDocoratorC : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorC");
        }
    }
}