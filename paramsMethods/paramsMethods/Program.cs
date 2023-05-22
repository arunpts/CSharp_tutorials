using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paramsMethods
{
    internal class Program
    {
        static double CheckOut(params double[] prices)
        {
            double total = 0;
            foreach (double price in prices)
            {
                total=total+price;
            }
            return total;
        }
        static void Main(string[] args)
        {
            double total = CheckOut(3.99, 5.75, 15);
            Console.WriteLine(total);
        }
    }
}
