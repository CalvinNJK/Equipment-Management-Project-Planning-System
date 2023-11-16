using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPPS.Classes
{
    internal class Equipment
    {
        // Variables 
        private string e_Id;
        private string e_Name;
        private string e_Desc;
        private double e_Cost;
        private string e_Category;
        private int e_Status;

        // Setter & Getter
        public string E_Id
        {
            get { return e_Id; }
            set { e_Id = value; }
        }
        public string E_Name
        {
            get { return e_Name; }
            set { e_Name = value; }
        }
        public string E_Desc
        {
            get { return e_Desc; }
            set { e_Desc = value; }
        }
        public double E_Cost
        {
            get { return e_Cost; }
            set { e_Cost = value; }
        }
        public string E_Category
        {
            get { return e_Category; }
            set { e_Category = value; }
        }
        public int E_Status
        {
            get { return e_Status; }
            set { e_Status = value; }
        }

        // Default Constructor
        public Equipment(string id, string name, string desc, double cost, string cat, int status) 
        { 
            this.e_Id = id;
            this.e_Name = name;
            this.e_Desc = desc;
            this.e_Cost = cost;
            this.e_Category = cat;
            this.e_Status = status;
        }
    }
}
