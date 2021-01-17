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
    public partial class LoginPage : Form
    {
        Login newLogin;
        Student aStudent;
        Tenant aTenant;

        public LoginPage()
        {
            InitializeComponent();
            aStudent = new Student();
            aTenant = new Tenant();
            
        }

        public LoginPage(Student student)
        {
            InitializeComponent();
            aStudent = student;
        }

        public LoginPage(Tenant tenant)
        {
            InitializeComponent();
            aTenant = tenant;
        }

        public LoginPage(Student student, Tenant tenant)
        {
            InitializeComponent();
            aStudent = student;
            aTenant = tenant;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string newUsr = tbxUsr.Text;
            string newPass = tbxPass.Text;
            string lgnType = string.Empty;

            if (rbAdmin.Checked == true)
            {
                lgnType = "Admin";
            }
            else
            {
                lgnType = "Student";
            }

            newLogin = new Login(newUsr, newPass, lgnType);

            if (newLogin.GetIdentity() == true)
            {
                if (rbStudents.Checked)
                {
                    MessageBox.Show("Login successful");
                    if(aTenant == null)
                    {
                        aStudent.SetName(newLogin.CallUsername());
                        StudentPageForm student = new StudentPageForm(aStudent);
                        student.Show();
                    }
                    else
                    {
                        aTenant.SetName(newLogin.CallUsername());
                        StudentPageForm student = new StudentPageForm(aTenant);
                        student.Show();
                    }
                    
                    
                    this.WindowState = FormWindowState.Minimized;
                    this.ShowInTaskbar = false;
                }
                else if (rbAdmin.Checked)
                {
                    MessageBox.Show("Login successful");
                    TenantForm tenant = new TenantForm(aStudent);
                    tenant.Show();
                    this.WindowState = FormWindowState.Minimized;
                    this.ShowInTaskbar = false;
                }

            }
            else if (newLogin.GetIdentity() == false)
            {
                MessageBox.Show("Put the right username or password!");
            }
            tbxUsr.Text = string.Empty;
            tbxPass.Text = string.Empty;
        }
    }
}
