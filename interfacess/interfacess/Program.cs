using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ImplementationClass obj = new ImplementationClass();
            obj.Add(10, 20);
            obj.Sub(20,10);
        }
    }
    interface ITestinterface1
    {
        void Add(int a, int b);
    }
    interface ITestinterface2 : ITestinterface1
    {
        void Sub(int a, int b);
    }
    class ImplementationClass :  ITestinterface2
    {
        public void Add(int a, int b) //void ITestinterface1.Add(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a-b);
        }
    }
}
