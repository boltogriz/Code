using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVI2
{
    public class Base
    {
        public void DoWork()
        {
            PreDoWork();
            CoreDoWork();
        }
        protected void PreDoWork() { Console.WriteLine("0"); }
        protected virtual void CoreDoWork() { Console.WriteLine("1"); }
    }
    public class Derived : Base
    {
        protected override void CoreDoWork()
        {
            Console.WriteLine("2");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Base instance = new Derived();
            instance.DoWork();
            

            Console.ReadKey();
        }
    }
}
