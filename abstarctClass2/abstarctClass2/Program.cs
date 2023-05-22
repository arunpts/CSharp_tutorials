using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstarctClass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbsChild c = new AbsChild();
            c.Add(40, 20);
            c.Sub(40,20);
            c.Mul(40,20);
            c.Div(40, 20);
        }
    }
    abstract class AbsParent
    {
        public void Add(int x, int y) 
        {
            Console.WriteLine(x+y);
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public abstract void Mul(int x, int y);
        public abstract void Div(int x, int y);

    }
    class AbsChild : AbsParent
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x*y);
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine(x/y);
        }
    }
}
