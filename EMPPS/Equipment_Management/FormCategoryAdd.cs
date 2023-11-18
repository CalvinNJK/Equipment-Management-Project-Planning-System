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

namespace EMPPS.Equipment_Management
{

    public partial class FormCategoryAdd : Form
    {
        public FormCategoryAdd()
        {
            InitializeComponent();
        }

        private void FormCategoryAdd_Load(object sender, EventArgs e)
        {
            Console.WriteLine("\n// Add Category Window Created");
        }

        private void button_Add_Click(object sender, EventArgs e)
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
                Category newCategory = new Category((FileHandling.categoryList.Last().C_Index+1),textBox_cName.Text);

                // Add the new category to categoryList
                FileHandling.categoryList.Add(newCategory);
                Console.WriteLine("// CATEGORY ADDED: " + newCategory.ToString());

                MessageBox.Show(($"({newCategory.C_Name}) added to the category list."), "Successful added category", 0, MessageBoxIcon.Information);
                FileHandling.WriteAllCategory();
                this.Close();
            }

        }

        
    }
}
