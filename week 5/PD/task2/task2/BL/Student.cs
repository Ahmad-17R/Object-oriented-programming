using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Student
    {
        public Student(string name,int rollno,int marks) { 
            this.name=name;
            this.rollno=rollno;
            this.marks=marks;  
        }
        public string name;
        public int rollno;
        public int marks;
    }
}
