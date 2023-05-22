using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absrtactClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dog dog = new Dog();
            dog.Sleep();
            dog.Sound();
            
        }
    }
    abstract class Animal
    {
        abstract public void Sound();
      
        public void Sleep()
        {
            Console.WriteLine("this animal sleeps");
        }
    }
    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("this animal barks");
        }
    }

}
