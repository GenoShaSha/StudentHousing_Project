using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TenantPage
{
    public partial class Form1 : Form
    {
        Tenant Atenant;
        public Form1()
        {
            Atenant = new Tenant();
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            lsbRules.Items.Clear();
            string Rules = tbRules.Text;
            Atenant.AddRules(Rules);
            Atenant.ReturnRules();
            string[] RuleValues = Atenant.ReturnRules().Split(',');
            if( Atenant.ReturnRules() != string.Empty)
            {
                foreach(string Rule in RuleValues)
                {
                    if( Rule != string.Empty)
                    {
                        lsbRules.Items.Add(Rule);
                    }
                }
            }
        }

        private void btnRemoveRules_Click(object sender, EventArgs e)
        {
            int Index = lsbRules.SelectedIndex;
            Atenant.RemoveRules(Index);
            lsbRules.Items.Clear();
            Atenant.ReturnRules();
            string[] RuleValues = Atenant.ReturnRules().Split(',');
            if (Atenant.ReturnRules() != string.Empty)
            {
                foreach (string Rule in RuleValues)
                {
                    if (Rule != string.Empty)
                    {
                        lsbRules.Items.Add(Rule);
                    }
                }
            }
        }

        private void btwnAddEvent_Click(object sender, EventArgs e)
        {
            lsbEvents.Items.Clear();
            string Events = tbEvents.Text;
            Atenant.AddEvents(Events);
            Atenant.ReturnRules();
            string[] EventValues = Atenant.ReturnEvents().Split(',');
            if (Atenant.ReturnEvents() != string.Empty)
            {
                foreach (string Event in EventValues)
                {
                    if (Event != string.Empty)
                    {
                        lsbEvents.Items.Add(Event);
                    }
                }
            }

        }

        private void btnRemoveEvent_Click(object sender, EventArgs e)
        {
            int Index = lsbEvents.SelectedIndex;
            Atenant.RemoveEvents(Index);
            lsbEvents.Items.Clear();
            Atenant.ReturnEvents();
            string[] EventValues = Atenant.ReturnEvents().Split(',');
            if (Atenant.ReturnEvents() != string.Empty)
            {
                foreach (string Event in EventValues)
                {
                    if (Event != string.Empty)
                    {
                        lsbEvents.Items.Add(Event);
                    }
                }
            }

        }
    }
}
