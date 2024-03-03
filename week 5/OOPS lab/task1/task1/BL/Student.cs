using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Student
    {
        public string name;
        public string rollno;
        public double cgpa;
        public double matricMarks;
        public double fscMarks;
        public double ecatMarks;
        public string hometown;
        public bool isHostelite;
        public bool isTakingScholarship;

        public double calculateMerit( double matricMarks,double fscMarks ,double ecatMarks)
        {
            double merit;
            merit = ((matricMarks / 1100) * 25) + ((fscMarks / 1100) * 45) + ((ecatMarks / 400) * 30);
            return merit;
        }
        public bool isEligibleforScholarship(double studentmerit,bool isHostelites)
        {
          
            if (studentmerit>80 && isHostelites==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
