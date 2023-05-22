using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace genricCollectionss
{
    public class Customer
    {
        public int Custid { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Balance { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> Customers = new List<Customer>();
            Customer c1 = new Customer { Custid=101,Name="arun",City="kochi",Balance=1000 };
            Customer c2 = new Customer { Custid=102,Name="john",City="chennai",Balance=5000 };
            Customer c3 = new Customer { Custid=103,Name="doe",City="pune",Balance=2000 };
            Customer c4 = new Customer { Custid=104,Name="smith",City="delhi",Balance=1500 };

            Customers.Add(c1);Customers.Add(c2);
            Customers.Add(c3);Customers.Add(c4);

            foreach (Customer cs in Customers)
            {
                Console.WriteLine(cs.Custid+" "+cs.Name+" "+cs.City+" "+cs.Balance);
            }


           /* //List
            List<int> li = new List<int>();
            li.Add(1);li.Add(2);li.Add(3);
            li.Add(4);li.Add(5);

            for(int i=0;i<li.Count;i++)
                Console.Write(li[i]+" ");
            Console.WriteLine();
            li.Insert(3, 35);
            foreach (int i in li)
                Console.Write(i+" ");
            
            Console.WriteLine();
            li.Remove(1);
            foreach (int i in li)
                Console.Write(i + " ");*/
        }
    }
}
