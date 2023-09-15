using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternBridge
{
    public abstract class Abstraction
    {
        public Implementor implementor
        {
            get;
            set;
        }
        public Abstraction(Implementor imp)
        {
            this.implementor = imp;
        }
        public virtual void Operation()
        {
            implementor.OperationImp();
        }
    }
}