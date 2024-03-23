using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4.BL
{
    internal class Account
    {
        protected string title;
        protected string accnumber;
        protected double balance;

        public Account(string title, string accnumber, double balance)
        {
            this.title = title;
            this.accnumber = accnumber;
            this.balance = balance;
        }

        public string gettitle()
        {
            return title;
        }

        public string getaccnumber()
        {
            return accnumber;
        }

        public double getbalance()
        {
            return balance;
        }


        public string toString()
        {
            string detail = $"Account Title:{title},Account Number:{accnumber},Account Available Balance:{balance}";
            return detail;
        }
    }
}
