using EMPPS.Classes;
using EMPPS.Project_Planning;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPPS.Equipment_Management
{
    public partial class FormEM_Main : Form
    {
        // Variable for PieChart
        private int s_OnLoan = 0;
        private int s_Available = 0;
        private int s_Damaged = 0;


        public FormEM_Main()
        {
            InitializeComponent();

            listView_eq.MouseDoubleClick += new MouseEventHandler(listView_eq_MouseDoubleClick);
        }

        private void EM_Main_Load(object sender, EventArgs e)
        {
            LoadReloadViews();
        }







        //
        // Menu
        //
        private void addEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ea_win = new FormEquipmentAdd();
            ea_win.ShowDialog();


            LoadReloadViews();
        }
        private void editCategToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cc_win = new FormCategory();
            cc_win.ShowDialog();
            LoadReloadViews();
        }

        private void addCategoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var ca_win = new FormCategoryAdd();
            ca_win.ShowDialog();
            LoadReloadViews();
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













        //
        // ListView
        //
        private void listView_eq_SelectedIndexChanged(object sender, EventArgs e)
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




        //
        // Buttons
        //
        private void b_eAdd_Click(object sender, EventArgs e)
        {
            var ea_win = new FormEquipmentAdd();
            ea_win.ShowDialog();


            LoadReloadViews();
        }

        private void b_eModify_Click(object sender, EventArgs e)
        {
            var em_win = new FormEquipmentModify(listView_eq.SelectedItems[0].Text.ToString());
            em_win.ShowDialog();


            LoadReloadViews();
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
                        Console.WriteLine("// Removed selected equipement: " + listView_eq.SelectedItems[0].Text.ToString());
                        FileHandling.WriteAllEquipment();
                    }
                    else
                    {
                        MessageBox.Show("The selected equipment currently on loan.", "Warning", 0 , MessageBoxIcon.Warning);
                    }
                    break;
                }
            }


            LoadReloadViews();
            b_eModify.Enabled = false;
            b_eDelete.Enabled = false;
        }



        //
        // Load/Reload all the views
        //
        private void LoadReloadViews()
        {
            //
            // FOR DASHBOARD
            //
            s_Available = 0;
            s_Damaged = 0;
            s_OnLoan = 0;

            // Clear the Pie Charts
            chart1.Series["s1"].Points.Clear();
            chart2.Series["s1"].Points.Clear();


            // Status Pie Chart
            foreach (var item in FileHandling.equipmentList)
            {
                if (item.E_Status == 0)
                {
                    s_Available += 1;
                }
                else if (item.E_Status == 1)
                {
                    s_OnLoan += 1;
                }
                else if (item.E_Status == 2)
                {
                    s_Damaged += 1;
                }
            }
            chart1.Series["s1"].IsValueShownAsLabel = true;
            chart1.Series["s1"].Points.AddXY("Available", s_Available.ToString());
            chart1.Series["s1"].Points.AddXY("On Loan", s_OnLoan.ToString());
            chart1.Series["s1"].Points.AddXY("Damaged", s_Damaged.ToString());


            // Category Pie Chart
            var query = FileHandling.equipmentList.SelectMany(x => x.E_Category.ToString())
                .GroupBy(s => s)
                .Select(g => new { Index = g.Key, Count = g.Count() });

            chart2.Series["s1"].IsValueShownAsLabel = true;

            foreach (var result in query)
            {
                Console.WriteLine("Index: {0}, Count: {1}", result.Index, result.Count);

                foreach (var item in FileHandling.categoryList)
                {
                    if (string.Compare(result.Index.ToString(), item.C_Index.ToString()) == 0)
                    {
                        chart2.Series["s1"].Points.AddXY(item.C_Name, result.Count.ToString());
                    }
                }
            }

            label_TotalEquipment.Text = FileHandling.equipmentList.Count().ToString();
            label_Available.Text = s_Available.ToString();
            label_OnLoan.Text = s_OnLoan.ToString();
            label_Damaged.Text = s_Damaged.ToString();
            label_TotalCat.Text = FileHandling.categoryList.Count().ToString();




            //
            // FOR EQUIPMENT INVENTORY
            //

            // Update the ListView_eq
            listView_eq.Items.Clear();
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

            // Update the labels
            label_TotalEquipment2.Text = FileHandling.equipmentList.Count().ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
