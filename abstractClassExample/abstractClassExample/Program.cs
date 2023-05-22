using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 20);
            Circle c = new Circle(5);
            Cone co = new Cone(5, 10);

            Console.WriteLine("Rectangle Area: "+r.GetArea());
            Console.WriteLine("Circle Area: "+c.GetArea());
            Console.WriteLine("Cone Area: "+co.GetArea());
        }
    }
    abstract class Figure //parent class   abstarct used so others cant change anything in this class
    {
        public double width, height, radius;
        public const float Pi= 3.14f;

        public abstract double GetArea();

    }
    class Rectangle : Figure
    {
        public Rectangle(double width ,double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double GetArea()
        {
            return width * height;
        }
    }
    class Circle : Figure
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return Pi * radius * radius;
        }
    }
    class Cone : Figure
    {
        public Cone(double radius,double height)
        {
            this.radius = radius;
            this.height = height;
        }
        public override double GetArea()
        {
            return Pi * radius * (radius + Math.Sqrt(height*height+radius*radius));
        }
    }
}
