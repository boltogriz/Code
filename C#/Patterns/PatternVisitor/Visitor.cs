using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternVisitor
{
    public abstract class Visitor
    {
        public abstract void VisitElementA(ElementA concreteElementA);
        public abstract void VisiteElementB(ElementB concreteElementB);
    }
}