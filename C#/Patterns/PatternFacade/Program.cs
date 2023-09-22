using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFacade
{
    internal class Program
    {
        public static Facade Facade
        {
            get;
            set;
        }

        static void Main(string[] args)
        {
            Facade = new Facade();
            Facade.MethodA();
            Facade.MethodB();

            Console.ReadKey();
        }
    }
}
