using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandlingThrow
{
    public class DivideByOddNoException : ApplicationException
    {
        public override string Message
        {
            get { return "Attempted to divide by odd number";  }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b%2>0)
            {
                //throw new ApplicationException("b cannot be oddnumber");
                throw new DivideByOddNoException();
            }
            int result = a / b;
            Console.WriteLine("Result: "+result);
            Console.WriteLine("end of the program");
        }
    }
}
