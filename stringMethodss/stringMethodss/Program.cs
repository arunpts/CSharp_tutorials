using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringMethodss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fname = "Arun ";
            string lname = "Prakash";
            Console.WriteLine("First name: {0}\nLast name: {1}",fname,lname);

            string name = string.Concat(fname,lname);
            Console.WriteLine("Concatenate: "+name);
           
            Console.WriteLine("Compare: "+ string.Compare(fname,lname));
            Console.WriteLine("CompareTo: "+ fname.CompareTo(lname));

            Console.WriteLine("Contains: " + name.Contains(fname));

            string name2 = string.Copy(name);
            Console.WriteLine("Copy: "+ name2);

            Console.WriteLine("Equals: "+ name.Equals(name2));

            Console.WriteLine("GetType: "+name.GetType());

            Console.WriteLine("indexOf: "+ name.IndexOf('k'));

            Console.WriteLine("Insert: "+ name2.Insert(8,"--"));

            string[] s1 = { "hello", "i", "am", "arun!!" };
            Console.WriteLine("Join: "+ string.Join("-",s1));

            Console.WriteLine("Remove: "+ name2.Remove(3,5));

            Console.WriteLine("Replace: "+ name.Replace('h','H'));

            Console.WriteLine("Substring: "+name.Substring(0,6));

            Console.WriteLine("ToLower: "+lname.ToLower());
            Console.WriteLine("ToUpper: "+lname.ToUpper());


        }   


    }
}
