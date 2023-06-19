using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassSerializationXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var item = new ShoppingCartItem(234563, 50000, 5);
            item.car = Car.BMW;
            item.carType.marca = "Ford";
            item.carType.id = 1;

            var stream = new FileStream("SerializeCar.xml", FileMode.Create);
            
            XmlSerializer serializer = new XmlSerializer(typeof(ShoppingCartItem));
            serializer.Serialize(stream, item);

            stream.Close();

            stream = new FileStream("SerializeCar.xml", FileMode.Open);
            serializer = new XmlSerializer(typeof(ShoppingCartItem));
            item = serializer.Deserialize(stream) as ShoppingCartItem;

            stream.Close();

            Console.WriteLine(item.price);
            Console.WriteLine(item.car);
            Console.WriteLine((Int32)(item.car));

            Console.ReadKey();
        }
    }
}
