using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.BL
{
    internal class Bicycle
    {
        protected int cadence;
        protected int gear;
        protected int speed;

        public void setgear(int gear)
        {
            this.gear = gear;
        }
        public void setcadence(int cadence)
        {
            this.cadence = cadence;
        }
        public void setspeed(int speed)
        {
            this.speed = speed;
        }
        public void applybrake(int decrement)
        {
            speed -= decrement;
        }

       public void applyspeed(int increment)
        {
            speed += increment;
        }

    }
}
