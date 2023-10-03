using System;

namespace PatternVisitor
{
    public class ElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitElementA(this);
        }
        public void OperationA()
        {
            Console.WriteLine("OperationA");
        }
    }
}