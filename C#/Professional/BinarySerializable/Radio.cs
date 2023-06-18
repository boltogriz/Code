using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializable
{
    [Serializable]
    internal class Radio
    {
        [NonSerialized]
        private int id = 9;
        internal void OnOff(bool state)
        {
            Console.WriteLine(state ? "Радио Включено" : "Радио Выключено");
        }
    }
}
