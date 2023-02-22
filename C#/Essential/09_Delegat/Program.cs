using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Delegat
{
    internal class Program
    {
        public delegate void MyDelegateProgram();
        public static void Method1()
        {
            Console.WriteLine("Method1");
        }
        public static void Method2()
        {
            Console.WriteLine("Method2");
        }
        public static void Method3()
        {
            Console.WriteLine("Method3");
        }
        public static void Method4()
        {
            Console.WriteLine("Method4");
        }
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
        class MyClass3
        {
            public string Method(string name)
            {
                return name + " MyClass3";
            }
        }
        public delegate void MyDelegate();
        public delegate string MyDelegate2(string name);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(MyClass.Method);
            myDelegate.Invoke();
            myDelegate();
            MyClass2 myClass2 = new MyClass2();
            MyDelegate myDelegate2 = new MyDelegate(myClass2.Method);
            myDelegate2.Invoke();
            myDelegate2();

            MyClass3 myClass3 = new MyClass3();
            MyDelegate2 myDelegate3 = new MyDelegate2(myClass3.Method);
            string d3 = myDelegate3.Invoke("myDelegate30000");
            string d4 = myDelegate3("myDelegate40000");
            Console.WriteLine(d4);

            Console.WriteLine(new string('-', 20));
            MyDelegateProgram myDelegateProgram = null;
            MyDelegateProgram myDelegateProgram1 = new MyDelegateProgram(Method1);
            MyDelegateProgram myDelegateProgram2 = new MyDelegateProgram(Method2);
            MyDelegateProgram myDelegateProgram3 = new MyDelegateProgram(Method3);
            myDelegateProgram = myDelegateProgram1 + myDelegateProgram2 + myDelegateProgram3;
            Console.WriteLine("enter 1 to 7");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    {
                        myDelegateProgram1.Invoke();
                        break;
                    }
                case "2":
                    {
                        myDelegateProgram2.Invoke();
                        break;
                    }
                case "3":
                    {
                        myDelegateProgram3.Invoke();
                        break;
                    }
                case "4":
                    {
                        MyDelegateProgram myDelegateProgram4 = myDelegateProgram - myDelegateProgram1;
                        myDelegateProgram4.Invoke();
                        break;
                    }
                default:
                    break;
            }

            // задержка
            Console.ReadKey();
        }
    }
}
