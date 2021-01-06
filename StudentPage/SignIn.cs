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
    public partial class form1 : Form
    {
        List<Student_Sign_In> SignIn;
/*        string usr = "Room2803";
        string pass = "280320200923";*/

        public form1()
        {
            InitializeComponent();
            SignIn = new List<Student_Sign_In>();

            SignIn.Add(new Student_Sign_In("Room2803", "280320200923"));
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxUsr.Text == "Room2803" && tbxPass.Text == "280320200923")
            {
/*                SignIn.CallUsername();
                SignIn.CallPassword();*/
                StudentPageForm newStudent = new StudentPageForm(SignIn);
                newStudent.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Put the right Username or Password");
            }

        }
    }
}
