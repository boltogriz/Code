using System;

namespace PatternVisitor
{
    public class ElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisiteElementB(this);
        }
        public void OperationB()
        {
            Console.WriteLine("OperationB");
        }
    }
}