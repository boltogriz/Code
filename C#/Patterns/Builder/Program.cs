using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Program
    {

        private static Builder builder;
        private static Foreman foreman;
        private static House house;

        static void Main(string[] args)
        {
            builder = new WoodBuilder();
            foreman = new Foreman(builder);
            foreman.Construct();
            house = builder.GetResult();

            Console.WriteLine(house);
            Console.ReadKey();

        }
    }
}
