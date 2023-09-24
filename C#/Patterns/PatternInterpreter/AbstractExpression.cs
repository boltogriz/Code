using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternInterpreter
{
    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
}