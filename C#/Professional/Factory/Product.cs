using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Factories
{
    internal class Product
    {
        int i;
        public Product() 
        {
            i++;
            Console.WriteLine("I'm new Product! {0}", i);
        }

        public void Plus()
        {
            i++;
        }
        public void Show()
        {
            Console.WriteLine(i);
        }
    }
}
