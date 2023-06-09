using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern_Builder
{
    public abstract class Builder
    {
        public abstract void BuildPartA();

        public abstract void BuildPartB();

        public abstract void BuildPartC();

        public abstract Product GetResult();
    }
}