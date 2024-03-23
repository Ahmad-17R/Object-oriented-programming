using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class GLI:Car
    {
        private bool hybrid;
        private bool regenerativebraking;

        public GLI(bool hybrid, bool regenerativebraking, string model, string color, double price) : base(model, color, price)
        {
            this.hybrid = hybrid;
            this.regenerativebraking = regenerativebraking;
        }

        public string toString()
        {
            string detail = null;
            if (this.hybrid && this.regenerativebraking)
            {
                 detail = $"Model : {base.model} , Color : {base.color} , Price : {base.price}  with Regenerative Braking System and Hybrid Capability";
            }
            else
            { 
                 detail = $"Model : {base.model} , Color : {base.color} , Price : {base.price}";
            }
            return detail;
        }
    }
}
