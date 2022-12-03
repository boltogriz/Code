using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_ITVDN_Static
{
    internal class Singleton
    {
        private static Singleton instance = null;
        protected Singleton()
        {
        }
        public string Field { get; set; }
        public static Singleton Instance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
