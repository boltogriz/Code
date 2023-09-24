using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternInterpreter
{
    public class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            context.Result = context.Source[context.Position] == context.Vocabulary;
        }
    }
}