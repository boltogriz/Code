using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternState
{
    public class Context
    {
        public State State { get; set; }

        public Context(State state)
        {
            this.State = state;
        }

        public void Request()
        {
            State.Handle(this);
        }
    }
}