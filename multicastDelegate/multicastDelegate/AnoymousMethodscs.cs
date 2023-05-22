using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multicastDelegate
{
    public delegate string greetingsDelegate(string name);
    internal class AnoymousMethodscs
    {
        /*public static string Greetings(string name)
        {
            return "hello " + name;
        }*/

        static void Main()
        {
            /* AnoymousMethodscs am=new AnoymousMethodscs();
             greetingsDelegate gd  =new greetingsDelegate(AnoymousMethodscs.Greetings);*/
            greetingsDelegate gd = delegate(string name)
            {
                return "hello " + name;
            };
            string str=gd.Invoke("arun");
            Console.WriteLine(str);
        }
    }
    
}
