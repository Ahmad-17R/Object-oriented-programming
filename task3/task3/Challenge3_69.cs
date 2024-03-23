using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std=new Student("Ahmad","Bwp","CS",2023,60000);
            Console.WriteLine(std.getname());
            Console.WriteLine(std.getaddress());
            Console.WriteLine(std.getProgram());
            Console.WriteLine(std.getYear());
            Console.WriteLine(std.getfee());
            Console.WriteLine();
            std.setaddress("LHR");
            std.setProgram("CE");
            std.setyear(2022);
            std.setfee(70000);
            Console.WriteLine();
            Console.WriteLine(std.getname());
            Console.WriteLine(std.getaddress());
            Console.WriteLine(std.getProgram());
            Console.WriteLine(std.getYear());
            Console.WriteLine(std.getfee());
            Console.Read();

        }
    }
}
