using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("rick",65);
            Human human2 = new Human("morty",16);

            human1.Eat();
            human1.sleep();

            
            human2.Eat();
            human2.sleep();

        }
    }
    class Human
    {
        public string name;
        public int age;

        public  Human(String name,int age) 
        {
            this.name = name;
            this.age = age;
        }
        public void Eat()
        {
            Console.WriteLine(name+" is eating");
        }
        public void sleep()
        {
            Console.WriteLine(name+" is sleeping");
        }
    }
}
