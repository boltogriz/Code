using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _12_Events.Form1Event;

namespace _12_Events
{
    public delegate void EventDelegate();
    public delegate void EvetDelegateSeeMs();
    public delegate void EvetDelegateObject();
    public delegate void EvetDelegateObject2();
    public class MyClass
    {
        public event EventDelegate MyEvent = null;
        public event EvetDelegateSeeMs SeeMs = null;
        public event EvetDelegateObject EventObject = null;
        EvetDelegateObject2 eventObject2 = null;
        public event EvetDelegateObject2 EventObject2
        {
            add { eventObject2 += value; }
            remove { eventObject2 -= value; }
        }
        public void InvokeEvent()
        {
            MyEvent.Invoke();
        }
        public void InvokeEvent2()
        {
            eventObject2.Invoke();
            Console.WriteLine("Event2");
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
        static private void ColorDefault()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static private void PressKeyA_Handler()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("     ");
            Console.WriteLine("   *   ");
            Console.WriteLine("  * *  ");
            Console.WriteLine(" ***** ");
            Console.WriteLine("*     *");
            Console.WriteLine();
            ColorDefault();
        }
        static private void PressKeyB_Handler()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("     ");
            Console.WriteLine(" ****  ");
            Console.WriteLine(" *    *");
            Console.WriteLine(" ******");
            Console.WriteLine(" *    *");
            Console.WriteLine(" ***** ");
            Console.WriteLine();
            ColorDefault();
        }
        static private void PressKeyC_Handler()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("     ");
            Console.WriteLine(" ****  ");
            Console.WriteLine(" *     ");
            Console.WriteLine(" *     ");
            Console.WriteLine(" ****  ");
            Console.WriteLine();
            ColorDefault();
        }
        static private void HandlerForEventA()
        {
            Console.WriteLine("Обработал событие А");
        }
        static void Main(string[] args)
        {
            Form1Event.Timer timer = new Form1Event.Timer();
            
            Form1 form = new Form1();
            Application.Run(timer);
            Application.Run(form);
            MyClass instance = new MyClass();
            instance.MyEvent += new EventDelegate(Handler1);
            instance.MyEvent += Handler2;
            instance.InvokeEvent();

            Console.WriteLine(new String('-', 20));

            instance.MyEvent -= new EventDelegate(Handler1);
            instance.EventObject2 += new EvetDelegateObject2(Handler1);
            instance.InvokeEvent();
            instance.InvokeEvent2();

            Console.WriteLine(new String('-', 20));

            instance.SeeMs += HandlerSee;
            EventSeeMs(in instance);

            Console.WriteLine(new String('-', 20));

            instance.EventObject += HandlerObject;
            MyClassEvent myClassEvent = new MyClassEvent();
            myClassEvent.Show(instance);

            Console.WriteLine(new String('-', 20));

            Key key = new Key();
            key.PressKeyA += PressKeyA_Handler;
            key.PressKeyB += PressKeyB_Handler;
            key.PressKeyC += PressKeyC_Handler;
            key.Start();

            Console.WriteLine(new String('-', 20));

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.MyEvent += Handler1;
            derivedClass.MyEvent += Handler1;
            derivedClass.MyEvent += Handler1;
            derivedClass.MyEvent += Handler1;
            derivedClass.MyEvent -= Handler1;
            derivedClass.InvokeEvent();

            Console.WriteLine(new String('-', 20));

            EventA eventA = new EventA();
            eventA.delegateEventA += HandlerForEventA;
            eventA.DelegateEventB += HandlerForEventA;
            eventA.InvokeEvent();
            eventA.InvokeEventB();

            Console.ReadKey();

        }
    }
}
