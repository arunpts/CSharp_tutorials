using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multicastDelegate
{
    internal class lambdaexp
    {
        
        static void Main()
        {
            greetingsDelegate gd = (name)=>
            {
                return "hello " + name;
            };
            string str=gd.Invoke("arun");
            Console.WriteLine(str);
        }
    }
}
