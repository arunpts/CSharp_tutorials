using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.People
{
    public class Person
    {
        public string name;
        public int age;
        public bool HasPet;
        public void Greeting()
        {
            Console.WriteLine("Name is " + name + "\nAge: " + age);
        }
    }
}
