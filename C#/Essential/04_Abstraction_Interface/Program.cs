using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Abstraction_Interface
{
    internal class Program
    {
        interface IAnimal
        {
            void Action();
        }
        class Dog : IAnimal
        {
            public void Action()
            {
                Console.WriteLine("Gaf");
            }
            public void Guard()
            {
                Console.WriteLine("Guard");
            }
        }
        class Cat : IAnimal
        {
            public void Action()
            {
                Console.WriteLine("Meu");
            }
            
        }

        static void Main(string[] args)
        {
            AbstractClass instance = new ConcreteClass();
            instance.Method();
            AbstractClass1 instance1 = new ConcreteClassB();
            instance1.Method();
            instance1.Operation();
            Console.WriteLine(new string('-', 20));
            AbstractBaseClass instance2 = new DerivedClass();
            instance2.AbstractMethod();
            instance2.VirtualMethod();
            instance2.SimpleMethod();
            Console.WriteLine(new string('-', 20));
            IMyInterface my = new MyClass();
            my.Method();
            Console.WriteLine(new string('-', 20));
            IMyInterface myInt = my as IMyInterface;
            myInt.MethodPrivet();
            MyClass myClass = new MyClass();
            myClass.Method();
            Console.WriteLine(new string('-', 20));
            MyClassForAbst myClassForAbst = new MyClassForAbst();
            myClassForAbst.Method();
            myClassForAbst.MethodPrivet();
            Console.WriteLine(new string('-', 20));
            IAnimal cat = new Cat();
            Dog dog = new Dog();
            IAnimal cat2 = dog as IAnimal;
            dog.Guard();
            Dog dog2 = cat2 as Dog;
            dog2.Guard();
            cat.Action();
            dog.Action();
            Console.ReadKey();
        }
    }
}
