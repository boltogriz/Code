using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    public class ConcreteHandler2 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request == 2)
            {
                Console.WriteLine("Two");
            }
            else if (Successor != null)
            {
                Successor.HandlerRequest(request);

            }
        }
    }
}