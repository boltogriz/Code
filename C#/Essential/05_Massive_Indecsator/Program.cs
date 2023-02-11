using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _05_Massive_Indecsator
{
    public interface IAnimal
    {
        void Voice();
    }
    public class Dog : IAnimal
    {
       static int index;
        public static int Index 
        {
            get
            {
                return index;
            }
            private set 
            { 
                index = value; 
            } 
        }
        string[] array = new string[Index];
        string[] wordsRu = new string[3]; 
        string[] wordsEn = new string[3]; 
        public Dog()
        {
            Index = 3;
            wordsRu[0] = "дом"; wordsEn[0] = "house";
            wordsRu[1] = "ручка"; wordsEn[1] = "pen";
            wordsRu[2] = "солнце"; wordsEn[2] = "Sun";
        }
        public int GetIndex()
        {
            return Index;
        }
        public int Length { get { return array.Length; } }
        public string this[int Index]
        {
            get 
            {
                if(Index >= 0 && Index < array.Length)
                    return wordsRu[Index] + " - " + wordsEn[Index];
                else
                    return null;
            }
            set 
            {
                if (Index >= 0 && Index < array.Length)
                    array[Index] = value;
                else
                    Console.WriteLine("Попытка записи за пределами массива");
            }
        }
        public string this[string Index]
        {
            get
            {
                for (int i = 0; i < wordsRu.Length; i++)
                {
                    if (wordsRu[i] == Index)
                        return wordsEn[i];
                }
                        return "слово не найдено";
            }
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
            dog[3] = "3";
            int index = 3;
            Console.WriteLine("index {0} = {1}, {2} ", index, dog[index], dog.Length);
            for(int j = 0; j < dog.Length; j++)
            {
                Console.WriteLine(dog[j]);
            }
            Console.WriteLine(new String('-', 20));
            string word = "дом";
            Console.WriteLine("{0} - {1}", word, dog[word]);
            Console.WriteLine(new String('-', 20));
            Console.ReadKey();
        }
    }
}
