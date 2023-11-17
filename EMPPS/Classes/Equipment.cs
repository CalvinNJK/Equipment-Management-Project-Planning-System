using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace EMPPS.Classes
{
    internal class Equipment
    {
        // Variables 
        private string e_Id;
        private string e_Name;
        private string e_Desc;
        private double e_Cost;
        private int e_Category;
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
        public int E_Category
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
        public Equipment()
        {
            this.e_Id = "";
            this.e_Name = "";
            this.e_Desc = "";
            this.e_Cost = 0;
            this.e_Category = -1;
            this.e_Status = -1;
        }

        public Equipment(string id, string name, string desc, double cost, int cat, int status)
        {
            this.e_Id = id;
            this.e_Name = name;
            this.e_Desc = desc;
            this.e_Cost = cost;
            this.e_Category = cat;
            this.e_Status = status;
        }

        public override string ToString()
        {
            return ($"{E_Id},{E_Name},{E_Desc},{E_Cost},{E_Category},{E_Status}");

        }
    }
}
