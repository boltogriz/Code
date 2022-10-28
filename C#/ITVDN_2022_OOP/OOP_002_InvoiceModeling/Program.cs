namespace OOP_002_InvoiceModeling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoce invoice = new Invoce();
            //title
            //invoice.date = "23 апреля 2035 года";
            invoice.SetDate("23 апреля 2035 года");
            //invoice.number = "1024";
            invoice.SetNumber("1024");
            //invoice.to = "Дом книги";
            invoice.SetTo("Дом книги");
            //invoice.from = "Microsoft Press";
            invoice.SetFrom("Microsoft Press");
            Console.WriteLine(invoice.GetDate().Date + " " + invoice.GetDate().From);
            Console.ReadKey();
        }
    }
}