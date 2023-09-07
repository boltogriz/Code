using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Method
{
    public class ConcreteProduct : Product
    {
        public ConcreteProduct() 
        {
            Console.WriteLine(this.GetHashCode());
        }
    }
}