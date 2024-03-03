using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uams.BL
{
    internal class StudentBL
    {
        public string Name;
        public int Age;
        public float EcatMarks;
        public float FscMarks;
        public float Merit;
        public int fee;
        public List<DegreeProgramBL> Prefrences = new List<DegreeProgramBL>();
        public DegreeProgramBL EnrolledProgram;
        public List<SubjectBL> RegisterdSubject = new List<SubjectBL>();


        public void AssignStudentSubject(SubjectBL subject)
        {
            RegisterdSubject.Add(subject);
        }
        public void calculatemerit()
        {
            Merit = ((FscMarks / 1100) * 50) + ((EcatMarks / 400) * 50);
        }

        public int Credithrs()
        {
            int crdhrs = 0;
            for (int i = 0; i < EnrolledProgram.Subjects.Count; i++)
            {
                crdhrs += EnrolledProgram.Subjects[i].CreditHours;
            }
            return crdhrs;
        }
        public int calculatefee()
        {
            int fee = 0;
            for (int i = 0; i < EnrolledProgram.Subjects.Count; i++)
            {
                fee += EnrolledProgram.Subjects[i].SubjectFee;
            }
            return fee;
        }
    }
}
