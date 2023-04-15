using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreprocessorDirectives
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            Console.WriteLine("hello");
            #endregion
#if DEBUG
            Console.WriteLine("hello");
#endif
            Console.Read();
        }
    }
}
