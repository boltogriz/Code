using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes_001
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class MyAttribute : System.Attribute
    {
        private int number;
        private readonly string date;
        public string Date
        {
            get { return date; }
        }
        public MyAttribute(string date)
        {
            this.date = date;
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}
