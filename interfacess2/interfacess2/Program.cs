using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace interfacess2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            MultipleInheritanceTest obj = new MultipleInheritanceTest();
            obj.Test();
            Interface1 i1 = obj;
            Interface2 i2 = obj;
            i1.Show();
            i2.Show();
        }
    }
    interface Interface1
    {
        void Test();
        void Show();
    }
    interface Interface2
    {
        void Test();
        void Show();
    }
    class MultipleInheritanceTest : Interface1, Interface2
    {
        public void Test()
        {
            Console.WriteLine("interface implemented");
        }
        void Interface1.Show()
        {
            Console.WriteLine("DEclacred in interface 1 and implemented in class");
        }
        void Interface2.Show()
        {
            Console.WriteLine("DEclacred in interface 2 and implemented in class");
        }
    }
}
