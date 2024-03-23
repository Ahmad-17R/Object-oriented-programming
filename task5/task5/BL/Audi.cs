using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Audi : Car
    {
        private bool electric;
        private bool selfdriven;

        public Audi(bool electric, bool selfdriven,string model,string color,double price):base(model,color,price)
        {
            this.electric = electric;
            this.selfdriven = selfdriven;
        }

        public string toString()
        {
            string detail = null;
            if (this.electric && this.selfdriven)
            {
                detail = $"Model : {base.model} , Color : {base.color} , Price : {base.price}  which is an electric vehicle and self driven Capability";
            }
            else
            {
                detail = $"Model : {base.model} , Color : {base.color} , Price : {base.price}";
            }
            return detail;
        }
    }

}
