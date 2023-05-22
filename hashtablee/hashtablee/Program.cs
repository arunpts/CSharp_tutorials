using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtablee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("eid",100);
            ht.Add("ename","scott");
            ht.Add("job","manager");
            ht.Add("salary",2500);
            ht.Add("mgrid",1002);
            ht.Add("phone","9999999");
            ht.Add("email","aaa@gmail.com");
            ht.Add("dname","sales");
            ht.Add("loation","mumbai");
            ht.Add("did",30);
            
            //will create hashcode thats why it wont print 
            foreach(string s in ht.Keys)
                Console.WriteLine(s+": " + ht[s]);
            
            //count
            Console.WriteLine(ht.Count);
        }
    }
}
