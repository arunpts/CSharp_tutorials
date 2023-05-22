using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multicastDelegate
{
    public delegate void RectDelegate(double width,double height);
    internal class Rectangle
    {
        public void GetArea(double width,double height)
        {
            Console.WriteLine("Areaa: "+ width*height);
        }
        public void GetPerimeter(double width,double height)
        {
            Console.WriteLine("Perimeter: "+ 2*(width+height));
        }
        static void Main()
        {
            Rectangle rect = new Rectangle();
            /*rect.GetArea(4, 5);
            rect.GetPerimeter(4, 5);*/
            RectDelegate rd = new RectDelegate(rect.GetArea); //holding reference of two methods
            rd += rect.GetPerimeter;

            rd.Invoke(4, 5);

            rd.Invoke(10, 5);
        }
    }
}
