using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Universal_Type
{
    public abstract class Shape {}
    public class Circle : Shape { }
    public interface IContainer<out T>
    {
        T Figure { get; }
    }
    public class Container<T> : IContainer<T> 
    {
        private T figure;

        public Container(T figure) 
        { 
            this.figure = figure;
        }
        public T Figure
        { 
            get { return figure; } 
        }
    }
}
