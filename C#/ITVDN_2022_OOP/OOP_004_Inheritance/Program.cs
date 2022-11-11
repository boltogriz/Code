using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_004_Inheritance
{
    class ClassA
    {
        public void MethodA() => Console.WriteLine("ClassA.MethodA");
    }
    class ClassB : ClassA
    {
        #region Composition
        //public void MethodA() => new ClassA().MethodA(); 
        #endregion
        public void MethodB() => Console.WriteLine("ClassB.MethodB");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassB instance = new ClassB();
            instance.MethodA();
            instance.MethodB();
            new ClassA().MethodA();
            Console.ReadKey();
        }
    }
}
