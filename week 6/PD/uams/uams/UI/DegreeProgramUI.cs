using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uams.BL;
using uams.DL;

namespace uams.UI
{
    internal class DegreeProgramUI
    {
        public static void GetDegreeFromUser()
        {
            DegreeProgramBL degreeProgram = new DegreeProgramBL();
            Console.WriteLine("Enter degree title");
            degreeProgram.Title = Console.ReadLine();
            Console.WriteLine("Enter Duration ");
            degreeProgram.Duration = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter the number of seats in this degree");
            degreeProgram.AvailabeSeats = int.Parse(Console.ReadLine());

            Console.WriteLine("How many subjects you have in this degree");
            int subjectscount = int.Parse(Console.ReadLine());
            List<SubjectBL> subjects = new List<SubjectBL>();
            for (int i = 0; i < subjectscount; i++)
            {
                //you can add condition if the subject is already in the subject
                //list do not add that subject
                subjects.Add(GetSubjectsFromUser());
            }

            degreeProgram.Subjects = subjects;

            DL.DegreeProgramDL.DegreeProgramBLList.Add(degreeProgram);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static SubjectBL GetSubjectsFromUser()
        {
            SubjectBL subject = new SubjectBL();
            Console.WriteLine("Enter Subject Code ");
            subject.SubjectCode = Console.ReadLine();
            Console.WriteLine("Enter Subject Credit Hours");
            subject.CreditHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fee for the subject ");
            subject.SubjectFee = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Type of the subject");
            subject.SubjectType = Console.ReadLine();
            return subject;
        }

    
    }
}
