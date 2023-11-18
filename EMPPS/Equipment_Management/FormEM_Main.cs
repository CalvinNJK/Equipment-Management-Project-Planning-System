﻿using EMPPS.Classes;
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








        //   ---------------------
        //  | Equipment Inventory |
        //   ---------------------

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




        //   -------------------
        //  | Status Management |
        //   -------------------

        private void listView_onloanStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_ToAvailable.Enabled = false;
            button_ToDamaged.Enabled = false;
        }

        private void listView_availableStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Toggle enable when item selected
            if (listView_availableStatus.SelectedItems.Count == 0)
            {
                button_ToDamaged.Enabled = false;
            }
            else
            {
                button_ToDamaged.Enabled = true;
            }
        }

        private void listView_damagedStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Toggle enable when item selected
            if (listView_damagedStatus.SelectedItems.Count == 0)
            {
                button_ToAvailable.Enabled = false;
            }
            else
            {
                button_ToAvailable.Enabled = true;
            }
        }

        private void button_ToDamaged_Click(object sender, EventArgs e)
        {
            foreach (var item in FileHandling.equipmentList)
            {
                if (string.Compare(item.E_Id, listView_availableStatus.SelectedItems[0].Text.ToString()) == 0)
                {

                    item.E_Status = 2;
                    Console.WriteLine("// Selected equipement status changed to DAMAGED: " + listView_availableStatus.SelectedItems[0].Text.ToString());
                    FileHandling.WriteAllEquipment();
                    MessageBox.Show(("Equipment ID (" + item.E_Id + ") updated to Damaged Status."), "Successful updated status", 0, MessageBoxIcon.Exclamation);
                    break;
                }
            }


            LoadReloadViews();
            button_ToAvailable.Enabled = false;
            button_ToDamaged.Enabled = false;
        }

        private void button_ToAvailable_Click(object sender, EventArgs e)
        {
            foreach (var item in FileHandling.equipmentList)
            {
                if (string.Compare(item.E_Id, listView_damagedStatus.SelectedItems[0].Text.ToString()) == 0)
                {

                    item.E_Status = 0;
                    Console.WriteLine("// Selected equipement status changed to DAMAGED: " + listView_damagedStatus.SelectedItems[0].Text.ToString());
                    FileHandling.WriteAllEquipment();
                    MessageBox.Show(("Equipment ID (" + item.E_Id + ") updated to Available Status."), "Successful updated status", 0, MessageBoxIcon.Exclamation);
                    break;
                }
            }


            LoadReloadViews();
            button_ToAvailable.Enabled = false;
            button_ToDamaged.Enabled = false;
            
        }













        //
        // Load/Reload all the views
        //
        private void LoadReloadViews()
        {
            //   ---------------------
            //  | Equipment Inventory |
            //   ---------------------
            int s_Available = 0;
            int s_Damaged = 0;
            int s_OnLoan = 0;
            double totalEqCost = 0.00;

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
                //Console.WriteLine("Index: {0}, Count: {1}", result.Index, result.Count); // Console for debugging

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
            label_totalCatUsed.Text = query.Count().ToString();
            foreach (var item in FileHandling.equipmentList)
            {
                totalEqCost += item.E_Cost;
            }
            label_TotalEqCost.Text = totalEqCost.ToString("0.00");





            //   ---------------------
            //  | Equipment Inventory |
            //   ---------------------

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





            //   -------------------
            //  | Status Management |
            //   -------------------

            // Update the ListView_onloanStatus
            listView_onloanStatus.Items.Clear();
            int totalOnLoan = 0;

            foreach (var item in FileHandling.equipmentList)
            {
                if (item.E_Status == 1)
                {
                    ListViewItem lvonloanEq = new ListViewItem(item.E_Id);
                    lvonloanEq.SubItems.Add(item.E_Name);
                    foreach (var ci in FileHandling.categoryList)
                    {
                        if (item.E_Category == ci.C_Index)
                        {
                            lvonloanEq.SubItems.Add(ci.C_Name);
                        }

                    }

                    totalOnLoan += 1;
                    listView_onloanStatus.Items.Add(lvonloanEq);
                }
            }


            // Update the listView_AvailableStatus
            listView_availableStatus.Items.Clear();
            int totalAvailable = 0;

            foreach (var item in FileHandling.equipmentList)
            {
                if (item.E_Status == 0)
                {
                    ListViewItem lvAvailableEq = new ListViewItem(item.E_Id);
                    lvAvailableEq.SubItems.Add(item.E_Name);
                    foreach (var ci in FileHandling.categoryList)
                    {
                        if (item.E_Category == ci.C_Index)
                        {
                            lvAvailableEq.SubItems.Add(ci.C_Name);
                        }

                    }

                    totalAvailable += 1;
                    listView_availableStatus.Items.Add(lvAvailableEq);
                }
            }


            // Update the listView_DamagedStatus
            listView_damagedStatus.Items.Clear();
            int totalDamaged = 0;

            foreach (var item in FileHandling.equipmentList)
            {
                if (item.E_Status == 2)
                {
                    ListViewItem lvDamagedEq = new ListViewItem(item.E_Id);
                    lvDamagedEq.SubItems.Add(item.E_Name);
                    foreach (var ci in FileHandling.categoryList)
                    {
                        if (item.E_Category == ci.C_Index)
                        {
                            lvDamagedEq.SubItems.Add(ci.C_Name);
                        }

                    }

                    totalDamaged += 1;
                    listView_damagedStatus.Items.Add(lvDamagedEq);
                }
            }


            // Update labels
            label_TotalOnLoan.Text = "(" + totalDamaged.ToString() + ")";
            label_TotalAvailable.Text = "(" + totalAvailable.ToString() + ")";
            label_TotalDamaged.Text = "(" + totalDamaged.ToString() + ")";

        }
    }
}
