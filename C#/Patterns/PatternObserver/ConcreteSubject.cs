using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternObserver
{
    public class ConcreteSubject : Subject
    {
        public override string State { get; set; }

        public override void Notify()
        {
            observers.Invoke(State);
        }
    }
}