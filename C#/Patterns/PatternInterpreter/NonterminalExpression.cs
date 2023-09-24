using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternInterpreter
{
    public class NonterminalExpression : AbstractExpression
    {
        AbstractExpression nonterminalExpression;
        AbstractExpression terminalExpression;
        public override void Interpret(Context context)
        {
            if( context.Position < context.Source.Length ) 
            {
                terminalExpression = new TerminalExpression();
                terminalExpression.Interpret( context );
                context.Position++;
                if (context.Result)
                {
                    nonterminalExpression = new NonterminalExpression();
                    nonterminalExpression.Interpret( context );
                }
            }
        }
    }
}