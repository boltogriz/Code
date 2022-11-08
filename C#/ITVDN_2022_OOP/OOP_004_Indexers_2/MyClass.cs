using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_004_Indexers_2
{
    internal class MyClass
    {
        int[,] array = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 0 } };
        public int this[int index1, int index2]
        {
            get => array[index1, index2];
            set => array[index1, index2] = value;
        }
        //public int GetLength(int dimension) => array.GetLength(dimension);
        public int GetLength(int dimension) { return array.GetLength(dimension); }
    }
}
