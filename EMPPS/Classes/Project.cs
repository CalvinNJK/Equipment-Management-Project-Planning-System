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
        private int p_duration;
        private double p_budget;
        private int p_status;
        private int[] p_eid;

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
        public int P_Duration
        {
            get { return p_duration; }
            set { p_duration = value; }
        }

        public double P_Budget
        {
            get { return p_budget; }
            set { p_budget = value; }
        }

        public int P_Status
        {
            get { return p_status; }
            set { p_status = value; }
        }

        public int[] P_EID
        {
            get { return p_eid; }
            set { p_eid = value; }
        }

        // Default Constructor

        public Project()
        {
            this.p_id = "";
            this.p_name = "";
            this.p_desc = "";
            this.p_leaderId = "";
            this.p_duration = 0;
            this.p_budget = 0.0;
            this.p_status = 0;
        }

        public Project(string id, string name, string desc, string leaderid, int duration, double budget , int p_status, int[] p_eid)
        {
            this.p_id = id;
            this.p_name = name;
            this.p_desc = desc;
            this.p_leaderId = leaderid;
            this.p_duration = duration;
            this.p_budget = budget;
            this.p_status = p_status;
            this.p_eid = p_eid;
        }
    }
}
