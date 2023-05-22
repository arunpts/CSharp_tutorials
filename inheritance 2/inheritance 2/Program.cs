using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_2
{
    class Vehicle
    {
        public int speed = 0;
        public void go()
        {
            Console.WriteLine("this behicle is moviing");
        }
    }
    class Car : Vehicle
    {
        public int wheels = 4;
    }
    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle b = new Bicycle();
            Boat boat = new Boat();

            Console.WriteLine(car.wheels);
            Console.WriteLine(car.speed);
            car.go();
            Console.WriteLine(b.wheels);
            Console.WriteLine(b.speed);
            b.go();
            Console.WriteLine(boat.wheels);
            Console.WriteLine(boat.speed);
            boat.go();



            Console.ReadKey();
        }
    }
}
