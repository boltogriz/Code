using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternMediator
{
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {
        }

        internal void Notify(string message)
        {
            Console.WriteLine(message);
        }
        public void Send(string message)
        {
            mediator.Send(message, this);
        }
    }
}