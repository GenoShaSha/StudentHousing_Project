using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCB_S04_Grp3_Project_TobiasHalomoan4252861
{
    public class Tenant
    {

        private List<string> Rules;
        private List<string> Events;
        public Tenant()
        {
            this.Rules = new List<string>();
            this.Events = new List<string>();
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
                Events_string += aEvent + ",";
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
                Rules_string += aRule + ",";
            }
            return Rules_string;
        }
        public void RemoveRules(int Index)
        {
            Rules.RemoveAt(Index);
        }
        public void RemoveEvents(int Index)
        {
            Events.RemoveAt(Index);
        }
    }
}

