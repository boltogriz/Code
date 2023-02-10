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
        string[] array = new string[3];
        public string this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
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
        static void ShowArray(params int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
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
            ShowArray(0, 1, 2, 3, 4, 5, 6, 7, 8, 9);
            Console.WriteLine();
            Console.WriteLine(new String('-', 20));
            Dog dog = new Dog();
            dog[0] = "0";
            dog[1] = "1";
            dog[2] = "2";
            Console.WriteLine(dog[0]);
            Console.ReadKey();
        }
    }
}
