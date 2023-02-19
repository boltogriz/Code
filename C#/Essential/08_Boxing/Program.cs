using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Boxing
{
    internal class Program
    {
        public interface IAnimal
        {
            void Method();
        }
        public struct Dog : IAnimal
        {
            public void Method()
            {
                Console.WriteLine("Voice");
            }
        }
        struct MyStruct
        {
            public void Method()
            {
                Console.WriteLine("Method");
            }
        }
        enum EnumType : byte
        {
            Zero = 0,
            One = 1,
            Two = 2,
            Three = 3,
            x,
            y,
            z = 24,
            i = 12,
            u,
            v
        }
        static void MethodEnum(EnumType e)
        {
            switch (e)
            {
                case EnumType.Zero:
                    Console.WriteLine("1. {0} = {1}", EnumType.Zero, (byte)EnumType.Zero);
                    break;
                case EnumType.One:
                    Console.WriteLine("2. {0} = {1}", EnumType.One, (byte)EnumType.One);
                    break;
                case EnumType.Three:
                    Console.WriteLine("3. {0} = {1}", EnumType.Three, (byte)EnumType.Three);
                    break;

                default: break;
            }
        }
        static void Main(string[] args)
        {
            short a = 25;
            object o = a;
            short b = (short)o;
            MyStruct my = new MyStruct();
            ValueType boxed = my;
            MyStruct unBoxed = (MyStruct)boxed;
            Dog[] dogs = { new Dog(), new Dog(), new Dog() };
            IAnimal animal = (IAnimal)dogs[0];
            object @object = dogs;

            Console.WriteLine(EnumType.One);
            Console.WriteLine((byte)EnumType.One);

            EnumType digit = EnumType.Zero;
            Console.WriteLine(digit);
            Console.WriteLine((byte)digit);
            Console.WriteLine(new string('-', 20));
            for(EnumType i = EnumType.Zero; i <= EnumType.v; i++)
            {
                Console.WriteLine(i +" = " + (byte)i);
                
            }    
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("{0} = {1}", EnumType.z, (byte)EnumType.z);
            Console.WriteLine(new string('-', 20));
            EnumType enumTyp = EnumType.Three;
            MethodEnum(enumTyp);
            Console.WriteLine(new string('-', 20));
            EnumType digit2 = EnumType.Three;
            Type @enum = digit2.GetType();
            Console.WriteLine("1. Перечисление {0} состоит из элементов типа: ", @enum.Name);
            Console.WriteLine(Enum.GetUnderlyingType(@enum));
            Console.WriteLine(Enum.GetUnderlyingType(typeof(EnumType)));
            Console.WriteLine(new string('-', 20));
            object element = Enum.Parse(typeof(EnumType), "Two");
            EnumType number = (EnumType)element;
            Console.WriteLine(number + " " + (byte)number);
            Console.ReadKey();
            

        }
    }
}
