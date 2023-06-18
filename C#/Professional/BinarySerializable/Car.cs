using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializable
{
    [Serializable]
    internal class Car : ISerializable
    {
        protected int speed;
        protected string name;
        protected Radio radio;
        public Car () { }
        public Car (string name, int speed) 
        { 
            this.speed = speed;
            this.name = name;
            radio = new Radio ();
        }
        private Car (SerializationInfo propertyBag, StreamingContext context)
        {
            Console.WriteLine("[ctor] ContextState: {0}", context.State.ToString());
            name = propertyBag.GetString ("name");
            speed = propertyBag.GetInt32("speed");
            radio = new Radio();
        }
        public void TurnOnRadio(bool state)
        {
            this.radio.OnOff(state);
        }

        public void GetObjectData(SerializationInfo propertyBag, StreamingContext context)
        {
            Console.WriteLine("[GetObjectData] ContextState: {0}", context.State);
            propertyBag.AddValue ("name", name);
            propertyBag.AddValue("speed", speed);
        }

        public string Name { get { return name; } set { name = value; } }
        public int Speed { get { return speed; } set {  speed = value; } }
    }
}
