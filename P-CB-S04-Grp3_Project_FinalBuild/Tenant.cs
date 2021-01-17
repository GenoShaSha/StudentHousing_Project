using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCB_S04_Grp3_Project_TobiasHalomoan4252861
{
    public class Tenant
    {
        private string name = "";
        private List<string> Rules;
        private List<string> Events;
        private List<string> Complaints;

        public Tenant()
        {
            this.Rules = new List<string>();
            this.Events = new List<string>();
            this.Complaints = new List<string>();
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public string ReturnName()
        {
            return this.name;
        }

        public void AddEvents(string Events)
        {
            this.Events.Add(Events);
        }
        public string ReturnEvents()
        {
            string Events_string = string.Empty;
            foreach (string aEvent in Events)
            {
                Events_string += aEvent + "\n";
            }
            return Events_string;
        }
        public void AddRules(string Rules)
        {
            this.Rules.Add(Rules);

        }
        public string ReturnRules()
        {
            string Rules_string = string.Empty;

            foreach (string aRule in Rules)
            {
                Rules_string += aRule + "\n";
            }
            return Rules_string;
        }

        public void AddComplaints(string Complaints)
        {
            this.Complaints.Add(Complaints);
        }

        public string ReturnComplaints()
        {
            string Complaints_string = string.Empty;
            foreach (string aComplaint in Complaints)
            {
                Complaints_string += aComplaint + "\n";
            }
            return Complaints_string;
        }

        public void RemoveRules(int Index)
        {
            if(Index >= 0)
            {
                Rules.RemoveAt(Index);
            }
        }
        public void RemoveEvents(int Index)
        {
            if(Index >= 0)
            {
                Events.RemoveAt(Index);
            }
           
        }
        public void RemoveComplaints(int Index)
        {
            if(Index >= 0)
            {
                Complaints.RemoveAt(Index);
            }
            
        }
    }
}

