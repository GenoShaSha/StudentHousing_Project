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
        Tenant aTenant;
        public StudentPageForm()
        {
            
            InitializeComponent();
            aStudent = new Student("Toby");

        }

        public StudentPageForm(Student childStudent)
        {
            InitializeComponent();
            aStudent = childStudent;
            UpdateForm();
        }

        public StudentPageForm(Tenant tenant)
        {
            InitializeComponent();
            aStudent = new Student("Toby");
            aTenant = tenant;
            AddTenantData();
            UpdateForm();
        }

        private void AddTenantData()
        {
            string[] RuleValues = aTenant.ReturnRules().Split('\n');
            string[] EventValues = aTenant.ReturnEvents().Split('\n');
            string[] ComplaintValues = aTenant.ReturnComplaints().Split('\n');

            if (aTenant.ReturnRules() != string.Empty)
            {
                foreach (string Rule in RuleValues)
                {
                    if (Rule != string.Empty)
                    {
                        aStudent.SetRules(Rule);
                    }
                }
            }
            if (aTenant.ReturnEvents() != string.Empty)
            {
                foreach (string Event in EventValues)
                {
                    if (Event != string.Empty)
                    {
                        aStudent.SetEvents(Event);
                    }
                }
            }
            if (aTenant.ReturnComplaints() != string.Empty)
            {
                foreach (string Complaint in ComplaintValues)
                {
                    if (Complaint != string.Empty)
                    {
                        aStudent.SetComplaints(Complaint);
                    }
                }
            }
        }
        private void UpdateForm()
        {
            StudentNameLbl.Text = aStudent.ReturnName();
            if (aStudent.ReturnEvents() != string.Empty)
            {
                string[] eventvalues = aStudent.ReturnEvents().Split('\n');
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
                string[] complaintvalues = aStudent.ReturnComplaints().Split('\n');
                foreach (string value in complaintvalues)
                {
                    if (value != string.Empty)
                    {
                        complaintsLB.Items.Add(value);
                    } 
                }
            }
            if (aStudent.ReturnRules() != string.Empty)
            {
                string[] rulevalues = aStudent.ReturnRules().Split('\n');
                foreach (string value in rulevalues)
                {
                    if (value != string.Empty)
                    {
                        rulesLB.Items.Add(value);
                    }
                }
            }
        }

        private void SubmissionBtn_Click(object sender, EventArgs e)
        {
            Submission_Form new_submit = new Submission_Form(aStudent);
            new_submit.Show();
            this.Hide();
        }

        private void btnTenant_Click(object sender, EventArgs e)
        {
          TenantForm tenant = new TenantForm(aStudent);
          tenant.Show();
          this.Close();
        }
    }
}
