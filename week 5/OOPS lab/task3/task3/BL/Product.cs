using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Product
    {
     
        public Product(string name,string category,double price) {
            this.name = name;
            this.category = category;
            this.price = price;
        }

        public string name;
        public string category;
        public double price;

        public double calculateTax()
        {
            double tax = (price * 0.1);
            return tax;
        }


    }
}
