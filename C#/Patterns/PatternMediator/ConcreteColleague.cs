using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternMediator
{
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator)
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