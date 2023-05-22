using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverriding
{
     class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            animal.Speak();
            dog.Speak();
            cat.Speak();
        }
    }
    class Animal
    {
        public void Speak()
        {
            Console.WriteLine("this animal speaks");
        }
    }
    class Dog : Animal
    {
        public void Speak()
        {
            Console.WriteLine("this animal barks");
        }
    }
    class Cat : Animal
    {
        public void Speak()
        {
            Console.WriteLine("this animal mewos");
        }
    }
}
