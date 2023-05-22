using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace straightLine
{
    /*Write a program that takes three points (x1, y1), (x2, y2) and (x3, y3) from the user and
    the program will check wheteher or not all the three points fall on one straight line.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1,y1,x2,y2,x3,y3;
            double s1, s2; //slope
            Console.Write("Enter point x1: ");
            x1=Convert.ToInt32(Console.ReadLine());
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

            s1 = (y2 - y1) / (x2 - x1);
            s2 = (y3 - y2) / (x3 - x2);

            if (s1==s2)
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
