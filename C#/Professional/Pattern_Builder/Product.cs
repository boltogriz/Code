using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern_Builder
{
    public class Product
    {
        private ArrayList parts = new ArrayList();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            foreach(var part in parts) 
            {
                Console.WriteLine(part);
            }
        }
    }
}