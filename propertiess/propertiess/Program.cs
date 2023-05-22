using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertiess
{
    class Person
    {
        private String name;
        /*
        public String Name //properties
        {
            get { return name; }
            set { name= value; }
        }*/
        public String Name
        { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "arun";
            Console.WriteLine(p.Name);
        }
    }
}
