using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Boxing
{
    internal class Program
    {
        public interface IAnimal
        {
            void Method();
        }
        public struct Dog : IAnimal
        {
            public void Method()
            {
                Console.WriteLine("Voice");
            }
        }
        struct MyStruct
        {
            public void Method()
            {
                Console.WriteLine("Method");
            }
        }
        static void Main(string[] args)
        {
            short a = 25;
            object o = a;
            short b = (short)o;
            MyStruct my = new MyStruct();
            ValueType boxed = my;
            MyStruct unBoxed = (MyStruct)boxed;
            Dog[] dogs = { new Dog(), new Dog(), new Dog() };
            IAnimal animal = (IAnimal)dogs[0];
            object @object = dogs;
            Console.ReadKey();
            

        }
    }
}
