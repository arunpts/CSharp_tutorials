using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structuress
{
    internal class Program
    {
        struct MyStruct
        {
            public int i;
            public MyStruct(int i) 
            { 
                this.i = i;
            }
            public void Display()
            {
                Console.WriteLine("method in struct "+i);
            }
        }
        static void Main(string[] args)
        {
            MyStruct m1 = new MyStruct();
            m1.i = 10;
            m1.Display();

            MyStruct m2 = new MyStruct();
            m2.Display();

            MyStruct m3 = new MyStruct(30);
            m3.Display();

            
        }
    }
}
