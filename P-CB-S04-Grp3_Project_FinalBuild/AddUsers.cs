using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCB_S04_Grp3_Project_TobiasHalomoan4252861
{
    public partial class AddUsers : Form
    {
        public AddUsers()
        {
            InitializeComponent();
            this.cbUserType.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string userType = cbUserType.SelectedItem.ToString();

            if (username == string.Empty)
            {
                MessageBox.Show("Please input Username!");
            }
            else if (password == string.Empty)
            {
                MessageBox.Show("Please input Password!");
            }
            else
            {
                Login login = new Login(username, password, userType);

                bool addUser = login.AddUsers();

                if (addUser == true)
                {
                    MessageBox.Show("Success Add");
                }
                else
                {
                    MessageBox.Show("Fail to Add");
                }
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                cbUserType.SelectedIndex = 0;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cbUserType.SelectedIndex = 0;
        }

        private void btnRmv_Click(object sender, EventArgs e)
        {
            string newUsr = tbxRmv.Text;
            string usrType = cbxUsers.SelectedItem.ToString();

            if (newUsr == string.Empty)
            {
                MessageBox.Show("Please input Username!");
            }
            else
            {
                Login login = new Login(newUsr, string.Empty, usrType);
                bool rmvUsers = login.RemoveUsers();
                if (rmvUsers == true)
                {
                    MessageBox.Show("The user has been removed!");
                }
                else
                {
                    MessageBox.Show("Nothing happened!");
                }
                tbxRmv.Text = string.Empty;
                cbxUsers.SelectedIndex = 0;
            }
        }
    }
}
