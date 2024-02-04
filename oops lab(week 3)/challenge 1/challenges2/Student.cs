using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges2
{
    internal class Student
    {
        public Student(string named,float mat,float fsc,float ecat) {
            matricMarks = mat;
            fscMarks = fsc;
            ecatMarks = ecat;
            name=named;
        }
        public string name;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggr;

        public float aggregate()
        {
            float calculate = (ecatMarks / 400) * 30 + (matricMarks / 1100) * 25 + (fscMarks / 1100) * 45;
            return calculate;
        }

    }
}
