using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var item = new ShoppingCartItem(234563, 50000, 5);
            item.taxable = true;
            var stream = new FileStream("SerializeCar.txt", FileMode.Create);
            var formatter = new BinaryFormatter(); 
            formatter.Serialize(stream, item);
            stream.Close();

            stream = new FileStream("SerializeCar.txt", FileMode.Open);
            formatter = new BinaryFormatter();
            item = (ShoppingCartItem)formatter.Deserialize(stream);
            Console.WriteLine(item.total);
            Console.WriteLine(item.taxable);
            stream.Close();

            Console.ReadKey();
        }
    }
}
