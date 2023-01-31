using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Partial
{
    public class Class4
    {
        Class3 book = new Class3();

        public Class3 Book
        {
            get 
            {
                return book;
            }
            set
            {
                book = value;
            }
        }
    }
}