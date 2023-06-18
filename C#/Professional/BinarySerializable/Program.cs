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
        static void BinarySerial()
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
        }
        static void UserSerialWork()
        {
            Car car = new Car("Mersedes-Benz", 250);
            Stream stream = File.Create("CarDataUserSerial.dat");

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, car);
            stream.Close();

            stream = File.OpenRead("CarDataUserSerial.dat");

            car = formatter.Deserialize(stream) as Car;

            Console.WriteLine(car.Name);
            Console.WriteLine(car.Speed);
        }

        static void Main(string[] args)
        {
            BinarySerial();

            Console.WriteLine(new string('-',20));

            UserSerialWork();

            Console.ReadKey();
        }
    }
}
