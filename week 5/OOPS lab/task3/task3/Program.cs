using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.BL;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c=new Customer();
            string Cname = "Muhammad Ahmad";
            string Caddress = "Bahawalpur";
            string Cphone = "03043330385";

            string p1name = "Shirt";
            string p1category = "Fashion";
            double p1price = 1100;
            Product p1=new Product(p1name,p1category,p1price);

            string p2name = "shoes";
            string p2category = "Fashion";
            double p2price = 2800;
            Product p2 = new Product(p2name, p2category, p2price);

            c.addproduct(p1);
            c.addproduct(p2);

            Console.WriteLine(c.Customername);
            Console.WriteLine();

            c.getAllproducts();
        }
    }
}
