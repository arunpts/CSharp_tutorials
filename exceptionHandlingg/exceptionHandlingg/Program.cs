using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandlingg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                if(b==1)
                { return; }
                int result = a / b;

                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (FormatException ex2)
            {
                Console.WriteLine("input must be numeric");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally block is execeuted");
            }
            Console.WriteLine("end of the program");
        }
    }
}
