using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticstuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Honda");
            Car car2 = new Car("Hyundai");
            Car car3 = new Car("Tesla");

            Console.WriteLine(Car.numofcars);
            Car.StartRace();
            

        }
    }
    class Car
    {
        String model;
        public static int numofcars;
        public Car(String model) 
        {
            this.model = model;
            numofcars++;
        }
        public static void StartRace()
        {
            Console.WriteLine("race began");
        }
    }
}
