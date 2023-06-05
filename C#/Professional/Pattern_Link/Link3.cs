using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Link
{
    internal class Link3
    {
        public void Method()
        {
            Link2 link = new Link2();
            link.Method();
            Console.WriteLine("Link3");
        }
    }
}
