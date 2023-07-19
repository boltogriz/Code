using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultyDomainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDomain domain1 = AppDomain.CreateDomain("Domain 1");
            AppDomain domain2 = AppDomain.CreateDomain("Domain 2");
            try 
            {
                domain1.ExecuteAssembly("App1.exe");
                domain2.ExecuteAssembly("App2.exe");
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Главный домен {0}", AppDomain.CurrentDomain.FriendlyName);

            Console.ReadKey();
        }
    }
}
