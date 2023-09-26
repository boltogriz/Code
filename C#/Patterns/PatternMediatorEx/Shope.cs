using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternMediatorEx
{
    public class Shope : Colleague
    {
        public Shope(Mediator mediator) : base(mediator)
        {
        }

        public void SellKetchup(string message)
        {
            Console.WriteLine(this.GetType().Name + " sold " + message);
        }
    }
}