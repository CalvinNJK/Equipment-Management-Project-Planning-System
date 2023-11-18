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
