using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Constrain
{
    internal class Program
    {
        class Base { }
        class Derived : Base { }
        class MyClass3<T> where T : Base { }
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
            MyClass3<Derived> instance3 = new MyClass3<Derived>();
            Console.WriteLine(new string('-', 20));
            
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add((object)2);
            int i1 = (int)arrayList[0];
            for (int i =0; i < arrayList.Count; i++) 
            {
                Console.WriteLine((int)arrayList[i]);
            }
            List<int> list = new List<int>();
            list.Add(3);
            list.Add(4);

            Console.ReadKey();
        }
    }
}
