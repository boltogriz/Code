using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializable
{
    [Serializable]
    internal class Mersedes : Car
    {
        protected Mode mode;
        public Mersedes(string name, int speed, Mode mode)
            : base(name, speed)
        { 
            this.mode = mode;
        }
        private Mersedes (SerializationInfo info, StreamingContext context)
        {
            Console.WriteLine("context {0}", context.State.ToString());
            this.Name = info.GetString("name");
            radio = new Radio();

        }
        public void SetMode(Mode mode)
        {
            this.mode = mode;
            Console.WriteLine(this.mode);
        }
        public void ShowMode()
        {
            Console.WriteLine(this.mode);
        }
    }
}
