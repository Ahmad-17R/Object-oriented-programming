using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.name = "Ahmad";
            s1.matricMarks = 1096;
            s1.fscMarks = 998;
            s1.ecatMarks = 240;

            Student s2 = new Student(s1);
            Console.WriteLine(s2.name);
            s2.name = "Ali";
            Console.Write(s2.name);
            //Console.WriteLine(s1+" "+s2);
            Console.Read();
        }
    }
}
