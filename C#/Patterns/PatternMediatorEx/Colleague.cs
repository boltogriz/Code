using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternMediatorEx
{
    public abstract class Colleague
    {
        public Mediator Mediator
        {
            get;
            set;
        }
        public Colleague(Mediator mediator) 
        { 
            this.Mediator = mediator;
        }
    }
}