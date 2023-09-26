using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternMediatorEx
{
    public class Cannery : Colleague
    {
        public Cannery(Mediator mediator) : base(mediator)
        {
        }
        public void MakeKetchup(string message)
        {
            string ketchup = message + "Ketchup";
            Console.WriteLine(this.GetType().Name + "  produce " + ketchup);

            Mediator.Send(ketchup, this);
        }
    }
}