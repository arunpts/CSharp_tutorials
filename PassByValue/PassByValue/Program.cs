using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByValue
{
    internal class Program
    {
        static void Swap(int x, int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
            
        }
        static void Main(string[] args)
        {
            int a =100, b =200;
            Console.WriteLine("Before swap");
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);

            Swap(a,b);

            Console.WriteLine("After swap");
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);


        }
    }
}
