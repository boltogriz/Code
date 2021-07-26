using System;

namespace lesson6
{
    class Program
    {
        class ClassA
        {
            public void MethodA() =>
                Console.WriteLine("ClassA.MethodA");
        }
        class ClassB : ClassA
        {
            #region Composition
            //public void MethodA() =>
            //new ClassA().MethodA(); 
            #endregion
            public void MethodB() =>
                Console.WriteLine("ClassA.MethodB");
        }
        static void Main(string[] args)
        {
            ClassB instance = new ClassB();
            instance.MethodA();
            instance.MethodB();
        }
    }
}
