using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.BL
{
    internal class MountainBike:Bicycle
    {
        private int seatheight;

        public MountainBike(int seatheight,int cadence ,int speed,int gear)
        {
            this.seatheight = seatheight;
            base.cadence = cadence;
            base.speed = speed;
            base.gear = gear;
        }

        public void setheight(int height)
        {
            seatheight=height;
        }

        public void getattributes()
        {
            Console.WriteLine(seatheight);
            Console.WriteLine(gear);
            Console.WriteLine(speed);
            Console.WriteLine(cadence);
            Console.Read();
        }
    }
}
