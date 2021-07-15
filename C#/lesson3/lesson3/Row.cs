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
        public int SequentialNumber { get; set; }
        public string Description { get; set; }
        public decimal Quntity { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get => Quntity * Price; }
    }
}
