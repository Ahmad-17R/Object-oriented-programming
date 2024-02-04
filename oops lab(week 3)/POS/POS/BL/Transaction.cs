using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    internal class Transaction
    {
        public Transaction() { 
        
        }
        public Transaction(Transaction transaction)
        {
         Transactionid=transaction.Transactionid;
         ProductName=transaction.ProductName;
        Amount = transaction.Amount;
         datentime = transaction.datentime;
    }
        public string Transactionid;
        public string ProductName;
        public float Amount;
        public string datentime;
    }
}
