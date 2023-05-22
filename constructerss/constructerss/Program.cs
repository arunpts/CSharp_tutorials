using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructerss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("ford","mustang",2022,"red");
            car1.Drive();
            Car car2 = new Car("Chevy", "corvette", 2022, "yellow");
            car2.Drive();


            Console.ReadKey();
        }
    }

    class Car
    {
        string make;
        string model;
        int year;
        string color;

        public Car (string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public void Drive()
        {
            Console.WriteLine("you drive the "+make+" "+model);
        }
    }
}
