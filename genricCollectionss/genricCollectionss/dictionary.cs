using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genricCollectionss
{
    internal class dictionary
    {
        static void Main()
        {
            Dictionary<string,object> dt = new Dictionary<string,object>();
            dt.Add("eid", 100);
            dt.Add("ename", "scott");
            dt.Add("job", "manager");
            dt.Add("salary", 2500);
            dt.Add("mgrid", 1002);
            dt.Add("phone", "9999999");
            dt.Add("email", "aaa@gmail.com");
            dt.Add("dname", "sales");
            dt.Add("loation", "mumbai");
            dt.Add("did", 30);

            foreach(string  key in dt.Keys)
            {
                Console.WriteLine(key+": " + dt[key]);
            }
            dt
        }
    }
}
