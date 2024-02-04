using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Student
    {
        public Student()
        {

        }

        public Student(Student student)
        {
            name=student.name;
            matricMarks = student.matricMarks;
            fscMarks = student.fscMarks;
            ecatMarks   = student.ecatMarks;
            aggregate=student.aggregate;

        }

        public string name;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;
    }
}
