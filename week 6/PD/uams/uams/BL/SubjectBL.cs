using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uams.BL
{
    internal class SubjectBL
    {
        public string SubjectCode;
        public int CreditHours;
        public string SubjectType;
        public int SubjectFee;

        public SubjectBL(string code,int credithours,string type,int subjectfee)
        {
            SubjectCode = code;
            CreditHours = credithours;
            SubjectType = type;
            SubjectFee = subjectfee;
        }
        public SubjectBL() { }
    }
}
