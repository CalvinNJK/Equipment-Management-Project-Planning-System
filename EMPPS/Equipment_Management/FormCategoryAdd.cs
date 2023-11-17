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

namespace EMPPS.Equipment_Management
{

    public partial class FormCategoryAdd : Form
    {
        public FormCategoryAdd()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            bool check = false;

            if (textBox_cName.Text == "")
            {
                MessageBox.Show("Category name cannot be blank.", "Warning", 0, MessageBoxIcon.Warning);
                check = true;
            }

            if (check == false)
            {
                Category newCategory = new Category((FileHandling.categoryList.Last().C_Index+1),textBox_cName.Text);

                // Add the new category to categoryList
                FileHandling.categoryList.Add(newCategory);
                Console.WriteLine("// CATEGORY ADDED: " + newCategory.ToString());

                FileHandling.WriteAllCategory();
                this.Close();
            }

        }
    }
}
