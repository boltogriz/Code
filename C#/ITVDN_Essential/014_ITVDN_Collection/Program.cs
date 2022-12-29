namespace _014_ITVDN_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception ex = new Exception("Мое Исключение");
            try
            {
                throw ex;
                int a = 0, n = 2;
                a = a / (2 - n);
                Console.WriteLine("a={0}", 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}