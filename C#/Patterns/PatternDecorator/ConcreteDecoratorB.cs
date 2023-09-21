using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PatternDecorator
{
    public class ConcreteDecoratorB : Decorator
    {
        void addedBehavior()
        {
            Console.WriteLine("Behavior");
        }
        public override void Operation()
        {
            base.Operation();
            addedBehavior();
        }
    }
}