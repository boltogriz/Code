using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    /// <summary>
    /// Represents a row of fata in a lesson3.Table
    /// </summary>
    class Row
    {
        public Row() { }
        /// <summary>
        /// Initializes a new instance
        /// </summary>
        /// <param name="description">The value to write</param>
        /// <param name="quantity">quantity field</param>
        /// <param name="price">the price field</param>
        public Row(string description, decimal quantity, decimal price) =>
                  (Description, Quntity, Price) = (description, quantity, price);
        //{
        //    Description = description;
        //    Quntity = quantity;
        //    Price = price;
        //}
        public int SequentialNumber { get; set; }
        public string Description { get; set; }
        public decimal Quntity { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get => Quntity * Price; }
    }
}
