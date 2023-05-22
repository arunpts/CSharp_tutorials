using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toStringg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //converts an object to its string representation so that it is suitable for display
            Car car = new Car("chevy","corvette",2022,"blue");
            Console.WriteLine(car);
        }
    }
    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public override string ToString()
        {
            String messgae = "this is a " + make + " " + model;
            return messgae;
        }
    }
}
