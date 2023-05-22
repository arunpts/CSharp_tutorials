using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("----------");
                Console.WriteLine("Calculator");
                Console.WriteLine("----------");

                Console.Write("Enter num 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter num 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter an option +,-,*,/:");
                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"{num1}+{num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"{num1}-{num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"{num1}*{num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"{num1}/{num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("invalid");
                        break;
                }
                Console.WriteLine("would you like to continue? Y/N: ");
            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Thank you for using!!");
        }
    }
}
