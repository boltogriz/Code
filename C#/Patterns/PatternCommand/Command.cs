using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternCommand
{
    public abstract class Command
    {
        protected int operand;
        protected ArithmeticUnit unit;
        public abstract void Execute();
        public abstract void UnExecute();
    }
}