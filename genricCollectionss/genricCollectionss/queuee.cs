using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genricCollectionss
{
    internal class queuee
    {
        static void Main()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("arun");
            queue.Enqueue("john");
            queue.Enqueue("smith");
            queue.Enqueue("nick");

            foreach(string q in queue)
            {
                Console.WriteLine(q);
            }
            Console.WriteLine("top: " + queue.Peek());
            Console.WriteLine("pop: " + queue.Dequeue());
            Console.WriteLine("top: " + queue.Peek());
        }
    }
}
