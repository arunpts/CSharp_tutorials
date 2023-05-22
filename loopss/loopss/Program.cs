using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace loopss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter your age: ");
             int age = Convert.ToInt32(Console.ReadLine());

             if (age >= 18)
             {
                 Console.WriteLine("You are fine");
             }
             else
             {
                 Console.WriteLine("you are not fine");
             }
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            if(name == "")
            {
                Console.WriteLine("enter name");
            }
            else
            {
                Console.WriteLine("Hello"+name);
            }*/

            // switch
            /* Console.WriteLine("Enter grade(A,B,C,D): ");
             char grade = char.Parse(Console.ReadLine());

             switch (grade)
             {
                 case 'A':
                     Console.WriteLine("Excellent");
                     break;
                 case 'B':
                     Console.WriteLine("Well Done");
                     break;
                 case 'C':
                     Console.WriteLine("you passed");
                     break;
                 case 'D':
                     Console.WriteLine("Failed");
                     break;
                 default:
                     Console.WriteLine("Inavalid");
                     break;
             }
             Console.WriteLine(grade);*/

            //while loops
            /*
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            while(name=="")
            {
                Console.WriteLine("please enter your name!!");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello "+name);

            int i = 0;
            while (i<5)
            {
                Console.WriteLine(i);
                i++;
            }

            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);*/

            /*
            for(int i=0;i<10;i+=2)
            {
                Console.WriteLine(i);
            }
            for(int y=10;y>0;y--)
            {
                Console.WriteLine(y);
            }
            Console.WriteLine("Happy new year");

            for (int i = 0; i <= 2;i++)
            {
                Console.WriteLine("Outer: "+i);

                for (int j = 0; j <= 3;j++)
                {
                    Console.WriteLine("Inner: "+j);
                }
            }*/

            //nested loops
            /*
            Console.WriteLine("enter rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter cols: ");
            int cols = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter symbol: ");
            string symbol = Console.ReadLine();

            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine("");
            }
            //foreach
            string[] cars = { "volvo", "bmw", "ford", "toyota" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }*/
            //break
            Console.WriteLine("Break:");
            for (int i=0;i<10;i++)
            {
                if(i==4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("Continue");
            for(int i=0;i<10; i++)
            {
                if(i==4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            
        }
    }
}
