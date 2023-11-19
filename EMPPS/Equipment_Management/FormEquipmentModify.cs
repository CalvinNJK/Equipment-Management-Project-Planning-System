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

namespace EMPPS.Equipment_Management
{
    public partial class FormEquipmentModify : Form
    {
        // ID passed from ListView_eq
        private string id;

        public FormEquipmentModify(string id)
        {
            InitializeComponent();

            this.id = id;
        }

        private void EquipmentModify_Load(object sender, EventArgs e)
        {

            Console.WriteLine("\n// Modify Equipment Window Created");
            Console.WriteLine("// ID: " + id + " Passed in");

            // Load ComboBox
            comboBox_cat.DataSource = FileHandling.categoryList;
            comboBox_cat.DisplayMember = "C_Name";
            comboBox_cat.ValueMember = "C_Index";

            // Load Selected Equipment Details
            foreach (var item in FileHandling.equipmentList)
            {
                if (string.Compare(id, item.E_Id) == 0)
                {
                    Console.WriteLine("// " + item.E_Id + " Found.");

                    textBox_id.Text = item.E_Id;
                    textBox_name.Text = item.E_Name;
                    textBox_desc.Text = item.E_Desc;
                    textBox_cost.Text = item.E_Cost.ToString("0.00");
                    textBox_costPerDay.Text = item.E_CostPerDay.ToString("0.00");

                    foreach (var ci in FileHandling.categoryList)
                    {
                        if (item.E_Category == ci.C_Index)
                        {
                            comboBox_cat.SelectedValue = ci.C_Index;
                            break;
                        }
                    }
                    break;
                }
            }
        }

        private void button_Modify_Click(object sender, EventArgs e)
        {
            bool check = false;

            List<string> errorMessages = new List<string>();

            // Input Validation for textBox_name.Text
            Regex regexName1 = new Regex("^(?=.*[A-Za-z0-9])[A-Za-z0-9 ]+$");   // A-Z a-z 0-9 space , But cannot only space
            if (textBox_name.Text == "")
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
                foreach (var item in FileHandling.equipmentList)
                {
                    if (string.Compare(id, item.E_Id) == 0)
                    {
                        item.E_Name = textBox_name.Text;
                        item.E_Desc = textBox_desc.Text;
                        item.E_Category = Int32.Parse(comboBox_cat.SelectedValue.ToString());
                        item.E_Cost = Double.Parse(textBox_cost.Text);
                        item.E_CostPerDay = Double.Parse(textBox_costPerDay.Text);
                        Console.WriteLine("// EQUIPMENT MODIFIED: " + item.ToString());
                        MessageBox.Show(($"Equipment (ID: {item.E_Id}) modified from inventory."), "Successful Modified Equipment", 0, MessageBoxIcon.Information);
                        break;
                    }
                }

                FileHandling.WriteAllEquipment();
                this.Close();
            }
        }
    }
}
