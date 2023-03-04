using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Constrain
{
    internal class Program
    {
        class MyClass1<T> where T : class
        {
            public T vaiable;
        }
        class MyClass2<T> where T : new()
        {
            public T instance = new T();
            public void GetStr()
            {
                Console.WriteLine(instance.ToString());
            }
        }
        class TestClass
        {
            public string MyStr { get; set; }
            public override string ToString()
            {
                return MyStr;
            }
        }
        static void Main(string[] args)
        {
            MyClass1<string> instance0 = new MyClass1<string>();
            MyClass2<TestClass> instance1 = new MyClass2<TestClass>();
            instance1.instance.MyStr = "TestClass in MyClass1";
            instance1.GetStr();
            Console.ReadKey();
        }
    }
}
