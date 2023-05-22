using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //auto resizing
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity);
            al.Add(100);
            Console.WriteLine(al.Capacity);
            al.Add(200);al.Add(300);al.Add(400);
            Console.WriteLine(al.Capacity);
            al.Add(500);
            Console.WriteLine(al.Capacity);
            foreach(int i in al)
                Console.Write(i + " ");
            Console.WriteLine();
            //insert
            al.Insert(3, 350);
            foreach (int i in al)
                Console.Write(i + " ");
            //remove
            Console.WriteLine();
            al.Remove(200);
            foreach (int i in al)
                Console.Write(i + " ");

            Console.ReadLine();

        }
    }
}
