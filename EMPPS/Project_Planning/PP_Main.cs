using EMPPS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace EMPPS.Project_Planning
{
    public partial class PP_Main : Form
    {

        public PP_Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AllProjectSearchBar_TextChanged(object sender, EventArgs e)
        {
        }

        private void PP_Main_Load(object sender, EventArgs e)
        {
            LoadPP_Main();
        }

        private void LoadPP_Main()
        {
            AllProjectListView.Items.Clear();

            foreach (var item in FileHandling.projectList)
            {
                string p_eid = string.Join(", ", item.P_EID);

                ListViewItem lvi = new ListViewItem(item.P_ID);
                lvi.SubItems.Add(item.P_Name);
                lvi.SubItems.Add(item.P_Desc);
                lvi.SubItems.Add(item.P_LeaderId);
                lvi.SubItems.Add(item.P_Duration.ToString());
                lvi.SubItems.Add(item.P_Budget.ToString("0.00"));
                lvi.SubItems.Add((item.P_Status == 0)? "Planning" : (item.P_Status == 1) ? "On Hold" : "Completed");
                lvi.SubItems.Add(p_eid);

                AllProjectListView.Items.Add(lvi);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AllProjectFilterCategory_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AllProjectFilterByDesc_Click(object sender, EventArgs e)
        {

        }


        private void AllProjectFilterCategory_Click_1(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void ModifyProject_Click(object sender, EventArgs e)
        {
            string ID = AllProjectListView.SelectedItems[0].Text.ToString();
            var updateProj = new PP_Update(ID);
            updateProj.ShowDialog();
            LoadPP_Main();
        }

        private void DeleteProject_Click(object sender, EventArgs e)
        {
            foreach (var item in FileHandling.projectList)
            {
                if(item.P_ID == AllProjectListView.SelectedItems[0].Text.ToString())
                {
                    DialogResult delConfirm = MessageBox.Show(($"Are you sure you want to delete Project {item.P_ID} {item.P_Name}?"), "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (delConfirm == DialogResult.Yes)
                    {
                        for (int i = 0; i<item.P_EID.Length;i++)
                        {
                            FileHandling.equipmentList.Find(v => v.E_Id == item.P_EID[i]).E_Status = 0;

                        }
                        FileHandling.projectList.Remove(item);
                        MessageBox.Show(($"Project {item.P_ID} {item.P_Name} is deleted!"), "Successfully deleted", 0, MessageBoxIcon.Information);
                        FileHandling.WriteAllEquipment();
                        FileHandling.WriteAllProject();
                        LoadPP_Main();
                        break;
                    }
                }
            }
        }

        private void CreateProject_Click(object sender, EventArgs e)
        {
            var addProj = new PP_Add();
            addProj.ShowDialog();
            LoadPP_Main();
        }

        private void AllProjectListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AllProjectListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (AllProjectListView.SelectedItems.Count == 0)
            {
                ModifyProject.Enabled = false;
                DeleteProject.Enabled = false;
            }
            else
            {
                ModifyProject.Enabled = true;
                DeleteProject.Enabled = true;
            }
        }
    }
}
