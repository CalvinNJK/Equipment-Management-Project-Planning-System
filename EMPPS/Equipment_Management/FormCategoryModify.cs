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
    public partial class FormCategoryModify : Form
    {
        // ID passed from listView_c
        private string id;

        public FormCategoryModify(string id)
        {
            InitializeComponent();

            this.id = id;
        }

        private void FormCategoryModify_Load(object sender, EventArgs e)
        {
            // Load selected Category Name
            foreach (var item in FileHandling.categoryList)
            {
                if (string.Compare(id, item.C_Index.ToString()) == 0)
                {
                    Console.WriteLine("// " + item.C_Index + " Found.");
                    textBox_cName.Text = item.C_Name;
                    break;
                }
            }
        }




        //
        //  Button
        //
        private void button_Modify_Click(object sender, EventArgs e)
        {
            bool check = false;

            // Regex patterns for input validation (textBox_cName.Text)
            Regex regex1 = new Regex("^[A-Za-z]+(?:[ A-Za-z]*)$");

            // Input Validation for (textBox_cName.Text)
            foreach (var item in FileHandling.categoryList)
            {
                if (textBox_cName.Text == item.C_Name)
                {
                    MessageBox.Show("Name cannot be duplicated.", "Warning", 0, MessageBoxIcon.Warning);
                    check = true;
                    break;
                }
                else if (textBox_cName.Text == "")
                {
                    MessageBox.Show("Name cannot be blank.", "Warning", 0, MessageBoxIcon.Warning);
                    check = true;
                    break;
                }
                else if (!regex1.IsMatch(textBox_cName.Text))
                {
                    MessageBox.Show("Name can only have letters and spaces.", "Warning", 0, MessageBoxIcon.Warning);
                    check = true;
                    break;
                }
            }

            // If all input correct, proceed...
            if (check == false)
            {
                foreach (var item in FileHandling.categoryList)
                {
                    if (string.Compare(id, item.C_Index.ToString()) == 0)
                    {
                        item.C_Name = textBox_cName.Text;
                        Console.WriteLine("// CATEGORY MODIFIED: " + item.ToString());
                        MessageBox.Show(($"({item.C_Name}) modified to the category list."), "Successful modified category", 0, MessageBoxIcon.Information);
                        break;
                    }
                }
                FileHandling.WriteAllCategory();
                this.Close();
            }
        }
    }
}
