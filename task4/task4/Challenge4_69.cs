using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.BL;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Studentaccount std = new Studentaccount("Student Account","1234",50000);

            Console.WriteLine(std.gettitle());
            Console.WriteLine(std.getaccnumber());
            Console.WriteLine(std.getbalance());
            Console.WriteLine();

            std.addbalance(50000);
            Console.WriteLine(std.getbalance());
            std.addbalance(500000);
            Console.WriteLine(std.getbalance());
            Console.Read();

            Savingaccount personacc = new Savingaccount("Saving Account", "1233", 40000);
            Console.WriteLine(personacc.gettitle());
            Console.WriteLine(personacc.getaccnumber());
            Console.WriteLine(personacc.getbalance());
            Console.WriteLine();

            std.addbalance(50000);
            Console.WriteLine(personacc.getbalance());
            
            Console.Read();

        }
    }
}
