using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternBridge
{
    public class ConcreteImplementorA : Implementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("ImplementorA");
        }
    }
}