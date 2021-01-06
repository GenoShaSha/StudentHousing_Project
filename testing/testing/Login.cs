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
/*        private string loginType;*/

        public Login(string username, string password/*, string loginType*/)
        {
            this.username = username;
            this.password = password;
/*            this.loginType = loginType;*/
        }

        public string CallUsername()
        {
            return this.username;
        }

        public string CallPassword()
        {
            return this.password;
        }

/*        public string CallLoginType()
        {
            return this.loginType;
        }*/

        public bool GetIdentity()
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            string[] lines = System.IO.File.ReadAllLines(path + "Database/Users/Students/IdAndPass.txt");

            foreach (string line in lines)
            {
                string[] steps = line.Split('#');

                Console.WriteLine(steps[0]);
                Console.WriteLine(steps[1]);

                if (this.username == steps[0] && this.password == steps[1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
