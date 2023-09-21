using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDecorator
{
    public class ConcreteDecoratorA : Decorator
    {
        string addedState = "Some State";
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine(addedState);
        }
    }
}