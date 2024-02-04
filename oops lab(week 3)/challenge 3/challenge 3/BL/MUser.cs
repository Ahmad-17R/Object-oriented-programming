using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_3
{
    internal class MUser
    {
        public MUser(string ename, string epassword)
        {
            name = ename;
            password = epassword;
        }

        public MUser(string ename, string epassword, string erole)
        {
            name = ename;
            password = epassword;
            role = erole;
        }

        public string name;
        public string password;
        public string role;

        

        public bool checkspell()
        {
            if (role == "Admin" || role == "admin")
            {
                return true;
            }
            return false;
        }
    }
}
