using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Events
{
    public delegate void DelegateEventA();
    internal class EventA
    {
        public event DelegateEventA delegateEventA = null;
        public void InvokeEvent()
        {
            delegateEventA.Invoke();
        }
        public void InvokeEventB()
        {
            delegateEventB.Invoke();
        }
        DelegateEventA delegateEventB = null;
        public event DelegateEventA DelegateEventB
        {
            add 
            {
                delegateEventB += value;
            }
            remove
            {
                delegateEventB -= value;
            }
        }
    }
}
