using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableDemo_02
{
    public class Fish
    {
        private readonly string name;
        public Fish(string name)
        {
            this.name = name;
        }
        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            var otherFitsh = obj as Fish;
            if (otherFitsh == null)
            {
                return false;
            }
            return otherFitsh.name == this.name;
        }
    }
    public class Fish2
    {
        private readonly string name;
        public Fish2(string name)
        {
            this.name = name;
        }
        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            var otherFitsh = obj as Fish2;
            if (otherFitsh == null)
            {
                return false;
            }
            return otherFitsh.name == this.name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var duplicates = new Hashtable();
            var key1 = new Fish("Herring");
            var key2 = new Fish2("Herring");
            duplicates[key1] = "Hello";
            duplicates[key2] = "Hello2";
            Console.WriteLine(duplicates.Count);
            Console.ReadKey();
        }
    }
}
