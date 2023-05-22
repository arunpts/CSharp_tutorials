using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linee
{
    /*Write a program that takes three points (x1, y1), (x2, y2) and (x3, y3) from the user and
    the program will check wheteher or not all the three points fall on one straight line.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2, x3, y3;
            double d1, d2, d3;
            
            Console.Write("Enter point x1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter point y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter point x2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter point y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter point x3: ");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter point y3: ");
            y3 = Convert.ToInt32(Console.ReadLine());

            d1 = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
            d2 = Math.Sqrt(Math.Pow(x3-x2,2)+Math.Pow(y3-y2,2));
            d3 = Math.Sqrt(Math.Pow(x3-x1,2)+Math.Pow(y3-y1,2));
            /*a,b,c: then distance ab+bc=ac */
            double dist = d1 + d2;
            if(dist==d3)
            {
                Console.WriteLine("The three points fall on straight line.");
            }
            else
            {
                Console.WriteLine("The three points doesn't fall on straight line.");
            }
        }
    }
}
