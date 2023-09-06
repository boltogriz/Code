using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public abstract class Builder
    {
        public abstract void BuildBasement();

        public abstract void BuildRoof();

        public abstract void BuildStorey();

        public abstract House GetResult();
    }
}