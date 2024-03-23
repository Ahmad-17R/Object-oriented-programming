using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4.BL
{
    internal class Studentaccount : Account
    {
        public Studentaccount(string title,string accnumber,double balance):base(title, accnumber, balance)
        { 
        
        }

        public void addbalance(double increment)
        {
            if(balance+increment > 500000) {
                Console.WriteLine("Balance limit exceeded");
                Console.Read();
            }
            else
            {
                balance += increment;
            }
            
        }

        public void subtractbalance(double decrement)
        {
            balance -= decrement;
        }
    }
}
