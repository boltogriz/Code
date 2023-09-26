using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternMediatorEx
{
    public class ConcreteMediator : Mediator
    {
        public Farmer Farmer
        {
            get;
            set;
        }

        public Cannery Cannery
        {
            get;
            set;
        }

        public Shope Shope
        {
            get;
            set;
        }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == Farmer) 
            {
                Cannery.MakeKetchup(message);
            }
            else if (colleague == Cannery) 
            { 
                Shope.SellKetchup(message);
            }
        }
    }
}