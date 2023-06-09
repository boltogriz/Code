using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern_Builder
{
    public class ConcreteBuilder : Builder
    {
        private Product product = new Product();
        public Product Product
        {
            get { return product; }
            set { this.product = value; }
        }
        public override void BuildPartA()
        {
            Product.Add("Part A");
        }

        public override void BuildPartB()
        {
            Product.Add("Part B");
        }

        public override void BuildPartC()
        {
            Product.Add("Part C");
        }

        public override Product GetResult()
        {
            return Product;
        }
    }
}