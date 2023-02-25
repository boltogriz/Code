using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _09_Delegat
{
    public delegate Delegate21 Delegate11();
    public delegate void Delegate21();

    public delegate Delegate3a Functional(Delegate1a delegate1a, Delegate2a delegate2);
    public delegate string Delegate1a();
    public delegate string Delegate2a();
    public delegate string Delegate3a();
    public delegate void MyDelegate14(int argument);
    internal class Program
    {
        public static Delegate3a MethodF(Delegate1a delegate1a, Delegate2a delegate2a)
        {
            return delegate { return delegate1a.Invoke() + delegate2a.Invoke(); };
        }
        public static string Method1a() { return "Hello";  }
        public static string Method2a() { return "world"; }
        public delegate void MyDelegateProgram();
        public delegate int MyDelegateProgram2(int a, int b );
        
        public static Delegate21 Method11()
        {
            return new Delegate21(Method21);
        }
        public static void Method21()
        {
            Console.WriteLine("Hello");
        }
        static int Factorial (int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }

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
        public static string Method5(string name)
        {
            return name + " 5";
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
        public delegate void MyDelegate3(ref int a, ref int b, out int c);
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
                case "5":
                    {
                        MyDelegateProgram myDelegateProgram5 = myDelegateProgram - myDelegateProgram2;
                        myDelegateProgram5.Invoke();
                        break;
                    }
                case "6":
                    {
                        myDelegateProgram.Invoke();
                        break;
                    }
                case "7":
                    {
                        MyDelegateProgram myDelegateProgram7 = delegate { Console.WriteLine("Hellow world!"); };
                        myDelegateProgram7.Invoke();
                        break;
                    }
                case "8":
                    {
                        int x = 1, y = 2, sum = 0;
                        MyDelegateProgram2 myDelegateProgram8 = delegate (int a, int b) { return a + b; };
                        sum = myDelegateProgram8(x, y);
                        Console.WriteLine("{0} + {1} = {2}", x, y, sum);
                        break;
                    }
                case "9":
                    {
                        int sum1 = 1, sum2 = 2, sum;
                        MyDelegate3 myDelegate33 = delegate (ref int a, ref int b, out int c) { a++; b++; c = a + b; };
                        myDelegate33(ref sum1, ref sum2, out sum);
                        Console.WriteLine("{0} + {1} = {2}", sum1, sum2, sum);
                        break;
                    }
                case "10":
                    {
                        string text2 = "text";
                        MyDelegate2 myDelegate22 = x => { return x + " text"; };
                        Console.WriteLine(myDelegate22(text2));
                        break;
                    }
                case "11":
                    {
                        string text3 = "method";
                        MyDelegate2 myDelegate2Text = new MyDelegate2(Method5);
                        Console.WriteLine(myDelegate2Text(text3));
                        break;
                    }
                case "12":
                    {
                        Delegate11 myDelegate11 = new Delegate11(Method11);
                        Delegate21 myDelegate21 = myDelegate11();
                        myDelegate21();
                        break;
                    }
                case "13":
                    {
                        //Functional functional = new Functional(MethodF);
                        Functional functional = MethodF;
                        Delegate3a delegate3a = functional.Invoke(new Delegate1a(Method1a), new Delegate2a(Method2a));
                        Console.WriteLine(delegate3a.Invoke());    
                        break;
                    }
                case "14":
                    {
                        MyDelegate14 my14 = null;
                        my14 = (int i) =>
                        {
                            i--;
                            Console.WriteLine("Begin {0} ", i);
                            if (i > 0)
                            {
                                my14(i);
                            }
                            
                            Console.WriteLine("End {0} ", i);
                        };
                        my14(3);
                        break;
                    }
                case "15":
                    {
                        int factorial = Factorial(4);
                        Console.WriteLine(factorial);
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
