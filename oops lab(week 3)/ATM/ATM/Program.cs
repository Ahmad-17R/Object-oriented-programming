using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM aTM = new ATM();
            while (true)
            {
                int option = menu();
                if (option == 1)
                {
                    aTM.checkbalance();
                }
                else if (option == 2)
                {
                    aTM.withdraw();
                }
                else if (option == 3)
                {
                    aTM.deposit();
                }
                else if (option == 4)
                {
                    aTM.history();
                }
            }

        }
        static int menu()
        {
         
            Console.WriteLine("1.Check balance");
            Console.WriteLine("2.Withdraw Money");
            Console.WriteLine("3.Deposit Money");
            Console.WriteLine("4.Show history");
            Console.WriteLine();
            Console.WriteLine("Enter your option:");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
