using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Partial
{
    public class Class4
    {
        Class3 book = new Class3();
        private Class3 class3;
        private Class3 name1;

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

        public Class3 Class3
        { 
            get
            {
                return class3;
            }
            set
            {
                class3 = value;
            }
        }
        public Class3 Title
        {
            get
            {
                return name1;
            }
            set
            {
                name1 = value;
            }
        }

        public Class3 Class31
        {
            get => default;
            set
            {
            }
        }
    }
}