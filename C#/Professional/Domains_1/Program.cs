using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDomain domain = AppDomain.CreateDomain("Second Domain");
            Console.WriteLine("Host domain: " + AppDomain.CurrentDomain.FriendlyName);
            Console.WriteLine("Child domain: " + domain.FriendlyName);

            AppDomain.Unload(domain);

            try 
            {
                Console.WriteLine("Host domain: " + AppDomain.CurrentDomain.FriendlyName);
                Console.WriteLine("Child domain: " + domain.FriendlyName);
            }
            catch(AppDomainUnloadedException e) 
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
