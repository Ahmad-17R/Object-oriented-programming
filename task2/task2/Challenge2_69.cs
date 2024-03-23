using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.BL;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder(3,3,"red");

            Console.WriteLine(cylinder.toString());
            Console.WriteLine(cylinder.getarea());
            Console.WriteLine(cylinder.getvolume());
            cylinder.setcolour("green");
            cylinder.setradius(5);
            cylinder.setheight(5);
            Console.WriteLine(cylinder.toString());
            Console.WriteLine(cylinder.getarea());
            Console.WriteLine(cylinder.getvolume());
            Console.Read();
        }
    }
}
