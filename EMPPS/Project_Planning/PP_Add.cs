using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;

namespace EMPPS.Project_Planning
{
    public partial class PP_Add : Form
    {
        public PP_Add()
        {
            InitializeComponent();
        }

        private void PP_Add_Load(object sender, EventArgs e)
        {
            ChooseEquipmentListView.Items.Clear();
            foreach (var item in FileHandling.equipmentList)
            {
                if (item.E_Status == 0)
                {
                    ListViewItem lvItem = new ListViewItem(item.E_Id);
                    lvItem.SubItems.Add(item.E_Name);
                    lvItem.SubItems.Add(item.E_Desc);
                    lvItem.SubItems.Add(item.E_Cost.ToString("0.00"));
                    lvItem.SubItems.Add(item.E_CostPerDay.ToString("0.00"));
                    lvItem.SubItems.Add("Available");

                    ChooseEquipmentListView.Items.Add(lvItem);
                }
            }
        }

        private void p_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_leaderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_duration_ValueChanged(object sender, EventArgs e)
        {

        }

        private void p_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EquipmentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClearEqBtn_Click(object sender, EventArgs e)
        {
            EquipmentListBox.Items.Clear();
        }

        private void AddEqBtn_Click(object sender, EventArgs e)
        {
            if (ChooseEquipmentListView.CheckedItems.Count > 0)
            {
                ListView.CheckedListViewItemCollection checkedItems = ChooseEquipmentListView.CheckedItems;
                int index = 0;
                foreach (ListViewItem item in checkedItems)
                {
                    if (!EquipmentListBox.Items.Contains(item))
                        EquipmentListBox.Items.Add(item.SubItems[index].Text);
                }
            }
        }

        private void CreateProject_Click(object sender, EventArgs e)
        {
            MessageBox.Show(($"Project (ID: P004) sucessfully created."), "Successful Create Project", 0, MessageBoxIcon.Information);
        }
    }
}
