using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue();
            queue.Enqueue("An item");
            Console.WriteLine(queue.Dequeue());

            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");

            object element = queue.Peek();
            Console.WriteLine(element as string);

            Console.WriteLine(new string('-',20));
            if (element is string)
            {
                queue.Dequeue();
            }

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            Console.ReadLine();
        }
    }
}
