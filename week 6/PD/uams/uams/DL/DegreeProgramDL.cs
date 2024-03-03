using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uams.BL;
namespace uams.DL
{
    internal class DegreeProgramDL
    {
       public static List<DegreeProgramBL> DegreeProgramBLList = new List<DegreeProgramBL>();

        public static DegreeProgramBL IsDegreeExist(string title)
        {
            foreach (DegreeProgramBL degreeProgram in DegreeProgramBLList)
            {
                if (degreeProgram.Title == title)
                { return degreeProgram; }
            }
            return null;
        }
        public static int CalculateCH(List<SubjectBL> Subjects)
        {
            int CH = 0;
            foreach (SubjectBL sub in Subjects)
            {
                CH += sub.CreditHours;  
            
            }
            return CH;
        }

        public static void showdegreeprograms()
        {
            Console.WriteLine("Available Degree Programs");
            foreach (DegreeProgramBL degreeProgram in DegreeProgramBLList)
            {
                Console.Write($"{degreeProgram.Title},");
            }
        }


    }
}
