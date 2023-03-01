using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Universal_Type
{
    delegate R MyDelegate<T, R>(T t);
     class MyClass<T>
    {
        public T field;
        public void Method()
        {
            Console.WriteLine(field.GetType());
        }
        public T2 Method2<T2>(T2 field)
        {
            T2 filed1 = field;
            Console.WriteLine(filed1.GetType() + " Method2<T2>");
            return filed1;
        }
        public int Method3(int field)
        {
            int filed1 = field;
            Console.WriteLine(filed1.GetType() + " Method3");
            return filed1 + 1;
        }
    }
    internal class Program
    {
        public static Cat CatCreator()
        {
            return new Cat();
        }
        static void Main(string[] args)
        {
            MyClass<int> myClass = new MyClass<int>();
            myClass.Method();
            MyClass<string> myClass1 = new MyClass<string>();
            myClass1.field = "filed";
            myClass1.Method();
            myClass.Method2<int>(32);
            MyClass<int> myClass2 = myClass;
            MyDelegate<int, int> myDelegate = new MyDelegate<int, int>(myClass2.Method3);
            int i = myDelegate(33);
            Console.WriteLine(i);

            Console.WriteLine(new string('-', 20));

            Shape shape = new Circle();
            IContainer<Circle> container = new Container<Shape>(shape);
            Console.WriteLine(container.ToString());

            Console.WriteLine(new string('-', 20));

            IContainer<Shape> o = new Container<Shape>(shape) { ATest1 = 1, ATest2 = 2 };
            if (Halper.HasCustomAttribute(o))
            {
                Console.WriteLine("has custom");
            }
            else
                
            {
                Console.WriteLine("has custom");
            }
            Console.WriteLine(new string('-', 20));

            MyDelegate<Cat> delegateCat = new MyDelegate<Cat>(CatCreator);
            MyDelegate<Animal> delegateAnimal = delegateCat;
            Animal animal = delegateAnimal.Invoke();
            Console.WriteLine(animal.GetType().Name);

            Console.WriteLine(new string('-', 20));

            int? a = null;
            int? b = 5;
            int? c = a * 2;
            //b = a != null ? a : 10;
            b = a ?? 10;
            Console.WriteLine($"a={a} b={b} c={c}");

            Console.ReadKey();
        }
    }
}
