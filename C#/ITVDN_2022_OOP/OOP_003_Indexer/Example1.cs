using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_003_Indexer
{
    internal class Example1
    {
        private string[] arrays = new string[0];
        public int Length => arrays.Length;
        public string this[int index]
        { 
            get => arrays[index];
            set
            {
                bool arrayNeedsIncreasedByOn = arrays.Length == index,
                tryingModifyExistingItem = index < arrays.Length && index >= 0;
                if (arrayNeedsIncreasedByOn)
                {
                    AddRow(value);
                }
                else if (tryingModifyExistingItem)
                {
                    arrays[index] = value;
                }
                else
                {
                    while (arrays.Length < index)
                    {
                        AddRow("None");
                    }
                    AddRow(value);
                }
            }
        }
        public void AddRow(string row)
        {
            Array.Resize(ref arrays, arrays.Length + 1);
            arrays[arrays.Length - 1] = row;
        }
    }
}
