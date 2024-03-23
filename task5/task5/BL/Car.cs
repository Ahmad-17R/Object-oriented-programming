using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Car
    {
        protected string model;
        protected string color;
        protected double price;


        public string getmodel()
        {
            return model;
        }

        public void setmodel(string model)
        {
            this.model = model;
        }

        public string getcolor()
        {
            return color;
        }

        public void setcolor(string color)
        {
            this.color = color;
        }

        public double getprice()
        {
            return this.price;
        }

        public void setprice(double price)
        {
            this.price = price;
        }
        public Car() { }
       public Car(string model,string color,double price)
        {
            this.model = model;
            this.color = color;
            this.price = price;
        }
    }

}
