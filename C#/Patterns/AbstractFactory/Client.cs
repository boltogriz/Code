using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class Client
    {
        public Client(AbstractFatory factory)
        {
            Bottle = factory.CreateBottle();
            Water = factory.CreateWater();
            Cover = factory.CreateCover();
        }

        public AbstractBottle Bottle
        {
            get; set;
        }

        public AbstractWater Water
        {
            get; set;
        }
        public AbstractCover Cover { get; set; }

        public void Run()
        {
            Bottle.Interact(Water, Cover);
        }
    }
}