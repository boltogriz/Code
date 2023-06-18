using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mersedes auto = new Mersedes("CLK 500", 250, Mode.Lux);
            auto.TurnOnRadio(true);
            auto.ShowMode();

            FileStream stream = File.Create("CarData.dat");

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, auto);
            stream.Close();

            Mersedes autoDeSer;

            stream = File.OpenRead("CarData.dat");
            autoDeSer = formatter.Deserialize(stream) as Mersedes;

            autoDeSer.ShowMode();
            Console.WriteLine(autoDeSer.Speed);
            Console.WriteLine(autoDeSer.Name);
            autoDeSer.TurnOnRadio(false);

            stream.Close();

            Console.ReadKey();
        }
    }
}
