namespace _002_ITVDN_Essential
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PartialClass partialClass = new PartialClass();
            partialClass.MethodFromPart1();
            partialClass.MethodFromPart2();
            Factory factory = new Factory();
            Product product = factory.FactoryMethod();
            Console.ReadKey();
        }
    }
}