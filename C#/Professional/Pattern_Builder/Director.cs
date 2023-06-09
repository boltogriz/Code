using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern_Builder
{
    public class Director
    {
        private Builder builder;

        public Director(Builder bilder)
        {
            this.Builder = bilder;
        }

        public Builder Builder
        {
            get { return this.builder; }
            set { this.builder = value; }
        }

        public void Construct()
        {
            Builder.BuildPartA();
            Builder.BuildPartB();
            Builder.BuildPartC();
        }
    }
}