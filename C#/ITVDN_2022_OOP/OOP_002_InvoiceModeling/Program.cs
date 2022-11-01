namespace OOP_002_InvoiceModeling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoce invoice = new Invoce()
            {
                Date = DateTime.Parse("23/4/2035"),
                Number = "54-TK-07162",
                To = "Дом книг",
                From = "Microsoft press",
                StorekeeperSurname = "Иванов",
                ForwarderSurname = "Петров"
            };
            Console.WriteLine(invoice.Date);
            Console.WriteLine(invoice.Number);
            Console.WriteLine(invoice.To);
            Console.WriteLine(invoice.From);
            Console.WriteLine(invoice.StorekeeperSurname);
            Console.WriteLine(invoice.ForwarderSurname);
            Console.ReadKey();
        }
    }
}