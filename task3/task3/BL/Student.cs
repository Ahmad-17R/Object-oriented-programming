using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Student:Person
    {
        private string program;
        private int year;
        private double fee;

        public Student(string name,string address,string program,int year,double fee):base(name,address)
        {
            this.program = program;
            this.year = year;   
            this.fee = fee;
        }

        public string getProgram()
        {
            return program;
        }

        public int getYear()
        {
            return year;
        }

        public double getfee()
        {
            return fee;
        }

        public void setProgram(string program)
        {
            this.program=program;
        }


        public void setfee(double fee)
        {
            this.fee = fee;
        }

        public void setyear(int year)
        {
            this.year = year;
        }
    }
}
