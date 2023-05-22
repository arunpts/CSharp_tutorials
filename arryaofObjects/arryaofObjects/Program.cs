using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arryaofObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Car[] garage = new Car[3];

             Car car1 = new Car("mustang");
             Car car2 = new Car("m5");
             Car car3 = new Car("figo");

             garage[0] = car1;
             garage[1] = car2;
             garage[2] = car3;*/

            Car[] garage = { new Car("mustang"), new Car("m5"), new Car("figo") };

            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);
            }
        }
    }
    class Car
    {
        public String model;
        public Car(String model)
        {
            this.model = model;
        }
    }
}
