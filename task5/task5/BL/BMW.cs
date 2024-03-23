using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class BMW:Car
    {
        private bool bulletproof;
        private bool iDrivesystem;

        public BMW(bool bulletproof, bool iDrivesystem, string model, string color, double price) : base(model, color, price)
        {
            this.bulletproof = bulletproof;
            this.iDrivesystem = iDrivesystem;
        }

        public string toString()
        {
            string detail = null;
            if (this.bulletproof && this.iDrivesystem)
            {
                detail = $"Model : {base.model} , Color : {base.color} , Price : {base.price}  with iDrive System and Bulletproof Capability";
            }
            else
            {
                detail = $"Model : {base.model} , Color : {base.color} , Price : {base.price}";
            }
            return detail;
        }
    }
}
