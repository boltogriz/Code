namespace _003_ITVDN_Abstraction
{
    abstract class AbstractClass
    {
        public abstract void Method();
    }
    class ConcreteClass : AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("Hello, World!");
        }
    }
    class ConcreteClassA
    {
        public void Operaton()
        {
            Console.WriteLine("ConcreteClassA.Operation");
        }
    }
    abstract class AbstractClassA : ConcreteClassA
    {
        public abstract void Method();
    }
    class ConcreteClassB : AbstractClassA
    {
        public override void Method()
        {
            Console.WriteLine("ConcreteClassB.Method");
        }
    }
    abstract class AbstractBasesClass
    {
        public void SimpleMethod()
        {
            Console.WriteLine("AbstractBasesClass.SimpleMethod()");
        }
        virtual public void VirtualMethod()
        {
            Console.WriteLine("AbstractBaseClass.VirtualMethod");
        }
        abstract public void AbstacrMethod();
    }
    class ConcreDerivedClass : AbstractBasesClass
    {
        public override void AbstacrMethod()
        {
            Console.WriteLine("AbstMethod()");
        }
        public override void VirtualMethod()
        {
            Console.WriteLine("ConcreteClass.Virtual()");
        }
    }
    class ConcreteClassD : AbstractClassC
    {
        string s = "FIRST";
        public ConcreteClassD()
        {
            Console.WriteLine("3 ConcreClass()");
            s = "SECOND";
        }
        public override void AbstractMethod()
        {
            Console.WriteLine("Реализация метода AbstactMethod() в CondcreteClass {0}", s);
        }
    }
    interface IInterface
    {
        void Method();
    }
    class MyClass : IInterface
    {
        public void Method()
        {
            Console.WriteLine("Метод - реализации Интерфейса");
        }
    }
    interface IInterace1
    {
        void Method1();
    }
    interface IInterface2
    {
        void Method2();
    }
    class MyClass1 : IInterace1, IInterface2
    {
        public void Method1()
        {
            Console.WriteLine("Method1()");
        }
        public void Method2()
        {
            Console.WriteLine("Method2()");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractClass instance = new ConcreteClass();
            instance.Method();
            AbstractClassA instance1 = new ConcreteClassB();
            instance1.Method();
            ConcreDerivedClass instance2 = new ConcreDerivedClass();
            instance2.SimpleMethod();
            instance2.AbstacrMethod();
            instance2.VirtualMethod();
            Console.WriteLine();
            Console.WriteLine();
            AbstractClassC instance3 = new ConcreteClassD();
            Console.WriteLine(new string('-', 55));
            instance3.AbstractMethod();
            Console.WriteLine(new string('-', 55));
            MyClass instance4 = new MyClass();
            instance4.Method();
            Console.WriteLine(new string('-', 55));
            IInterace1 instance5 = new MyClass1();
            MyClass1 instance6 = new MyClass1();
            instance5.Method1();
            instance6.Method2();
            Console.ReadKey();
        }
    }
}