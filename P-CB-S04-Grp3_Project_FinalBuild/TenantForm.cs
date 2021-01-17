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
    public partial class TenantForm : Form
    {
        Tenant aTenant;
        Student aStudent;

        public TenantForm(Student student)
        {
            InitializeComponent();
            aTenant = new Tenant();
            aStudent = student;
            aTenant.SetName(student.ReturnName());
            eventPicker.Value = DateTime.Now;
            AddStudentsData();
            UpdateFormTenant();
        }
     
        private void AddStudentsData()
        {  
            if (aStudent.ReturnEvents() != string.Empty)
            {
                string[] EventValues = aStudent.ReturnEvents().Split('\n');
                foreach (string Event in EventValues)
                {
                    if (Event != string.Empty)
                    {
                        aTenant.AddEvents(Event);
                    }
                }
            }
            if (aStudent.ReturnComplaints() != string.Empty)
            {
                string[] ComplaintValues = aStudent.ReturnComplaints().Split('\n');
                foreach (string Complaint in ComplaintValues)
                {
                    if (Complaint != string.Empty)
                    {
                        aTenant.AddComplaints(Complaint);
                    }
                }
            }
            if (aStudent.ReturnRules() != string.Empty)
            {
                string[] RuleValues = aStudent.ReturnRules().Split('\n');
                foreach (string Rule in RuleValues)
                {
                    if (Rule != string.Empty)
                    {
                        aTenant.AddRules(Rule);
                    }
                }
            }
        }
        private void UpdateFormTenant()
        {
            lsbRules.Items.Clear();
            lsbEvents.Items.Clear();
            lsbComplaints.Items.Clear();
            string[] RuleValues = aTenant.ReturnRules().Split('\n');
            string[] EventValues = aTenant.ReturnEvents().Split('\n');
            string[] ComplaintValues = aTenant.ReturnComplaints().Split('\n');
            
            if (aTenant.ReturnRules() != string.Empty)
            {
                foreach (string Rule in RuleValues)
                {
                    if (Rule != string.Empty)
                    {
                        lsbRules.Items.Add(Rule);
                    }
                }
            }
            if (aTenant.ReturnEvents() != string.Empty)
            {
                foreach (string Event in EventValues)
                {
                    if (Event != string.Empty)
                    {
                        lsbEvents.Items.Add(Event);
                    }
                }
            }
            if (aTenant.ReturnComplaints() != string.Empty)
            {
                foreach (string Complaint in ComplaintValues)
                {
                    if(Complaint != string.Empty)
                    {
                        lsbComplaints.Items.Add(Complaint + " - " + aTenant.ReturnName());
                    }
                }
            }
        }

        private void btwnAddEvent_Click(object sender, EventArgs e)
        {
            DateTime eventTime = eventPicker.Value;
            string Events = tbEvents.Text;
            aTenant.AddEvents(Events + "(" + eventTime.ToString("dd/MM/yy") + ")"+ " -Admin");
            UpdateFormTenant();
            eventPicker.Value = DateTime.Now;
        }

        private void btnRemoveEvent_Click_1(object sender, EventArgs e)
        {
            int Index = lsbEvents.SelectedIndex;
            aTenant.RemoveEvents(Index);
            UpdateFormTenant();
        }

        private void btnRemoveRules_Click_1(object sender, EventArgs e)
        {
            int Index = lsbRules.SelectedIndex;
            aTenant.RemoveRules(Index);
            UpdateFormTenant();
        }

        private void btnAddRule_Click_1(object sender, EventArgs e)
        {
            string Rules = tbRules.Text;
            aTenant.AddRules(Rules);
            UpdateFormTenant();
        }

    
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int Index = lsbComplaints.SelectedIndex;
            aTenant.RemoveComplaints(Index);
            UpdateFormTenant();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            AddUsers userform = new AddUsers();
            userform.Show();
        }

        private void btnStudentPage_Click(object sender, EventArgs e)
        {
            LoginPage login;
            if (aStudent == null)
            {
                login = new LoginPage(aTenant);
            }
            else if (aTenant == null)
            {
                login = new LoginPage(aStudent);
            }
            else
            {
                login = new LoginPage(aStudent, aTenant);
            }
            this.Close();
            login.Show();
        }
    }
}
