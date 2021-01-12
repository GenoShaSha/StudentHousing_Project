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
        private string loginType;

        public Login(string username, string password, string loginType)
        {
            this.username = username;
            this.password = password;
            this.loginType = loginType;
        }

        public string CallUsername()
        {
            return this.username;
        }

        public string CallPassword()
        {
            return this.password;
        }

        public string CallLoginType()
        {
            return this.loginType;
        }

        public bool GetIdentity()
        {
            if (this.loginType == "Student")
            {
                string path = System.AppDomain.CurrentDomain.BaseDirectory;
                string[] lines = System.IO.File.ReadAllLines(@path + "Database/Users/Students/IdAndPass.txt");

                foreach (string line in lines)
                {
                    string[] steps = line.Split('#');
                    if (this.username == steps[0] && this.password == steps[1])
                    {
                        return true;
                    }
                }
            }
            else if (this.loginType == "Admin")
            {
                string paths = System.AppDomain.CurrentDomain.BaseDirectory;
                string[] ndLines = System.IO.File.ReadAllLines(@paths + "Database/Users/Tenants/IdAndPass(Tenant).txt");

                foreach (string line in ndLines)
                {
                    string[] step = line.Split('#');
                    if (this.username == step[0] && this.password == step[1])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
