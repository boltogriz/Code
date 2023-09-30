using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternState
{
    public abstract class State
    {
        public abstract void Handle(Context context);
    }
}