﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternMediator
{
    public class ConcreteMediator : Mediator
    {
        public ConcreteColleague1 Colleague1 { get; set; }

        public ConcreteColleague2 Colleague2 { get; set; }

        public override void Send(string message, Colleague colleague)
        {
            if (Colleague1 == colleague)
                Colleague2.Notify(message);
            else
                Colleague1.Notify(message);
        }
    }
}