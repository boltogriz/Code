using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Events
{
    public delegate void EventDelegate();
    public delegate void EvetDelegateSeeMs();
    public delegate void EvetDelegateObject();
    public class MyClass
    {
        public event EventDelegate MyEvent = null;
        public event EvetDelegateSeeMs SeeMs = null;
        public event EvetDelegateObject EventObject = null;
        public void InvokeEvent()
        {
            MyEvent.Invoke();
        }
        public void InvokeEventSee()
        {
            SeeMs();
        }        
        public void InvokeEventObject(object instance)
        {
            if (instance.GetType().ToString() == "_12_Events.MyClassEvent")
                EventObject();
        }
    }
    public class MyClassEvent
    {
        public void Show(MyClass instance)
        {
            Console.WriteLine("Событие из объекта");
            instance.InvokeEventObject(this);
        }
    }
    internal class Program
    {
        static private void EventSeeMs(in MyClass instance)
        {
            Console.WriteLine("Событие Увидел Тетю");
            instance.InvokeEventSee();
        }
        static private void Handler1()
        {
            Console.WriteLine("Обработчик события 1");
        }
        static private void Handler2()
        {
            Console.WriteLine("Обработчик события 2");
        }
        static private void HandlerSee()
        {
            Console.WriteLine("Привет, тетя");
        }        
        static private void HandlerObject()
        {
            Console.WriteLine("Привет, объект");
        }
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.MyEvent += new EventDelegate(Handler1);
            instance.MyEvent += Handler2;
            instance.InvokeEvent();

            Console.WriteLine(new String('-', 20));

            instance.MyEvent -= new EventDelegate(Handler1);
            instance.InvokeEvent();



            Console.WriteLine(new String('-', 20));

            instance.SeeMs += HandlerSee;
            EventSeeMs(in instance);

            Console.WriteLine(new String('-', 20));

            instance.EventObject += HandlerObject;
            MyClassEvent myClassEvent = new MyClassEvent();
            myClassEvent.Show(instance);

            Console.ReadKey();
        }
    }
}
