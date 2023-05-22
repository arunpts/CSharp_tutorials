using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Arun Prakash";
            string name = "John";
            Console.WriteLine(fullName.ToLower());
            Console.WriteLine(fullName.ToUpper());

            Console.WriteLine(fullName.Length);
            Console.WriteLine(fullName+name);
            Console.WriteLine(string.Concat(fullName,name));

            Console.WriteLine($"hi {fullName} {name}");
            Console.WriteLine(fullName[3]);
            Console.WriteLine(fullName.Substring(0,6));

            Console.WriteLine("this is \"sparta\"");
            Console.WriteLine(10>9);
            Console.WriteLine();
            int myAge = 20;
            int votingAge = 18;
            Console.WriteLine(myAge>=votingAge);

        }
    }
}
