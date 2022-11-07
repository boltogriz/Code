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
        public Row this[int index]
        {
            get { return Table[index]; }
            set { Table[index] = value; }
        }
        //footer
        public decimal Total { get => Table.Total; }
        public string StorekeeperSurname { get; init; } = null;
        public string ForwarderSurname { get; init; } = null;
    }
}
