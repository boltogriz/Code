using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternStrategy
{
    public class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("ConcreteStrategyB");
        }
    }
}