using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementorEx
{
    internal class Backpack
    {
        public string Contents
        {
            get;
            private set;
        }
        public Backpack(string contents)
        {
            this.Contents = contents;
        }
    }
}
