using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using challenges2;


namespace challenges2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
           

            while (true)
            {
                 int option = menu();
                if (option == 1)
                {

                    add(students);
                    Console.Read();

                }
                else if (option == 2)
                {
                    show(students);
                    Console.Read();
                }
                else if (option == 3)
                {
                    calulateaggr(students);
                    Console.Read();

                }
                else if (option == 4)
                {
                    top(students);
                    Console.Read();

                }
                else
                {
                    Console.WriteLine("\t\t\t\tInvalid Input!");
                }
            }

        }
      
        static int menu()
        {
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.Show students");
            Console.WriteLine("3.Calculate aggregate");
            Console.WriteLine("4.Top Students");
            Console.WriteLine("");
            Console.WriteLine("Enter your option...");
            int option = int.Parse(Console.ReadLine());
            return option;

        }
        static void add(List<Student> students)
        {
            Console.Write("Enter Student's Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Student's Matric Marks: ");
            float mat = float.Parse(Console.ReadLine());
            Console.Write("Enter Student's Fsc Marks: ");
            float fsc = float.Parse(Console.ReadLine());
            Console.Write("Enter Student's Ecat Marks: ");
            float ecat = float.Parse(Console.ReadLine());
            Student s= new Student(name,mat,fsc,ecat);
            s.aggr = s.aggregate();
            students.Add(s);
        }
        static void show(List<Student> students)
        {

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{students[i].name}");
            }
        }
        static void calulateaggr(List<Student> students)
        {

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{students[i].name}\t\t{students[i].aggr}");
            }
        }
        static void top(List<Student> students)
        {
            students.Sort((student1, student2) => student2.aggr.CompareTo(student1.aggr));\

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{students[i].name}\t\t{students[i].aggr}");
            }
        }
    }
}
