namespace _005_ITVDN_Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1[4] = "запись";
            Console.WriteLine(class1[4]);
            Console.WriteLine(new string('-', 30));
            Dictionary dictionary = new Dictionary();
            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["солнце"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["ножка"]);
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(dictionary[i]);
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            DerivedClass derivedClass = new DerivedClass();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(derivedClass[i]);
            }
            Console.ReadKey();
        }
    }
}