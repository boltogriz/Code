using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternBridge
{
    public class ConcreteImplementorB : Implementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("ImplementorB");
        }
    }
}