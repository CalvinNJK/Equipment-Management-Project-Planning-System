using EMPPS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
            bool check = false;
            
            List<string> errorMessages = new List<string>();

            // Input Validation for textBox_id.Text
            Regex regexID1 = new Regex("^[A-Za-z0-9]+$");   // A-Z a-z 0-9
            foreach (var item in FileHandling.equipmentList)
            {
                if (textBox_id.Text == item.E_Id)
                {
                    errorMessages.Add("ID cannot be duplicated.");
                    check = true;
                    break;
                }
                else if (textBox_id.Text == "")
                {
                    errorMessages.Add("ID cannot be blank.");
                    check = true;
                    break;
                }
                else if (!regexID1.IsMatch(textBox_id.Text))
                {
                    errorMessages.Add("ID can only have letters and digits.");
                    check = true;
                    break;
                }
            }

            // Input Validation for textBox_name.Text
            Regex regexName1 = new Regex("^(?=.*[A-Za-z0-9])[A-Za-z0-9 ]+$");   // A-Z a-z 0-9 space , But cannot only space
            if(textBox_name.Text == "")
            {
                errorMessages.Add("Name cannot be blank.");
                check = true;
            }
            else if (!regexName1.IsMatch(textBox_name.Text))
            {
                errorMessages.Add("Name can only have letters, digits and spaces.");
                check = true;
            }

            // Input Validation for textBox_desc.Text
            Regex regexDesc1 = new Regex("^(?=.*[A-Za-z0-9])[A-Za-z0-9 ]+$");   // A-Z a-z 0-9 space , But cannot only space
            if (textBox_desc.Text == "")
            {
                errorMessages.Add("Description cannot be blank.");
                check = true;
            }
            else if (!regexDesc1.IsMatch(textBox_desc.Text))
            {
                errorMessages.Add("Description can only have letters, digits and spaces.");
                check = true;
            }

            // Input Validation for textBox_cost.Text
            Regex regexCost1 = new Regex("^\\d+(\\.\\d{1,2})?$");   // xx.xx xx
            if (textBox_cost.Text == "")
            {
                errorMessages.Add("Cost cannot be blank.");
                check = true;
            }
            else if (!regexCost1.IsMatch(textBox_cost.Text))
            {
                errorMessages.Add("Cost can only have currency format.");
                check = true;
            }

            // Input Validation for textBox_cost.Text
            Regex regexCostPerDay1 = new Regex("^\\d+(\\.\\d{1,2})?$");   // xx.xx xx
            if (textBox_costPerDay.Text == "")
            {
                errorMessages.Add("Cost Per Day cannot be blank.");
                check = true;
            }
            else if (!regexCostPerDay1.IsMatch(textBox_costPerDay.Text))
            {
                errorMessages.Add("Cost Per Day can only have currency format.");
                check = true;
            }

            

            if (check == true)
            {
                MessageBox.Show($"{string.Join(Environment.NewLine, errorMessages)}", "Warning", 0, MessageBoxIcon.Warning);
            }
            else    // If all input correct, proceed...
            {
                newItem.E_Id = textBox_id.Text;
                newItem.E_Name = textBox_name.Text;
                newItem.E_Desc = textBox_desc.Text;
                newItem.E_Cost = Double.Parse(textBox_cost.Text);
                newItem.E_CostPerDay = Double.Parse(textBox_costPerDay.Text);
                newItem.E_Category = Int32.Parse(comboBox_cat.SelectedValue.ToString());

                // Add the new equipement to equipmentList
                FileHandling.equipmentList.Add(newItem);
                Console.WriteLine("// EQUIPMENT ADDED: " + newItem.ToString());
                MessageBox.Show(($"Equipment (ID: {newItem.E_Id}) added to inventory."), "Successful Added Equipment", 0, MessageBoxIcon.Information);

                FileHandling.WriteAllEquipment();
                this.Close();
            }
        }
    }
}
