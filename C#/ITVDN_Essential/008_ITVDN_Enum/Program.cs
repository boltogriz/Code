namespace _008_ITVDN_Enum
{
    interface IInterface
    {
        public void Method();
    }
    struct MyClass : IInterface
    {
        public void Method()
        {
            Console.WriteLine("Method()");
        }
    }
    enum EnumType : byte
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Three = 3
    }

    internal class Program
    {
        public static void MethodEnum(EnumType e)
        {
            switch (e)
            {
                case EnumType.Zero:
                    Console.WriteLine("Число 0");
                    Console.WriteLine("Число 0");
                    break;
                case EnumType.One:
                    Console.WriteLine("Число 1");
                    break;
                case EnumType.Two:
                    Console.WriteLine("Число 2");
                    break;
                case EnumType.Three:
                    Console.WriteLine("Число 3");
                    break;
                default:
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            short a = 25;
            object o = a;
            short b = (short)o;
            Console.WriteLine(b);
            Console.WriteLine(o);
            Console.WriteLine(a);
            MyClass myClass;
            myClass.Method();
            IInterface boxed = myClass;
            boxed.Method();
            MyClass unBoxed = (MyClass)boxed;
            Console.WriteLine(EnumType.One);
            Console.WriteLine((byte)EnumType.One);
            EnumType digit = EnumType.Three;
            Console.WriteLine(digit);
            Console.WriteLine((byte)digit);
            for (EnumType number = EnumType.Zero; number <= EnumType.Three; number++)
            {
                Console.WriteLine(number);
                MethodEnum(number);
            }

        }
    }
}