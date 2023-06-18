using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializable
{
    [Serializable]
    internal class Car
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
        public void TurnOnRadio(bool state)
        {
            this.radio.OnOff(state);
        }
        public string Name { get { return name; } set { name = value; } }
        public int Speed { get { return speed; } set {  speed = value; } }
    }
}
