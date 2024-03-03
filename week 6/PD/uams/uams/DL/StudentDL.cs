using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uams.BL;

namespace uams.DL
{
    internal class StudentDL
    {
        public static List<StudentBL> studentlist = new List<StudentBL>();
        
        public static void generatemeritlist()
        {
            foreach (StudentBL student in studentlist)
            {
                student.calculatemerit();
            }
            studentlist.Sort((x, y) => x.Merit.CompareTo(y.Merit));
            studentlist.Reverse();
        }

        public static void giveseats()
        {
            foreach (StudentBL student in studentlist)
            {

                foreach(DegreeProgramBL degreeprogram in student.Prefrences)
                {
                    if (degreeprogram.AvailabeSeats > 0)
                    {
                        student.EnrolledProgram= degreeprogram;
                        degreeprogram.AvailabeSeats--;
                        break;
                    }
                }
            }

        }

        public static void generatefee()
        {
            foreach(StudentBL student in studentlist)
            {
                if (student.EnrolledProgram != null)
                {
                    foreach (SubjectBL sub in student.RegisterdSubject)
                    {
                        student.fee += sub.SubjectFee;
                    }
                }
            }
            Console.WriteLine("Fee Has been generated for all the students.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
