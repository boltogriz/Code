using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anotherspace
{
    class MyClass
    {
        public int a;
        public void Console()
        {
            System.Console.WriteLine(@"Hellow World");
        }
        public void Show(string[] vales)
        {
            foreach (var vale in vales)
            {
                System.Console.WriteLine(vale);
            }
        }
    }
}
