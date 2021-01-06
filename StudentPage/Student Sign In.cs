using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCB_S04_Grp3_Project_TobiasHalomoan4252861
{
    public class Student_Sign_In
    {
        private string username;
        private string password;

        public Student_Sign_In(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string CallUsername()
        {
                return this.username;
        }

        public string CallPassword()
        {
            return this.password;
        }
    }
}
