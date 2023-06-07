using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string pattern = @"\d+";
            var regex = new Regex(pattern);
            while (true)
            {
                //string @string = Console.ReadKey().KeyChar.ToString();
                string @string = Console.ReadLine().ToString();
                if (@string == " ")
                    break;
                bool success = regex.IsMatch(@string);
                Console.WriteLine(success ? " соответствует шиблону \" {0}\"": " Не соответстует шаблониу \"{0}\"", pattern);
                Console.WriteLine(@string);
            }
        }
    }
}
