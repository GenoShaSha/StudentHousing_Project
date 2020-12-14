using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCB_S04_Grp3_Project_TobiasHalomoan4252861
{
    public class Student
    {
        private string name;
        private List<string> events;
        private List<string> complaints;

        public Student(string name)
        {
            this.name = name;
            this.events = new List<string>();
            this.complaints = new List<string>();
        }

        public void SetComplaints(string complaints)
        {
            this.complaints.Add(complaints);
        }

        public void SetEvents(string events)
        {
            this.events.Add(events);
        }

        public string ReturnComplaints()
        {
            string complaint_string = "";
            foreach (string aComplaint in complaints )
            {
                complaint_string += aComplaint + ",";
            }
            return complaint_string;
        }

        public string ReturnEvents()
        {
            string event_string = "";
            foreach (string anEvent in events)
            {
                event_string += anEvent +",";
            }
            return event_string;
        }
        public string ReturnName()
        {
            return this.name;
        }
    }
}
