namespace OOP_002_InvoiceModeling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoce invoice = new Invoce();
            //title
            invoice.SetTitle("001");
            //invoice.date = "23 апреля 2035 года";
            invoice.Date = ("23 Апреля 2035 года");
            //invoice.number = "1024";
            invoice.SetNumber("1024");
            //invoice.to = "Дом книги";
            invoice.SetTo("Дом книги");
            //invoice.from = "Microsoft Press";
            invoice.SetFrom("Microsoft Press");
            string date = invoice.Date;
            Console.WriteLine(date);

            Console.ReadKey();
        }
    }
}