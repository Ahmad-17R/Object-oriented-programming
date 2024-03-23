using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.BL
{
    internal class Circle
    {
        protected double radius;
        protected string colour;

        public Circle()
        {}
        
        public Circle(double radius)
        {
            this.radius = radius;
        }
        
        public Circle(double radius,string colour)
        {
            this.radius = radius;
            this.colour = colour;
        }

        public double getradius()
        {
            return radius;
        }

        public string getcolour()
        {
            return colour;
        }

        public void setradius(double radius)
        {
            this.radius = radius;
        }

        public void setcolour(string colour)
        {
            this.colour = colour;
        }

        public double getarea()
        {
            double area = 3.14 * (radius*radius);
            return area;
        }

        public string toString()
        {
            string detail = $"Circle[radius={radius},color={colour}]";
            return detail;
        }
    }
}
