using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uams.BL
{
    internal class DegreeProgramBL
    {
        public string Title;
        public int Duration;
        public int AvailabeSeats;

        public List<SubjectBL> Subjects;
    }
}
