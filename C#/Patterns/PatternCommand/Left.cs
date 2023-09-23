using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternCommand
{
    public class Left : Command
    {
        int preOperant;
        public Left(ArithmeticUnit unit, int operand)
        {
            this.unit = unit;
            preOperant = this.operand;
            this.operand = operand;
        }

        public override void Execute()
        {
            unit.Run('%', operand);
        }

        public override void UnExecute()
        {
            unit.Run('o', operand);
        }
    }
}