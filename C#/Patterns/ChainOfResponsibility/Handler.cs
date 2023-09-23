using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        public Handler Successor { get; set; }

        public abstract void HandlerRequest(int request);
        public void SetSuccessor(Handler successor)
        { 
            this.Successor = successor; 
        }
    }
}