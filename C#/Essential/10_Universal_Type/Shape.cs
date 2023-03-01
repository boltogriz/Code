using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Universal_Type
{
    class Animal { }
    class Cat : Animal { }
    delegate T MyDelegate<out T>();
    public abstract class Shape {}
    public class Circle : Shape { }
    public interface IContainer<in T>
    {
        T Figure { set; }
    }
    [TestClass]
    public class Container<T> : IContainer<T>, IContainer1<T>
    {
        private T figure;
        public int ATest1 { get; set; }
        public int ATest2 { get; set; }

        public Container(T figure)
        {
            this.figure = figure;
        }
        public T Figure
        {
            set { figure = value; }
        }
        public override string ToString()
        {
            return figure.GetType().ToString();
        }
    }
}
