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
    public partial class StudentPageForm : Form
    {
        Student aStudent;
        public StudentPageForm()
        {
            InitializeComponent();
            aStudent = new Student("Toby");

        }

        public StudentPageForm(Student childStudent)
        {
            InitializeComponent();
            aStudent = childStudent;
        }

        private void SubmissionBtn_Click(object sender, EventArgs e)
        {
            Submission_Form new_submit = new Submission_Form(aStudent);
            new_submit.Show();
            this.Hide();
        }

        private void StudentPageForm_Load(object sender, EventArgs e)
        {
            string[] eventvalues = aStudent.ReturnEvents().Split(',');
            string[] complaintvalues = aStudent.ReturnComplaints().Split(',');
            StudentNameLbl.Text = aStudent.ReturnName();
            if (aStudent.ReturnEvents() != string.Empty)
            {
                foreach (string value in eventvalues)
                {
                    if (value != string.Empty)
                    {
                        eventsLB.Items.Add(value + " - " + aStudent.ReturnName());
                    }
                }
                
            }
            if (aStudent.ReturnComplaints() != string.Empty)
            {
                foreach (string value in complaintvalues)
                {
                    complaintsLB.Items.Add(value);
                }
            }
            
        }
    }
}
