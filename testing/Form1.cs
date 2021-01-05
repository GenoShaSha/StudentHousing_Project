using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing
{
    public partial class Form1 : Form
    {
        Login newLogin;
        public Form1()
        {
            InitializeComponent();
            newLogin = new Login("username", "password");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(newLogin.GetIdentity() == true)
            {
                MessageBox.Show("Ur in!");
            }
            else if(newLogin.GetIdentity() == false)
            {
                MessageBox.Show("Put the right username or password!");
            }
        }
    }
}
