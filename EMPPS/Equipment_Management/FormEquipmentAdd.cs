using EMPPS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace EMPPS.Equipment_Management
{
    public partial class FormEquipmentAdd : Form
    {
        // New Equipment
        Equipment newItem = new Equipment();


        public FormEquipmentAdd()
        {
            InitializeComponent();
        }

        private void EquipmentDetail_Load(object sender, EventArgs e)
        {

            Console.WriteLine("\n// Add Equipment Window Created");

            // Load ComboBox
            comboBox_cat.DataSource = FileHandling.categoryList;
            comboBox_cat.DisplayMember = "C_Name";
            comboBox_cat.ValueMember = "C_Index";

        }


        private void radioButton_Available_CheckedChanged(object sender, EventArgs e)
        {
            newItem.E_Status = 0;   // Available
        }

        private void radioButton_Damaged_CheckedChanged(object sender, EventArgs e)
        {
            newItem.E_Status = 2;   // Damaged
        }


        private void button_Add_Click(object sender, EventArgs e)
        {

            //
            //  DATA VALIDATION NEED!!!!!!!!
            //

            newItem.E_Id = textBox_id.Text;
            newItem.E_Name = textBox_name.Text;
            newItem.E_Desc = textBox_desc.Text;
            newItem.E_Cost = Double.Parse(textBox_cost.Text);
            newItem.E_CostPerDay = Double.Parse(textBox_costPerDay.Text);
            newItem.E_Category = Int32.Parse(comboBox_cat.SelectedValue.ToString());

            // Add the new equipement to equipmentList
            FileHandling.equipmentList.Add(newItem);
            Console.WriteLine("// EQUIPMENT ADDED: " + newItem.ToString());

            FileHandling.WriteAllEquipment();
            this.Close();
        }
    }
}
