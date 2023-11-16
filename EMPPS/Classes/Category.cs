using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPPS.Classes
{
    internal class Category
    {
        // Variables
        private int c_Index;
        private string c_Name;

        // Setter and Getter
        public int C_Index
        {  
            get { return c_Index; } 
            set { c_Index = value; }
        }

        public string C_Name
        {
            get { return c_Name; }
            set { c_Name = value; }
        }

        // Default Constructor
        public Category(int cc_Index, string cc_Name)
        {
            this.c_Index = cc_Index;
            this.c_Name = cc_Name;
        }
    }
}
