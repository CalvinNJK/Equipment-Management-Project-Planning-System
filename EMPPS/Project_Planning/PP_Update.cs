using EMPPS.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;

namespace EMPPS.Project_Planning
{
    public partial class PP_Update : Form
    {
        private string ID;
        public PP_Update(string ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void PP_Update_Load(object sender, EventArgs e)
        {

            foreach (var item in FileHandling.projectList)
            {
                if (item.P_ID == ID)
                {
                    p_id.Text = ID;
                    p_name.Text = item.P_Name;
                    p_desc.Text = item.P_Desc;
                    p_leaderID.Text = item.P_LeaderId;
                    p_duration.Value = item.P_Duration;
                    p_budget.Text = item.P_Budget.ToString();
                    p_status.SelectedIndex = item.P_Status;
                    for (int i = 0; i < item.P_EID.Length; i++)
                    {
                        Console.WriteLine(item.P_EID.Length);
                        EquipmentListBox.Items.Add(item.P_EID[i]);

                        //find equipment
                        var matchingEq = FileHandling.equipmentList.First(v => v.E_Id == item.P_EID[i]);

                        //add previous equipment into list view
                        ListViewItem oldItem = new ListViewItem(matchingEq.E_Id);
                        oldItem.SubItems.Add(matchingEq.E_Name);
                        oldItem.SubItems.Add(matchingEq.E_Desc);
                        oldItem.SubItems.Add(matchingEq.E_Cost.ToString("0.00"));
                        oldItem.SubItems.Add(matchingEq.E_CostPerDay.ToString("0.00"));
                        foreach (var ci in FileHandling.categoryList)
                        {
                            if (matchingEq.E_Category == ci.C_Index)
                            {
                                oldItem.SubItems.Add(ci.C_Name);
                            }

                        }
                        oldItem.UseItemStyleForSubItems = false;
                        if (matchingEq.E_Status == 1)
                        {
                            oldItem.SubItems.Add("On Loan");
                            oldItem.SubItems[6].ForeColor = Color.Blue;
                        }

                        oldItem.Checked = true;
                        ChooseEquipmentListView.Items.Add(oldItem);
                    }
                }
            }

            //available item
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

        private void p_leaderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_duration_ValueChanged(object sender, EventArgs e)
        {

        }

        private void p_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void p_desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void EquipmentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChooseEquipmentListView_SelectedIndexChanged(object sender, EventArgs e)
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

        public double calculateBudget(int duration, string[] eqList)
        {
            double budget = 0;

            for (int i = 0; i < eqList.Length; i++)
            {
                budget += (FileHandling.equipmentList.First(e => e.E_Id == eqList[i]).E_CostPerDay * (duration * 30));
            }
            return budget;
        }

        private void calBudgetBtn_Click(object sender, EventArgs e)
        {
            if (p_duration != null)
            {
                string[] eqList = EquipmentListBox.Items.OfType<string>().ToArray();
                p_budget.Text = calculateBudget(int.Parse(p_duration.Text), eqList).ToString();

            }
        }

        private void p_budget_Click(object sender, EventArgs e)
        {

        }

        private void UpProjBtn_Click(object sender, EventArgs e)
        {
            bool showError = false;

            List<string> errorMessages = new List<string>();

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
            else if (!regexLeaderID1.IsMatch(p_id.Text))
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
                // update project
                var upProj = FileHandling.projectList.FirstOrDefault(p => p.P_ID == this.ID);
                string[] preEqList = upProj.P_EID;
                string[] eqList = EquipmentListBox.Items.OfType<string>().ToArray();

                int status = (p_status.SelectedItem.ToString() == "Completed") ? 0 : 1;

                upProj.P_Name = p_name.Text;
                upProj.P_Desc = p_desc.Text;
                upProj.P_LeaderId = p_leaderID.Text;
                upProj.P_Duration = int.Parse(p_duration.Text);
                upProj.P_Budget = calculateBudget(upProj.P_Duration, eqList);
                upProj.P_Status = p_status.SelectedIndex;
                upProj.P_EID = eqList;

                //change previous equipment loan -> available
                foreach (var p in preEqList)
                {
                    FileHandling.equipmentList.FirstOrDefault(s => s.E_Id == p).E_Status = 0;
                }
                // change selected equipment status -> on loan
                foreach (var eq in eqList)
                {
                    if (p_status.SelectedIndex == 2)
                        FileHandling.equipmentList.FirstOrDefault(s => s.E_Id == eq).E_Status = 0;
                    else
                        FileHandling.equipmentList.FirstOrDefault(v => v.E_Id == eq).E_Status = 1;
                }
                
                
                MessageBox.Show(($"Project ({upProj.P_ID}: {upProj.P_Name}) sucessfully updated."), "Successful Update Project", 0, MessageBoxIcon.Information);

                FileHandling.WriteAllEquipment();
                FileHandling.WriteAllProject();
                this.Close();
            }
        }
    }
}
