using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Partial
{
    public class Factory
    {
        public Product FactoryMethod()
        {
            return new Product();
        }
    }
}