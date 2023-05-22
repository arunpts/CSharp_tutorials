using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursionFibo
{
    internal class Program
    {
        public int Fibo(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibo(n - 1)+Fibo(n-2);
        }
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter num: ");
            num = Convert.ToInt32(Console.ReadLine());
            Program p = new Program();

            Console.WriteLine("Fibonacci: ");
            for(int i = 0; i < num; i++)
            {
                Console.Write(p.Fibo(i)+" ");
            }
            Console.WriteLine();
        }
    }
}
