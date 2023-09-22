using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFlyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ActorMieMyers mike = new ActorMieMyers();

            RoleAustinPowers austin = new RoleAustinPowers(mike);
            austin.Greeting("Hello! I'm Austin Powers!");

            RoleDoctorEvil dr = new RoleDoctorEvil(mike);
            dr.Greeting("Hell! I'm Dr.Evil");

            Console.ReadKey();
        }
    }
}
