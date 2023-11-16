using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPPS.Equipment_Management
{
    public partial class EM_Main : Form
    {
        public EM_Main()
        {
            InitializeComponent();
        }

        private void EM_Main_Load(object sender, EventArgs e)
        {
            Console.WriteLine("EM_MAIN SCREEN");
            foreach (var item in FileHandling.equipmentList)
            {
                Console.WriteLine($"{item.E_Id} {item.E_Name} {item.E_Desc} {item.E_Cost} {item.E_Category} {item.E_Status}");
            }
        }
    }
}
