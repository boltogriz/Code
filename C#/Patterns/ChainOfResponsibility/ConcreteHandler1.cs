using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    public class ConcreteHandler1 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request == 1) 
            {
                Console.WriteLine("One");
            }
            else if (Successor != null) 
            { 
                Successor.HandlerRequest(request);
            }
        }
    }
}