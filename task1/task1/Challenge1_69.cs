using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.BL;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MountainBike mybike = new MountainBike(3,3,3,3);

            mybike.setgear(4);
            mybike.setheight(5);
            mybike.setspeed(6);
            mybike.setcadence(7);

            mybike.getattributes();
        }
    }
}
