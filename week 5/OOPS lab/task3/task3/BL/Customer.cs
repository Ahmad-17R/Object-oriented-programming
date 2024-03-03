using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.BL
{
    internal class Customer
    {
       public string Customername;
       public string Customeraddress;
       public string Customercontact;
        public List<Product> prodlist = new List<Product>();
        public void getAllproducts()
        {
            for(int i = 0; i < prodlist.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{prodlist[i].name}");
            }
            Console.Read();
        }
        public void addproduct(Product p)
        {
            prodlist.Add(p);
        }
    }
}
