using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4.BL
{
    internal class Salaryaccount:Account
    {
        public Salaryaccount(string title, string accnumber, double balance) : base(title, accnumber, balance)
        {

        }

        public void addbalance(double increment)
        {
                                  
       balance += increment;
            

        }

        public void subtractbalance(double decrement)
        {
            balance -= decrement;
        }
    }
}
