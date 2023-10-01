using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternStrategy
{
    public class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("ConcreteStrategyC");
        }
    }
}