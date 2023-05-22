using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genricCollectionss
{
    internal class stackk
    {
        static void Main()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("arun");
            stack.Push("john");
            stack.Push("smith");
            stack.Push("nick");

            foreach(string s in stack)
                Console.WriteLine(s);

            Console.WriteLine("top: "+stack.Peek());
            Console.WriteLine("pop: "+stack.Pop());
            Console.WriteLine("top: " + stack.Peek());
            Console.WriteLine();
        }

    }
}
