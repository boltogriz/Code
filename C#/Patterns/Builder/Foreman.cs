using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class Foreman
    {
        Builder builder;
        public Foreman(Builder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.BuildBasement();
            builder.BuildStorey();
            builder.BuildRoof();
        }
    }
}