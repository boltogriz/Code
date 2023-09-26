using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternMediator
{
    public abstract class Colleague
    {
        internal Mediator mediator;

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}