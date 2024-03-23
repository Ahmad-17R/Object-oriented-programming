using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.BL
{
    internal class Cylinder:Circle
    {
        private double height=1;

        public Cylinder() { }

        public Cylinder(double radius)
        {
            base.radius = radius;
        }

        public Cylinder(double radius,double height):base(radius)
        {
           
            this.height = height;   

        }
        public Cylinder(double radius, double height, string colour):base(radius,colour)
        {
           
            this.height = height;
           
        }

        public double getheight()
        {
            return height;
        }
        public void setheight(double height)
        {
            this.height = height;
        }

        public double getvolume()
        {
            double volume = getarea() * height;
            return volume;
        }
    }
}
