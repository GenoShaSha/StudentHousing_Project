using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCB_S04_Grp3_Project_TobiasHalomoan4252861
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

        public bool RemoveUsers()
        {
            string paths = System.AppDomain.CurrentDomain.BaseDirectory;
            string databasePath;

            if (this.loginType == "Student")
            {
                databasePath = "Database/Users/Students/IdAndPass.txt";
            }
            else
            {
                databasePath = "Database/Users/Tenants/IdAndPass(Tenant).txt";
            }

            string[] lines = System.IO.File.ReadAllLines(@paths + databasePath);

            var lineToList = lines.ToList();
            string flag = "DontRemove";

            for (int i = lineToList.Count - 1; i > -1; i--)
            {
                string[] line = lineToList[i].Split('#');
                if (line[0] == this.username)
                {
                    lineToList.RemoveAt(i);
                    flag = "Remove";
                    break;
                }
            }
            if (flag == "Remove")
            {
                using (StreamWriter writer = new StreamWriter(@paths + databasePath))
                {
                    int counter = 0;
                    foreach (string s in lineToList)
                    {
                        counter++;
                        if (counter == lineToList.Count())
                        {
                            writer.Write(s);
                        }
                        else
                        {
                            writer.WriteLine(s);
                        }
                        Console.WriteLine(s);
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddUsers()
        {
            string paths = System.AppDomain.CurrentDomain.BaseDirectory;
            string databasePath;

            if (this.loginType == "Student")
            {
                databasePath = "Database/Users/Students/IdAndPass.txt";
            }
            else
            {
                databasePath = "Database/Users/Tenants/IdAndPass(Tenant).txt";
            }

            string[] lines = System.IO.File.ReadAllLines(@paths + databasePath);

            var lineToList = lines.ToList();
            string flag = "Add";

            foreach (string s in lineToList)
            {
                string[] line = s.Split('#');

                if (line[0] == this.username)
                {
                    flag = "Reject";
                    break;
                }
            }

            if (flag == "Add")
            {
                string formattedUsers = this.username + "#" + this.password;

                lineToList.Add(formattedUsers);

                using (StreamWriter writer = new StreamWriter(@paths + databasePath))
                {
                    int counter = 0;
                    foreach (string s in lineToList)
                    {
                        counter++;
                        if (counter == lineToList.Count())
                        {
                            writer.Write(s);
                        }
                        else
                        {
                            writer.WriteLine(s);
                        }
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

