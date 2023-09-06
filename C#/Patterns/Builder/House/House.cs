using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class House
    {
        private ArrayList parts = new ArrayList();

        public void Add(object part)
        {
            parts.Add(part);
        }
    }
}