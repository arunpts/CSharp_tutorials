using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typecasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implicit");
            int age = 9;
            double doubleAge = age;
            Console.WriteLine("Age: {0}, {1}",age,age.GetType());
            Console.WriteLine("doubleAge: {0}, {1}",doubleAge,doubleAge.GetType());


            Console.WriteLine("Explicit");
            double pi = 3.14;
            int num = (int)pi;
            Console.WriteLine("Double Pi: {0}, {1}",pi,pi.GetType());
            Console.WriteLine("intt num: {0} ,{1}",num,num.GetType());

            string stringpi=Convert.ToString(pi);
            Console.WriteLine(stringpi.GetType());
        }
    }
}
