using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Delegat
{
    internal class Program
    {
        public class MyClass 
        {
            public static void Method()
            {
                Console.WriteLine("Строку вывел метод сооьщенный с делегатом");
            }
        }
        class MyClass2
        {
            public void Method()
            {
                Console.WriteLine("MyClass2.Method()");
            }
        }
        public delegate void MyDelegate();
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(MyClass.Method);
            myDelegate.Invoke();
            myDelegate();
            MyClass2 myClass2 = new MyClass2();
            MyDelegate myDelegate2 = new MyDelegate(myClass2.Method);
            myDelegate2.Invoke();
            myDelegate2();
            Console.ReadKey();
        }
    }
}
