using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatess
{
    //define dele
    public delegate void AddDelegate(int x, int y);
    public delegate string sayDelegate(string str);
    internal class Program
    {
        public void Addnum(int a , int b)
        {
            Console.WriteLine(a+b);
        }
        public static string sayHello(string name)
        {
            return "Hello " + name;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            /* p.Addnum(100, 20);
             string str = Program.sayHello("arun");*/
            AddDelegate ad = new AddDelegate(p.Addnum);
            ad(100, 50);
            ad.Invoke(100, 50);
            sayDelegate sd = new sayDelegate(Program.sayHello);//(sayHello)
            //string str = sd("Arun");
            string str = sd.Invoke("arun");

            Console.WriteLine(str);
        }
    }
}
