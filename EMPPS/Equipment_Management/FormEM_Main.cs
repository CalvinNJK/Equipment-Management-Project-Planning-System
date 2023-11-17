using EMPPS.Classes;
using EMPPS.Project_Planning;
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
    public partial class FormEM_Main : Form
    {
        public FormEM_Main()
        {
            InitializeComponent();

            listView_eq.MouseDoubleClick += new MouseEventHandler(listView_eq_MouseDoubleClick);
        }

        private void EM_Main_Load(object sender, EventArgs e)
        {
            LoadListView_eq();
        }







        //
        // Menu
        //

        private void addEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ea_win = new FormEquipmentAdd();
            ea_win.ShowDialog();
            listView_eq.Items.Clear();
            LoadListView_eq();
        }
        private void editCategToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cc_win = new FormCategory();
            cc_win.ShowDialog();
            //listView_eq.Items.Clear();
            //LoadListView_eq();
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine(listView_eq.SelectedItems[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }







        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Toggle enable when item selected
            if (listView_eq.SelectedItems.Count == 0)
            {
                b_eModify.Enabled = false;
                b_eDelete.Enabled = false;
            }
            else
            {
                b_eModify.Enabled = true;
                b_eDelete.Enabled = true;
            }


            
        }

        private void listView_eq_MouseDoubleClick(object sender, EventArgs e)
        {
            //Console.WriteLine($"{listView_eq.SelectedItems[0].Text} selected.");

        }







        private void b_eAdd_Click(object sender, EventArgs e)
        {
            var ea_win = new FormEquipmentAdd();
            ea_win.ShowDialog();
            listView_eq.Items.Clear();
            LoadListView_eq();
        }

        private void b_eModify_Click(object sender, EventArgs e)
        {
            var em_win = new FormEquipmentModify(listView_eq.SelectedItems[0].Text.ToString());
            em_win.ShowDialog();
            listView_eq.Items.Clear();
            LoadListView_eq();
            b_eModify.Enabled = false;
            b_eDelete.Enabled = false;

        }

        private void b_eDelete_Click(object sender, EventArgs e)
        {
            foreach (var item in FileHandling.equipmentList)
            {
                if (string.Compare(item.E_Id, listView_eq.SelectedItems[0].Text.ToString()) == 0)
                {
                    if (item.E_Status == 0 || item.E_Status == 2)
                    {
                        FileHandling.equipmentList.Remove(item);
                        FileHandling.WriteAllEquipment();
                        Console.WriteLine("// Removed selected equipement: " + listView_eq.SelectedItems[0].Text.ToString());
                    }
                    else
                    {
                        MessageBox.Show("The selected equipment currently on loan.", "Warning", 0 , MessageBoxIcon.Warning);
                    }
                    break;
                }
            }

            listView_eq.Items.Clear();
            LoadListView_eq();
            b_eModify.Enabled = false;
            b_eDelete.Enabled = false;

            
        }




























        // Load all the Equipments into Table
        private void LoadListView_eq()
        {
            foreach (var item in FileHandling.equipmentList)
            {
                ListViewItem lvItem = new ListViewItem(item.E_Id);
                lvItem.SubItems.Add(item.E_Name);
                lvItem.SubItems.Add(item.E_Desc);
                foreach (var ci in FileHandling.categoryList)
                {
                    if (item.E_Category == ci.C_Index)
                    {
                        lvItem.SubItems.Add(ci.C_Name);
                    }

                }
                lvItem.SubItems.Add(item.E_Cost.ToString("0.00"));
                lvItem.SubItems.Add(item.E_CostPerDay.ToString("0.00"));
                lvItem.SubItems.Add(item.E_Status.ToString());
                listView_eq.Items.Add(lvItem);
            }
        }

        
    }
}
