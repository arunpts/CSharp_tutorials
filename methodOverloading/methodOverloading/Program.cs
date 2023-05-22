using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverloading
{
    internal class Program
    {
        static double Multiply(double a,double b)
        {
            return a * b;
        }
        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
        static void Main(string[] args)
        {
            double total;
            double total2;

            total = Multiply(2, 3);
            total2 = Multiply(2,3,4);
            

            Console.WriteLine("Total: "+total);
            Console.WriteLine("Total: "+total2);
        }
    }
}
