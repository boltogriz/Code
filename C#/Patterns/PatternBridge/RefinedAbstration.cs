using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternBridge
{
    public class RefinedAbstration : Abstraction
    {
        public RefinedAbstration(Implementor imp) : base(imp)
        {
        }

        public new void Operation()
        {
            base.Operation();
        }
    }
}