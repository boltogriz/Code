using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternMediatorEx
{
    public class Farmer : Colleague
    {
        public Farmer(Mediator mediator) : base(mediator)
        {
        }
        public void GrowTomato()
        {
            string tomato = "Tomato";
            Console.WriteLine(this.GetType().Name + " raised " +tomato);

            Mediator.Send(tomato, this);
        }
    }
}