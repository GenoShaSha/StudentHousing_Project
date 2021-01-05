using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace testing
{
    class Login
    {
        private string username;
        private string password;

        public Login(string username, string password)
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
        public bool GetIdentity()
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            string[] lines = System.IO.File.ReadAllLines(path + "Database/Users/Students/IdAndPass.txt");
            foreach (string line in lines)
            {
                string[] steps = line.Split('#');
                if (this.username == steps[0] && this.password == steps[1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
