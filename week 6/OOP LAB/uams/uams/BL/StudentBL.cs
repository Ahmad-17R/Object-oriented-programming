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

        public List<DegreeProgramBL> Prefrences = new List<DegreeProgramBL>();
        public DegreeProgramBL EnrolledProgram;
        public List<SubjectBL> RegisterdSubject = new List<SubjectBL>();


        public void AssignStudentSubject(SubjectBL subject)
        {
            RegisterdSubject.Add(subject);
        }
    }
}
