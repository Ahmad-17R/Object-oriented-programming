using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS;

namespace POS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction();
            Console.Write("Enter the Transaction ID: ");
            t1.Transactionid=Console.ReadLine();
            Console.Write("Enter the Product Name: ");
            t1.ProductName = Console.ReadLine();
            Console.Write("Enter the Amount: ");
            t1.Amount =float.Parse( Console.ReadLine());
            Console.Write("Enter the Date and time: ");
            t1.Transactionid = Console.ReadLine();

            //using copy constructor
            Transaction t2= new Transaction(t1);
            Console.WriteLine(t2.Transactionid);
            Console.WriteLine(t2.ProductName);
            Console.WriteLine(t2.Amount);
            Console.WriteLine(t2.datentime);
            Console.WriteLine();
            t2.Transactionid = "2222";
            Console.WriteLine(t2.Transactionid);
            Console.Read();
        }
    }
}
