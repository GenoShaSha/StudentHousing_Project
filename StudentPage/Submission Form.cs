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
    public partial class Submission_Form : Form
    {
        Student submission_student = new Student("name");
        public Submission_Form(Student student)
        {
            InitializeComponent();
            submission_student = student;
        }

       private void EventsBtn_Submission_Click(object sender, EventArgs e)
        {
            if(Events_TB.Text != string.Empty)
            {
                submission_student.SetEvents(Events_TB.Text);
                Events_TB.Clear();
                MessageBox.Show("Your announcement has been posted. Thank you.");
            }
            else
            {
                MessageBox.Show("You need to write something!");
            }
        }

        private void ComplaintsBtn_Submission_Click(object sender, EventArgs e)
        {
            if (Complaints_TB.Text != string.Empty)
            {
                submission_student.SetComplaints(Complaints_TB.Text);
                Complaints_TB.Clear();
                MessageBox.Show("Your complaint has been submitted anonymously. Thank you.");
            }
            else
            {
                MessageBox.Show("You need to write something!");
            }
                
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            StudentPageForm backhome = new StudentPageForm(submission_student);
            backhome.Show();
            this.Hide();
        }
    }
}
