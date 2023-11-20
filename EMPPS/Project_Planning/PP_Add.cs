using EMPPS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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
                    foreach (var ci in FileHandling.categoryList)
                    {
                        if (item.E_Category == ci.C_Index)
                        {
                            lvItem.SubItems.Add(ci.C_Name);
                        }

                    }
                    lvItem.UseItemStyleForSubItems = false;
                    if (item.E_Status == 0)
                    {
                        lvItem.SubItems.Add("Available");
                        lvItem.SubItems[6].ForeColor = Color.Green;
                    }

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
                
                foreach (ListViewItem item in checkedItems)
                {
                    bool itemExists = false;
                    foreach (var existingItem in EquipmentListBox.Items)
                    {
                        if (existingItem.ToString() == item.SubItems[0].Text)
                        {
                            itemExists = true;
                            break;
                        }
                    }
                    if (!itemExists)
                    {
                        EquipmentListBox.Items.Add(item.SubItems[0].Text);
                        
                    }
                }
                
            }
        }

        private void CreateProject_Click(object sender, EventArgs e)
        {
            bool showError = false;

            List<string> errorMessages = new List<string>();

            //Project ID
            Regex regexID1 = new Regex("^[A-Za-z0-9]+$");   // A-Z a-z 0-9
            foreach (var item in FileHandling.projectList)
            {
                if (p_id.Text == item.P_ID)
                {
                    errorMessages.Add("Project ID cannot be duplicated.");
                    showError = true;
                    break;
                }
                else if (p_id.Text == "")
                {
                    errorMessages.Add("Project ID cannot be blank.");
                    showError = true;
                    break;
                }
                else if (!regexID1.IsMatch(p_id.Text))
                {
                    errorMessages.Add("Project ID can only have letters and digits.");
                    showError = true;
                    break;
                }
            }

            // Project Name
            Regex regexName1 = new Regex("^(?=.*[A-Za-z0-9])[A-Za-z0-9 ]+$");   // A-Z a-z 0-9 space , But cannot only space
            if (p_name.Text == "")
            {
                errorMessages.Add("Project Name cannot be blank.");
                showError = true;
            }
            else if (!regexName1.IsMatch(p_name.Text))
            {
                errorMessages.Add("Project Name can only have letters, digits and spaces.");
                showError = true;
            }

            // Project Description
            Regex regexDesc1 = new Regex("^(?=.*[A-Za-z0-9])[A-Za-z0-9 !@#$%^&*()_+{}\\[\\]:;<>,.?/~\\\\-]+$");   // A-Z a-z 0-9 space and symbol, But cannot only space
            if (p_desc.Text == "")
            {
                errorMessages.Add("Project Description cannot be blank.");
                showError = true;
            }
            else if (!regexDesc1.IsMatch(p_desc.Text))
            {
                errorMessages.Add("Project Description can only have letters, digits and spaces.");
                showError = true;
            }

            // Project Leader ID
            Regex regexLeaderID1 = new Regex("^[A-Za-z0-9]+$");   // A-Z a-z 0-9
            if (p_leaderID.Text == "")
            {
                errorMessages.Add("Leader ID cannot be blank.");
                showError = true;
            }
            else if (!regexID1.IsMatch(p_id.Text))
            {
                errorMessages.Add("Leader ID can only have letters and digits.");
                showError = true;
            }


            // Project Duration
            Regex regexDuration1 = new Regex("^[0-9]+$");   // 0-9 digits only
            if (p_duration.Text == "")
            {
                errorMessages.Add("Project Duration cannot be blank.");
                showError = true;
            }
            else if (!regexDuration1.IsMatch(p_duration.Text))
            {
                errorMessages.Add("Project Duration can only have digits.");
                showError = true;
            }

            // Project Status
            Regex regexStatus1 = new Regex("^[0-2]+$"); // A-Z a-z 0-9
            if (p_status.Text == "")
            {
                errorMessages.Add("Project Status cannot be blank.");
                showError = true;
            }

            
            if (showError == true)
            {
                MessageBox.Show($"{string.Join(Environment.NewLine, errorMessages)}", "Warning", 0, MessageBoxIcon.Warning);
            }
            else
            {
                // create new project
                Project newProj = new Project();
                string[] eqList = EquipmentListBox.Items.OfType<string>().ToArray();

                int status = 0;
                if (p_status.SelectedItem.ToString() == "Completed")
                {
                    status = 0;
                }
                else
                {
                    status = 1;
                }

                newProj.P_ID = p_id.Text;
                newProj.P_Name = p_name.Text;
                newProj.P_Desc = p_desc.Text;
                newProj.P_LeaderId = p_leaderID.Text;
                newProj.P_Duration = int.Parse(p_duration.Text);
                newProj.P_Budget = calculateBudget(newProj.P_Duration, eqList);
                newProj.P_Status = status;
                newProj.P_EID = eqList;

                // change equipment status -> on loan
                foreach (var eq in eqList)
                {
                    FileHandling.equipmentList.FirstOrDefault(v => v.E_Id == eq).E_Status = 1;
                }
                FileHandling.projectList.Add(newProj);
                MessageBox.Show(($"Project ({newProj.P_ID}: {newProj.P_Name}) sucessfully created."), "Successful Created New Project", 0, MessageBoxIcon.Information);

                FileHandling.WriteAllEquipment();
                FileHandling.WriteAllProject();
                this.Close();
            }
        }

        public double calculateBudget(int duration, string[] eqList)
        {
            double budget = 0;
            
            for (int i = 0; i < eqList.Length; i++)
            {
                budget += (FileHandling.equipmentList.First(e => e.E_Id == eqList[i]).E_CostPerDay * (duration * 30));
            }
            return budget;
        }

        private void p_budget_Click(object sender, EventArgs e)
        {

        }

        private void calBudgetBtn_Click(object sender, EventArgs e)
        {
            if (p_duration != null)
            {
                string[] eqList = EquipmentListBox.Items.OfType<string>().ToArray();
                p_budget.Text = calculateBudget(int.Parse(p_duration.Text), eqList).ToString();

            }
        }
    }
    
}
