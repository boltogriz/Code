using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollectionProject
{
    public class UserCollection
    {
        public static IEnumerable Power()
        {
            yield return "Hellow world!";
        }
    }
    public class Col2
    {
        public static IEnumerable Power()
        {
            yield return 32;
        }
    }
}
