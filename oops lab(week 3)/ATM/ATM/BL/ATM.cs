using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class ATM
    {
        public float balance = 50000;
        public List<string> transactionnature = new List<string>();
        public List<float> transactionamount = new List<float>();

        public float amount;
        public void withdraw()
        {
            Console.WriteLine("Enter the amount: ");
            amount=int.Parse(Console.ReadLine());
            balance = balance - amount;
            transactionnature.Add("withdraw");
            transactionamount.Add(amount);
        }
        public void deposit()
        {
            Console.WriteLine("Enter the amount: ");
            amount = int.Parse(Console.ReadLine());
            balance = balance + amount;
            transactionnature.Add("deposit");
            transactionamount.Add(amount);
        }
        public void checkbalance()
        {
            Console.WriteLine($"Account available balance is {balance}");
            //Console.Read ();
        }
        public void history()
        {
            Console.WriteLine("Nature\t\tAmount");
            for (int i = 0; i < transactionnature.Count; i++)
            {
                Console.WriteLine($"{transactionnature[i]}\t\t{transactionamount[i]}");
            }
            Console.Read();
        }
    }
}
