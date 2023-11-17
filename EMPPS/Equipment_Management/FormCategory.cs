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
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            LoadListView_c();
        }




        //
        // ListView
        //
        private void listView_c_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Toggle enable when item selected
            if(listView_c.SelectedItems.Count == 0)
            {
                b_cModify.Enabled = false;
                b_cDelete.Enabled = false;
            }
            else
            {
                b_cModify.Enabled = true;
                b_cDelete.Enabled = true;
            }
            
        }



        
        //
        // Buttons
        //
        private void b_cAdd_Click(object sender, EventArgs e)
        {
            var ca_win = new FormCategoryAdd();
            ca_win.ShowDialog();
            listView_c.Items.Clear();
            LoadListView_c();
        }

        private void b_cModify_Click(object sender, EventArgs e)
        {
            var cm_win = new FormCategoryModify(listView_c.SelectedItems[0].SubItems[1].Text);
            cm_win.ShowDialog();
            listView_c.Items.Clear();
            LoadListView_c();
            b_cModify.Enabled = false;
            b_cDelete.Enabled = false;
        }

        private void b_cDelete_Click(object sender, EventArgs e)
        {
            bool checkFound = false;

            // Check any equipment in the selected category
            foreach (var eq in FileHandling.equipmentList)
            {
                if (string.Compare(eq.E_Category.ToString(), listView_c.SelectedItems[0].SubItems[1].Text) == 0)
                {
                    checkFound = true;
                    break;
                }
            }

            if (checkFound == false)
            {
                foreach (var item in FileHandling.categoryList)
                {
                    if (string.Compare(item.C_Index.ToString(), listView_c.SelectedItems[0].SubItems[1].Text) == 0)
                    { 
                        FileHandling.categoryList.Remove(item);
                        Console.WriteLine("// Removed selected category: " + listView_c.SelectedItems[0].SubItems[1].Text + " " + listView_c.SelectedItems[0].Text);
                        FileHandling.WriteAllCategory();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("The selected category currently in used.", "Warning", 0, MessageBoxIcon.Warning);
            }

            listView_c.Items.Clear();
            LoadListView_c();
            b_cModify.Enabled = false;
            b_cDelete.Enabled = false;
        }




        // Load all the Categories into Table
        private void LoadListView_c()
        {
            foreach (var item in FileHandling.categoryList)
            {
                ListViewItem lvItem = new ListViewItem(item.C_Name);
                lvItem.SubItems.Add(item.C_Index.ToString());
                listView_c.Items.Add(lvItem);
            }
        }
    }
}
