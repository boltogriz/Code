using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternVisitor
{
    public class ConcreteVisitor2 : Visitor
    {
        public override void VisiteElementB(ElementB elementB)
        {
            elementB.OperationB();
        }

        public override void VisitElementA(ElementA elementA)
        {
            elementA.OperationA();
        }
    }
}