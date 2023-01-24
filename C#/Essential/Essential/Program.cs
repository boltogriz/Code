using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential
{
    class Butterfly
    {
        public string name;
        public string Name { get => name; set => name = value; }
        public void Fly()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Name);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Butterfly mahaon = new Butterfly();
            mahaon.Name = "Admiral";
            mahaon.Fly();
            Console.ReadLine();
        }
    }
}
