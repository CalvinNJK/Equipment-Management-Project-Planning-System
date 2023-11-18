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

        private void button_Modify_Click(object sender, EventArgs e)
        {

            //
            //  DATA VALIDATION NEED!!!!!!!!
            //

            foreach (var item in FileHandling.categoryList)
            {
                if (string.Compare(id, item.C_Index.ToString()) == 0)
                {
                    item.C_Name = textBox_cName.Text;
                    Console.WriteLine("// CATEGORY MODIFIED: " + item.ToString());
                    break;
                }
            }
            FileHandling.WriteAllCategory();
            this.Close();
        }
    }
}
