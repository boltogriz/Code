using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDecorator
{
    public class ConcreteComponent1 : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent");
        }
    }
}