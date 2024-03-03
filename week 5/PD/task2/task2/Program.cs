using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1=new Student("Ahmad",69,240);
            Student s2 = new Student("Hannan", 85, 221);
            Student s3 = new Student("Furqan", 88, 210);
            List<Student> slist = new List<Student>() { s1,s2,s3};
            List<Student> sortedlist=slist.OrderBy(o=>o.name).ToList();
            Console.WriteLine("Name\t Rollno \t Ecat Marks");
            foreach(Student s in sortedlist)
            {
                Console.WriteLine($"{s.name}\t{s.rollno}\t{s.marks}");
            }
            Console.ReadKey();
        }
    }
}
