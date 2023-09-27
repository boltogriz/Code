using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternMemento
{
    public class Memento
    {
        public string State
        { get; private set; }

        public Memento(string state) 
        { 
            this.State = state;
        }
    }
}