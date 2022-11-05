using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_002_InvoiceModeling
{   
    /// <summary>
    /// Represents a row of fata in a InvoiceModeling.Table.
    /// </summary>
    internal class Row
    {
        /// <summary>
        /// Gets or set the Sequential Nubmer
        /// </summary>
        int SequentialNumber { get; set; }
        /// <summary>
        /// Gets or sets the Description
        /// </summary>
        string Description { get; set; }
        /// <summary>
        /// Gets or sets the Quantity
        /// </summary>
        decimal Quantity { get; set; }
        /// <summary>
        /// Gets or sets the Price
        /// </summary>
        decimal Price { get; set; }
        /// <summary>
        /// Gets the Amount
        /// </summary>
        decimal Amount { get => Quantity * Price; }
    }
}
