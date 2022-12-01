using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_ITVDN_Indexers
{
    internal class Class1
    {
        private string[] array = new string[5];
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                    return array[index];
                else
                    return "Попытка обращения за пределы массива";
            }
            set
            {
                if (index >= 0 && index < array.Length)
                    array[index] = value;
                else
                    Console.WriteLine("Попытка записи за пределама массива.");
            }
        }
    }
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] value = new string[5];
        public Dictionary()
        {
            key[0] = "книга";
            key[1] = "ручка";
            key[2] = "солнце";
            value[0] = "book";
            value[1] = "pen";
            value[2] = "sun";
        }
        public string this[string index]
        {
            get 
            {
                for(int i = 0; i < key.Length; i++)
                    if (key[i] == index)
                        return key[i] + " - " + value[i];
                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }
        public virtual string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                else
                    return "Попытка обращения за пределы массива";
            }
        }
    }
}
