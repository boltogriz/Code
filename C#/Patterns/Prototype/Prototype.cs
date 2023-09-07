using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    public abstract class Prototype
    {
        public int Id { get; private set; }

        public Prototype(int id)
        {
            this.Id = id;
        }

        public abstract Prototype Clone();
    }
}