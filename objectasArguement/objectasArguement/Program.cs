using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectasArguement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("mustang", "Red");
        }
        public static void Changecolor(Car car)
    }
    class Car
    {
        public String model;
        public String color;
        public Car(String model, String color) 
        { 
            this.model = model;
            this.color = color;
        }
    }
}
