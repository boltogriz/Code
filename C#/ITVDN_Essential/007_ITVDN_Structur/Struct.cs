using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_ITVDN_Structur
{
    struct Struct
    {
        public int field;
        public int field2;
        static int second;
        public int Field
        {
            get { return field; }
            set { field = value; }
        }
        public void Show()
        {
            Console.WriteLine(field);
        }
        int item;
        public Struct(int item)

        {
            this.item = item;
            field = 4;
            field2 = 4;
        }
    }
}
