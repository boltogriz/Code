using System;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice()
            {
                Date = DateTime.Parse("11/07/2021"),
                Number = "91-ВН-09124",
                To = "ГКУ КК \"Ейская РЦБ УСО\"",
                From = "ООО \"АутСорсинг\"",
                StorekeeperSurname = "Сазыкин Н.П.",
                ForwarderSurname = "Каданцев А.Л."
            };

            Console.WriteLine(invoice.Date);
            Console.WriteLine(invoice.Number);
            Console.WriteLine(invoice.To);
            Console.WriteLine(invoice.From);
            Console.WriteLine(invoice.StorekeeperSurname);
            Console.WriteLine(invoice.ForwarderSurname);
        }
    }
}
