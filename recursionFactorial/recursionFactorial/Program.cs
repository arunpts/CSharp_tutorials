using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursionFactorial
{
    internal class Program
    {
        public int Fact(int num)
        {
            if(num == 0)
                return 1;
            else
                return num * Fact(num - 1);
        }
        static void Main(string[] args)
        {
            int num, f;
            Console.Write("Enter num: ");
            num = Convert.ToInt32(Console.ReadLine());

            Program p = new Program();
            Console.WriteLine("Factorial: "+ p.Fact(num));

        }
    }
}
