using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _005_ITVDN_Indexers
{
    internal class DerivedClass : Dictionary
    {
        private string[] drivedArray = null;
        public DerivedClass()
        {
            drivedArray = new string[3];
            drivedArray[0] = "Zero";
            drivedArray[1] = "One";
            drivedArray[2] = "Two";
        }
        public override string this[int index]
        {
            get 
            {
                if (index >= 0 && index < drivedArray.Length)
                    return base[index] + " - " + drivedArray[index];
                else
                    return "Попытка обращения за пределы массива";
            }
        }
    }
}
