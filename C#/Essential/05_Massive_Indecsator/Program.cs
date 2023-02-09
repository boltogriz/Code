using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Massive_Indecsator
{
    public interface IAnimal
    {
        void Voice();
    }
    public class Dog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Voice");
        }
        public void Jump()
        {
            Console.WriteLine("Jump");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] arr = new byte [3];
            Dog[] dogs = { new Dog(), new Dog(), new Dog() };
            for(int i = 0; i < dogs.Length; i++)
            {
                dogs[i].Voice();
                dogs[i].Jump();
            }
            Console.WriteLine(new String('-', 20));
            IAnimal[] animal = dogs;
            for(int i = 0; i < animal.Length; i++)
            {
                animal[i].Voice();
                //animal[i].Jump();
            }
            Console.WriteLine(new String('-', 20));
            dogs = (Dog[])animal;
            for(int i = 0; i < dogs.Length; i++)
            {
                dogs[i].Voice();
                dogs[i].Jump();
            }
            Console.WriteLine(new String('-', 20));
            Console.ReadKey();
        }
    }
}
