using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Link
{
    internal class Link2
    {
        internal void Method()
        {
            Link1 link = new Link1();
            link.Method();
            Console.WriteLine("Link2");
        }
    }
}
