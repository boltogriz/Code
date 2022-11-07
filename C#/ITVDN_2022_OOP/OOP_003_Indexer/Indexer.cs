using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_003_Indexer
{
    internal class Indexer<T>
    {
        private const int MAX_INDEX = 10;
        private T[] array = new T[MAX_INDEX];
        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
        public int maxIndex
        {
            get => MAX_INDEX;
        }
        public string TaseName0 { get; set; }
        public string TaseName1 { get; set; }
        public Indexer()
        {
            TaseName0 = "Конструктор";
        }
    }
}
