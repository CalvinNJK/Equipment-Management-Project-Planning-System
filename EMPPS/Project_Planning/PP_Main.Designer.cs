namespace EMPPS.Project_Planning
{
    partial class PP_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PP_Main));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AllProjectTabPage = new System.Windows.Forms.TabPage();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.AllProjectListView = new System.Windows.Forms.ListView();
            this.p_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.p_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.p_Desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.p_LeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.p_duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.p_budget = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.p_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.p_EID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AllProjectSearchBar = new System.Windows.Forms.TextBox();
            this.b_eAdd = new System.Windows.Forms.Button();
            this.DeleteProject = new System.Windows.Forms.Button();
            this.ModifyProject = new System.Windows.Forms.Button();
            this.CreateProject = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AllProjectTabPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllProjectTabPage
            // 
            this.AllProjectTabPage.Controls.Add(this.filterComboBox);
            this.AllProjectTabPage.Controls.Add(this.searchLabel);
            this.AllProjectTabPage.Controls.Add(this.AllProjectListView);
            this.AllProjectTabPage.Controls.Add(this.AllProjectSearchBar);
            this.AllProjectTabPage.Controls.Add(this.b_eAdd);
            this.AllProjectTabPage.Controls.Add(this.DeleteProject);
            this.AllProjectTabPage.Controls.Add(this.ModifyProject);
            this.AllProjectTabPage.Controls.Add(this.CreateProject);
            this.AllProjectTabPage.Location = new System.Drawing.Point(4, 34);
            this.AllProjectTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.AllProjectTabPage.Name = "AllProjectTabPage";
            this.AllProjectTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.AllProjectTabPage.Size = new System.Drawing.Size(1239, 699);
            this.AllProjectTabPage.TabIndex = 0;
            this.AllProjectTabPage.Text = "All Project";
            this.AllProjectTabPage.UseVisualStyleBackColor = true;
            this.AllProjectTabPage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "(All)",
            "Planning",
            "On Hold",
            "Completed"});
            this.filterComboBox.Location = new System.Drawing.Point(998, 40);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(219, 33);
            this.filterComboBox.TabIndex = 10;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(14, 18);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(233, 25);
            this.searchLabel.TabIndex = 9;
            this.searchLabel.Text = "Search By Key Word : ";
            this.searchLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // AllProjectListView
            // 
            this.AllProjectListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AllProjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.p_ID,
            this.p_Name,
            this.p_Desc,
            this.p_LeaderID,
            this.p_duration,
            this.p_budget,
            this.p_Status,
            this.p_EID});
            this.AllProjectListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.AllProjectListView.FullRowSelect = true;
            this.AllProjectListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AllProjectListView.HideSelection = false;
            this.AllProjectListView.Location = new System.Drawing.Point(18, 90);
            this.AllProjectListView.Margin = new System.Windows.Forms.Padding(4);
            this.AllProjectListView.Name = "AllProjectListView";
            this.AllProjectListView.Size = new System.Drawing.Size(1199, 551);
            this.AllProjectListView.TabIndex = 8;
            this.AllProjectListView.UseCompatibleStateImageBehavior = false;
            this.AllProjectListView.View = System.Windows.Forms.View.Details;
            this.AllProjectListView.SelectedIndexChanged += new System.EventHandler(this.AllProjectListView_SelectedIndexChanged_1);
            // 
            // p_ID
            // 
            this.p_ID.Text = "ID";
            this.p_ID.Width = 91;
            // 
            // p_Name
            // 
            this.p_Name.Text = "Name";
            this.p_Name.Width = 150;
            // 
            // p_Desc
            // 
            this.p_Desc.Text = "Description";
            this.p_Desc.Width = 299;
            // 
            // p_LeaderID
            // 
            this.p_LeaderID.Text = "Leader ID";
            this.p_LeaderID.Width = 112;
            // 
            // p_duration
            // 
            this.p_duration.Text = "Duration";
            this.p_duration.Width = 100;
            // 
            // p_budget
            // 
            this.p_budget.Text = "Budget (RM)";
            this.p_budget.Width = 146;
            // 
            // p_Status
            // 
            this.p_Status.Text = "Status";
            this.p_Status.Width = 87;
            // 
            // p_EID
            // 
            this.p_EID.Text = "Equipments";
            this.p_EID.Width = 152;
            // 
            // AllProjectSearchBar
            // 
            this.AllProjectSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AllProjectSearchBar.Location = new System.Drawing.Point(18, 43);
            this.AllProjectSearchBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AllProjectSearchBar.Name = "AllProjectSearchBar";
            this.AllProjectSearchBar.Size = new System.Drawing.Size(604, 30);
            this.AllProjectSearchBar.TabIndex = 1;
            this.AllProjectSearchBar.TextChanged += new System.EventHandler(this.AllProjectSearchBar_TextChanged);
            // 
            // b_eAdd
            // 
            this.b_eAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_eAdd.Location = new System.Drawing.Point(27, 566);
            this.b_eAdd.Margin = new System.Windows.Forms.Padding(4);
            this.b_eAdd.Name = "b_eAdd";
            this.b_eAdd.Size = new System.Drawing.Size(0, 0);
            this.b_eAdd.TabIndex = 5;
            this.b_eAdd.Text = "Add Equipment";
            this.b_eAdd.UseVisualStyleBackColor = true;
            // 
            // DeleteProject
            // 
            this.DeleteProject.Enabled = false;
            this.DeleteProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProject.ForeColor = System.Drawing.Color.Red;
            this.DeleteProject.Location = new System.Drawing.Point(1088, 649);
            this.DeleteProject.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteProject.Name = "DeleteProject";
            this.DeleteProject.Size = new System.Drawing.Size(129, 47);
            this.DeleteProject.TabIndex = 4;
            this.DeleteProject.Text = "Delete";
            this.DeleteProject.UseVisualStyleBackColor = true;
            this.DeleteProject.Click += new System.EventHandler(this.DeleteProject_Click);
            // 
            // ModifyProject
            // 
            this.ModifyProject.Enabled = false;
            this.ModifyProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProject.ForeColor = System.Drawing.Color.Green;
            this.ModifyProject.Location = new System.Drawing.Point(951, 649);
            this.ModifyProject.Margin = new System.Windows.Forms.Padding(4);
            this.ModifyProject.Name = "ModifyProject";
            this.ModifyProject.Size = new System.Drawing.Size(129, 47);
            this.ModifyProject.TabIndex = 3;
            this.ModifyProject.Text = "Update";
            this.ModifyProject.UseVisualStyleBackColor = true;
            this.ModifyProject.Click += new System.EventHandler(this.ModifyProject_Click);
            // 
            // CreateProject
            // 
            this.CreateProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateProject.Location = new System.Drawing.Point(18, 649);
            this.CreateProject.Margin = new System.Windows.Forms.Padding(4);
            this.CreateProject.Name = "CreateProject";
            this.CreateProject.Size = new System.Drawing.Size(201, 47);
            this.CreateProject.TabIndex = 2;
            this.CreateProject.Text = "Create New Project";
            this.CreateProject.UseVisualStyleBackColor = true;
            this.CreateProject.Click += new System.EventHandler(this.CreateProject_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AllProjectTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1247, 737);
            this.tabControl1.TabIndex = 5;
            // 
            // PP_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 735);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PP_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Planning";
            this.Load += new System.EventHandler(this.PP_Main_Load);
            this.AllProjectTabPage.ResumeLayout(false);
            this.AllProjectTabPage.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage AllProjectTabPage;
        private System.Windows.Forms.ListView AllProjectListView;
        private System.Windows.Forms.ColumnHeader p_ID;
        private System.Windows.Forms.ColumnHeader p_Name;
        private System.Windows.Forms.ColumnHeader p_Desc;
        private System.Windows.Forms.ColumnHeader p_LeaderID;
        private System.Windows.Forms.ColumnHeader p_duration;
        private System.Windows.Forms.ColumnHeader p_budget;
        private System.Windows.Forms.ColumnHeader p_Status;
        private System.Windows.Forms.TextBox AllProjectSearchBar;
        private System.Windows.Forms.Button b_eAdd;
        private System.Windows.Forms.Button DeleteProject;
        private System.Windows.Forms.Button ModifyProject;
        private System.Windows.Forms.Button CreateProject;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ColumnHeader p_EID;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.ComboBox filterComboBox;
    }
}