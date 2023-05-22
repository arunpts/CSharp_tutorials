using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumTest
{
    public enum Days
    {
        Monday=1, Tuesday, Wednesday, Thursday, Friday
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(int i in Enum.GetValues(typeof(Days)))
                Console.WriteLine(i+" "+(Days)i);
            /*foreach(string s in Enum.GetNames(typeof(Days)))
                Console.WriteLine(s);*/
            Console.WriteLine(Days.Monday);
            Console.WriteLine((int)Days.Monday);
        }
    }
}
