using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Universal_Type
{
    internal class Halper
    {
        public static bool HasCustomAttribute(object obj)
        {
            var attrs = obj.GetType().GetCustomAttributes(false);
            return attrs.Any(a => a.GetType() == typeof(TestClassAttribute));
        }
    }
}
