using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_002_InvoiceModeling
{
    internal class Table
    {
        Row[] rows = new Row[0];
        public Row this[int index]
        { 
            get => rows[index];
            set
            {
                bool arrayNeedsIncreasedByOne = rows.Length == index,
                     tryingModifyExistingItem = index < rows.Length && index >= 0;
                if (arrayNeedsIncreasedByOne)
                {
                    AddRow(value);
                }
                else if (tryingModifyExistingItem)
                {
                    rows[index] = value;
                    rows[index].SequentialNumber = index + 1;
                }
                else
                {
                    rows[index] = value;
                }
            }
        }
        public int Size { get => rows.Length; }
        public decimal Total { get; private set; }
        public void AddRow(Row row)
        {
            Array.Resize(ref rows, rows.Length + 1);
            rows[rows.Length - 1] = row;
            row.SequentialNumber = rows.Length;
            Total += row.Amount;
        }
        public Row GetRow(int index)
        { 
            return rows[index];
        }
    }
} 