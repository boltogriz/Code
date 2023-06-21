using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCOllector
{
    class OtherObject
    {
        byte[] array = new byte[1024 * 50];
    }
    internal class NormalObject
    {
        byte[] array = new byte[1024];
        public NormalObject() 
        {
            Console.WriteLine("Constructor {0}", this.GetHashCode());
        }
        ~ NormalObject() 
        {
            Console.WriteLine("Destructor {0}", this.GetHashCode());
            Console.ReadLine();
        }
    }
}
