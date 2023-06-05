using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    internal class Door : MapSite
    {
        Room room2 = null;
        Room room1 = null;
        bool isOpen;
        public Door(Room room1, Room room2)
        { 
            this.room1 = room1; 
            this.room2 = room2;
        }
        public override void Enter()
        {
            Console.WriteLine("Door");
        }
        public Room TOherSideFrom(Room room) 
        {
            if (room == room1)
                return room2;
            else
                return room1;
        }
    }
}
