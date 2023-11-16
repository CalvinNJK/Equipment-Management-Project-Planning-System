using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPPS.Classes
{
    internal class Project
    {
        // Variables 
        private string p_id;
        private string p_name;
        private string p_desc;
        private string p_leaderId;
        private string p_duration;
        private string p_budget;

        // Setter & Getter
        public string P_ID
        {
            get { return p_id; }
            set { p_id = value; }
        }
        public string P_Name
        {
            get { return p_name; }
            set { p_name = value; }
        }
        public string P_Desc
        {
            get { return p_desc; }
            set { p_desc = value; }
        }
        public string P_LeaderId
        {
            get { return p_leaderId; }
            set { p_leaderId = value; }
        }
        public string P_Duration
        {
            get { return p_duration; }
            set { p_duration = value; }
        }

        public string P_Budget
        {
            get { return p_budget; }
            set { p_budget = value; }
        }

        // Default Constructor
        public Project(string id, string name, string desc, string leaderid, string duration, string budget)
        {
            this.p_id = id;
            this.p_name = name;
            this.p_desc = desc;
            this.p_leaderId = leaderid;
            this.p_duration = duration;
            this.p_budget = budget;
        }
    }
}
