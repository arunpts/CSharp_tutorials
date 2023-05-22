using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceee
{

    class Vehicle //base class
    {
  
        public string brand = "BMW";
        public void Honk()
        {
            Console.WriteLine("honk!!!!");
            }
        }
        class Car : Vehicle //derived class
        {
            public String model = "M5";
        }
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            car.Honk();
            Console.WriteLine("Brand: "+car.brand);
            Console.WriteLine("Model: "+car.model);
        }
    }
}
