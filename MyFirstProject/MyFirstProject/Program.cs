using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstProject.People;

namespace MyFirstProject
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Person person = new Person();

            person.name = "arun";
            person.age = 10;
            person.HasPet = true;

            person.Greeting();
        }
    }
}
