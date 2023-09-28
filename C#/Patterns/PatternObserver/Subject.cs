using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternObserver
{
    public abstract class Subject
    {
        protected Observer observers = null;
        public event Observer Event
        {
            add { observers += value; }
            remove { observers -= value; }
        }
        public abstract string State { get; set; }
        public abstract void Notify();
    }
}