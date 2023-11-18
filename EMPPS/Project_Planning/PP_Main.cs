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
        private bool filterCategoryIsCollapsed;

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (filterCategoryIsCollapsed)
            {
                AllProjectFilterCategory.Image = Resources.Collapse;
                panelFilterCategory.Height += 10;
                if (panelFilterCategory.Size == panelFilterCategory.MaximumSize)
                {
                    timer1.Stop();
                    filterCategoryIsCollapsed = false;
                }
            } else
            {
                AllProjectFilterCategory.Image = Resources.Expand;
                panelFilterCategory.Height -= 10;
                if (panelFilterCategory.Size == panelFilterCategory.MinimumSize)
                {
                    timer1.Stop();
                    filterCategoryIsCollapsed = true;
                }
            }
        }

        private void AllProjectFilterCategory_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            System.Data.DataTable projectDataExcel = new System.Data.DataTable();
            projectDataExcel.TableName = "ProjectData";
            string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\EMPPS\project.xls';Extended Properties='excel 8.0;HDR=Yes;IMEX=1'";
            OleDbConnection con = new OleDbConnection(sourceConstr);
            string query = "SELECT * FROM [Sheet1$]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query,con);
            dataAdapter.Fill(projectDataExcel);
            AllProjectListView.Columns.Add("PROJECT ID", 100, HorizontalAlignment.Left);
            AllProjectListView.Columns.Add("NAME", 100, HorizontalAlignment.Left);
            AllProjectListView.Columns.Add("DESCRIPTION", 100, HorizontalAlignment.Left);
            AllProjectListView.Columns.Add("LEADER ID", 100, HorizontalAlignment.Left);
            AllProjectListView.Columns.Add("DURATION", 100, HorizontalAlignment.Left);
            AllProjectListView.Columns.Add("BUDGET", 100, HorizontalAlignment.Left);
            AllProjectListView.Columns.Add("STATUS", 100, HorizontalAlignment.Left);
            AllProjectListView.Columns.Add("EQUIPMENT ID", 100, HorizontalAlignment.Left);
            AllProjectListView.Items.Clear();
            for (int i = 0; i < projectDataExcel.Rows.Count; i++)
            {
                DataRow dr = projectDataExcel.Rows[i];
                if (dr.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(dr["PROJECT ID"].ToString());
                    lvi.SubItems.Add(dr["NAME"].ToString());
                    lvi.SubItems.Add(dr["DESCRIPTION"].ToString());
                    lvi.SubItems.Add(dr["LEADER ID"].ToString());
                    lvi.SubItems.Add(dr["DURATION"].ToString());
                    lvi.SubItems.Add(dr["BUDGET"].ToString());
                    lvi.SubItems.Add(dr["STATUS"].ToString());
                    lvi.SubItems.Add(dr["EQUIPMENT ID"].ToString());
                    AllProjectListView.Items.Add(lvi);
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void listView_eq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ModifyProject_Click(object sender, EventArgs e)
        {

        }

        private void DeleteProject_Click(object sender, EventArgs e)
        {

        }

        private void CreateProject_Click(object sender, EventArgs e)
        {

        }
    }
}
