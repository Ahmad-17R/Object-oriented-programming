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
            Student student = new Student();
            student.name = "Muhammad Ahmad";
            student.cgpa = 3.51;
            student.isHostelite = true;
            student.matricMarks = 1096;
            student.fscMarks = 998;
            student.ecatMarks =240;
            student.rollno = "2023-CS-69";
            student.hometown = "Bahawalpur";

            double studentmerit = student.calculateMerit(student.matricMarks, student.fscMarks, student.ecatMarks);
            if(student.isEligibleforScholarship(studentmerit,student.isHostelite))
            {
                Console.WriteLine($"The student merit is {studentmerit}");
                Console.WriteLine("The student is  a hostelite");
                Console.WriteLine("The student is eligible for scholarship");
                Console.Read();
            }
            else
            {
                Console.WriteLine($"The student merit is {studentmerit}");
                Console.WriteLine("The student is not  a hostelite");
                Console.WriteLine("The student is not eligible for scholarship");
                Console.Read();
            }
        }
    }
}
