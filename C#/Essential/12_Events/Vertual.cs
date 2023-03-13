using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Events
{
    public delegate void EventDelegateVertual();
    interface IInterface
    {
        event EventDelegateVertual MyEvent;
    }
    public class BaseClase : IInterface
    {
        EventDelegateVertual myEvent = null;
        public virtual event EventDelegateVertual MyEvent
        { 
            add { myEvent += value; }
            remove { myEvent -= value; }
        }
        public void InvokeEvent()
        {
            myEvent.Invoke();
        }
    }
    public class DerivedClass : BaseClase
    {
        public override event EventDelegateVertual MyEvent
        {
            add 
            {
                base.MyEvent += value;
                Console.WriteLine("К событию базового класса был прикреплен обработчик - {0}", value.Method.Name);
            }
            remove 
            {
                base.MyEvent -= value;
                Console.WriteLine("Отвязали от базового класса был прикреплен обработчик - {0}", value.Method.Name);
            }
        }
    }
}
