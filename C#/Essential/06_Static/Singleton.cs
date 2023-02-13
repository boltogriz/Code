using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Static
{
    internal class Singleton
    {
        private static Singleton instance = null;
        protected Singleton()
        { }
        public static Singleton Instance()
        {
            if(instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
