using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uams.BL;
using uams.DL;

namespace uams.UI
{
    internal class StudentUI
    {
       
        public static void AddStudent()
        {
            StudentBL student = new StudentBL();
            Console.Write("Enter Student Name: ");
            student.Name = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            student.Age=int.Parse(Console.ReadLine());
            Console.Write("Enter Student Fsc Marks: ");
            student.FscMarks=float.Parse(Console.ReadLine());
            Console.Write("Enter Student Fsc Marks: ");
            float EcatMarks = float.Parse(Console.ReadLine());
            DL.StudentDL.studentlist.Add(student);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
        public static void addpref(StudentBL student) {
            Console.Write("How many preferences you want to enter: ");
            int count=int.Parse(Console.ReadLine());
            for (int i=0;i<count;i++)
            {
                Console.Write("Enter the name of the Degree Program");
                string ans= Console.ReadLine();
                DegreeProgramBL program=DegreeProgramDL.IsDegreeExist(ans);
                if (program!=null) 
                {
                    student.Prefrences.Add(program);    
                }

            }
        }

        public static void GenerateMerit()
        {
            DL.StudentDL.generatemeritlist();
            DL.StudentDL.giveseats();
            foreach (StudentBL student in DL.StudentDL.studentlist)
            {
                if (student.EnrolledProgram!=null)
                {
                    Console.WriteLine($"{student.Name} got Admission in {student.EnrolledProgram.Title}.");
                }
                else
                {
                    Console.WriteLine($"{student.Name} did not get Admission.");
                }
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static void RegisteredStudents()
        { 
            Console.WriteLine("Student\tFscMarks\tEcatMarks\tAge.");
            foreach (StudentBL student in DL.StudentDL.studentlist)
            {
                if (student.EnrolledProgram != null)
                {
                    Console.WriteLine($"{student.Name}\t{student.FscMarks}\t{student.EcatMarks}\t{student.Age}.");
                }
       
            }
            Console.ReadKey();
        }

        public static void RegisteredStudentsspecific()
        {
            Console.WriteLine("Enter the name of the Degree Program:");
            string degree=Console.ReadLine();
            Console.WriteLine("Student\tFscMarks\tEcatMarks\tAge.");
            foreach (StudentBL student in DL.StudentDL.studentlist)
            {
                if (student.EnrolledProgram.Title == degree)
                {
                    Console.WriteLine($"{student.Name}\t{student.FscMarks}\t{student.EcatMarks}\t{student.Age}.");
                }
                else
                {
                    continue;
                }

            }
            Console.ReadKey();
        }
        public static void showsubjects()
        {
            StudentBL thisstudent=null;
            Console.WriteLine("Enter the name of the Student: ");
            string name = Console.ReadLine();
            foreach (StudentBL student in DL.StudentDL.studentlist)
            {
                if (student.Name == name)
                {
                    thisstudent = student;
                    Console.WriteLine("Following are the Subject Codes: ");
                     foreach (SubjectBL subject in student.EnrolledProgram.Subjects)
                     {
                     Console.WriteLine(subject.SubjectCode);
                     }


                }
            }
            Console.WriteLine("Enter the Subject Code");
            string code = Console.ReadLine();

             Console.WriteLine("Following are the Subject Codes: ");
            foreach (SubjectBL subject in thisstudent.EnrolledProgram.Subjects)
            {
                if (code == subject.SubjectCode)
                {
                    thisstudent.AssignStudentSubject(subject);
                }
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

}
