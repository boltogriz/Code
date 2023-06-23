using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVI
{
    public class BaseClass
    { 
        public virtual void DoWork() { Console.WriteLine("1"); }
  
    }
    public sealed class Derived : BaseClass 
    { 
        public override void DoWork() { Console.WriteLine("2"); }
        public void DoWork3() { Console.WriteLine("3"); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass instance = new Derived();
            instance.DoWork();


            Derived instance2 = instance as Derived;
            instance2?.DoWork3();
            instance2?.DoWork();
           
            


            instance = new BaseClass();
            instance.DoWork();

            Console.ReadKey();
        }
    }
}
