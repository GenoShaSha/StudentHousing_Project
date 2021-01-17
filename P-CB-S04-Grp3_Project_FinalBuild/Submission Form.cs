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
        private Student submission_student = new Student("name");
        public Submission_Form(Student student)
        {
            InitializeComponent();
            EventPicker.Value = DateTime.Today;
            submission_student = student;
            submission_student.SetName(student.ReturnName());
        }

       private void EventsBtn_Submission_Click(object sender, EventArgs e)
        {
            if(Events_TB.Text != string.Empty)
            {
                DateTime eventdate = EventPicker.Value;
                string value = submission_student.AddInfo(Events_TB.Text + " (" + eventdate.ToString("dd/MM/yy") + ")" + " - "); 
                submission_student.SetEvents(value);
            }
            Events_TB.Clear();
            EventPicker.Value = DateTime.Today;
            MessageBox.Show("Your announcement has been posted. Thank you.");
        }

        private void ComplaintsBtn_Submission_Click(object sender, EventArgs e)
        {
            if (Complaints_TB.Text != string.Empty)
            {
                submission_student.SetComplaints(Complaints_TB.Text);
            }
            Complaints_TB.Clear();
            MessageBox.Show("Your complaint has been submitted anonymously. Thank you.");
                
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            StudentPageForm backhome = new StudentPageForm(submission_student);
            backhome.Show();
            this.Close();
        }
    }
}
