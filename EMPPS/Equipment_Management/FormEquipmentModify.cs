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
    public partial class FormEquipmentModify : Form
    {
        // ID passed from ListView_equipment
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
                }
            }
        }

        private void button_Modify_Click(object sender, EventArgs e)
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
                    break;
                }
            }
            FileHandling.WriteAllEquipment();
            this.Close();
        }
    }
}
