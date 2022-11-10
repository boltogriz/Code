using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_002_InvoiceModeling
{
    class Invoce
    {
        //title
        public Invoce() { }
        public Invoce(DateTime date, string number, string to, string from, string storekeeperSurname, string forwarderSurname)
        {
            Date = date;
            Number = number;
            To = to;
            From = from;
            StorekeeperSurname = storekeeperSurname;
            ForwarderSurname = forwarderSurname;
        }
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
