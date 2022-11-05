using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP_002_InvoiceModeling
{
    class Invoce
    {
        //title
        public DateTime Date { get; init; }
        public string Number { get; init; } = null;
        public string To { get; init; } = null;
        public string From { get; init; } = null;

        //body
        //public Table table = new Table();
        public Table Table { get; } = new Table();
        //footer
        public decimal Total { get; private set; }
        public string StorekeeperSurname { get; init; } = null;
        public string ForwarderSurname { get; init; } = null;
    }
}
