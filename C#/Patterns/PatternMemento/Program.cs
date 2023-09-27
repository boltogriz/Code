using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMemento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.State = "On";

            Caretaker caretaker = new Caretaker();
            caretaker.Memento = originator.CreateMemento();

            originator.State = "Off";
            originator.SetMemento(caretaker.Memento);

            Console.ReadKey();
        }
    }
}
