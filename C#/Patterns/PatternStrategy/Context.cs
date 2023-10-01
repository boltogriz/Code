using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternStrategy
{
    public class Context
    {
        public Strategy Strategy
        {
            get;
            set;
        }
        public Context(Strategy strategy)
        { this.Strategy = strategy; }

        public void ContextInterface()
        {
            Strategy.AlgorithmInterface();
        }
    }
}