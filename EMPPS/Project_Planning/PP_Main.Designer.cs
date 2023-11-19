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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PP_Main));
            this.AllProjectSearchBar = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AllProjectFilterCategory = new System.Windows.Forms.Button();
            this.panelFilterCategory = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AllProjectFilterByLeaderID = new System.Windows.Forms.Button();
            this.AllProjectFilterByDesc = new System.Windows.Forms.Button();
            this.AllProjectFilterByName = new System.Windows.Forms.Button();
            this.AllProjectFilterByID = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AllProjectTabPage = new System.Windows.Forms.TabPage();
            this.AllProjectListView = new System.Windows.Forms.ListView();
            this.p_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.p_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.p_Desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.p_LeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.p_duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.p_budget = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.p_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.b_eAdd = new System.Windows.Forms.Button();
            this.DeleteProject = new System.Windows.Forms.Button();
            this.ModifyProject = new System.Windows.Forms.Button();
            this.CreateProject = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelFilterCategory.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.AllProjectTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllProjectSearchBar
            // 
            this.AllProjectSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AllProjectSearchBar.Location = new System.Drawing.Point(27, 29);
            this.AllProjectSearchBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AllProjectSearchBar.Name = "AllProjectSearchBar";
            this.AllProjectSearchBar.Size = new System.Drawing.Size(360, 30);
            this.AllProjectSearchBar.TabIndex = 1;
            this.AllProjectSearchBar.Text = "Choose Category to Filter";
            this.AllProjectSearchBar.TextChanged += new System.EventHandler(this.AllProjectSearchBar_TextChanged);
            // 
            // AllProjectFilterCategory
            // 
            this.AllProjectFilterCategory.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AllProjectFilterCategory.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.AllProjectFilterCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllProjectFilterCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllProjectFilterCategory.Image = ((System.Drawing.Image)(resources.GetObject("AllProjectFilterCategory.Image")));
            this.AllProjectFilterCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AllProjectFilterCategory.Location = new System.Drawing.Point(0, 13);
            this.AllProjectFilterCategory.Name = "AllProjectFilterCategory";
            this.AllProjectFilterCategory.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.AllProjectFilterCategory.Size = new System.Drawing.Size(226, 32);
            this.AllProjectFilterCategory.TabIndex = 2;
            this.AllProjectFilterCategory.Text = "Filter By";
            this.AllProjectFilterCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllProjectFilterCategory.UseVisualStyleBackColor = false;
            this.AllProjectFilterCategory.Click += new System.EventHandler(this.AllProjectFilterCategory_Click_1);
            // 
            // panelFilterCategory
            // 
            this.panelFilterCategory.Controls.Add(this.button3);
            this.panelFilterCategory.Controls.Add(this.button1);
            this.panelFilterCategory.Controls.Add(this.button2);
            this.panelFilterCategory.Controls.Add(this.AllProjectFilterByLeaderID);
            this.panelFilterCategory.Controls.Add(this.AllProjectFilterByDesc);
            this.panelFilterCategory.Controls.Add(this.AllProjectFilterByName);
            this.panelFilterCategory.Controls.Add(this.AllProjectFilterByID);
            this.panelFilterCategory.Controls.Add(this.AllProjectFilterCategory);
            this.panelFilterCategory.Location = new System.Drawing.Point(404, 16);
            this.panelFilterCategory.Margin = new System.Windows.Forms.Padding(0);
            this.panelFilterCategory.MaximumSize = new System.Drawing.Size(226, 253);
            this.panelFilterCategory.MinimumSize = new System.Drawing.Size(226, 44);
            this.panelFilterCategory.Name = "panelFilterCategory";
            this.panelFilterCategory.Size = new System.Drawing.Size(226, 44);
            this.panelFilterCategory.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(0, 222);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.button3.Size = new System.Drawing.Size(226, 30);
            this.button3.TabIndex = 9;
            this.button3.Text = "Equipment Used";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(0, 192);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.button1.Size = new System.Drawing.Size(226, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Project Budget";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(0, 162);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.button2.Size = new System.Drawing.Size(226, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "Project Duration";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // AllProjectFilterByLeaderID
            // 
            this.AllProjectFilterByLeaderID.BackColor = System.Drawing.Color.DodgerBlue;
            this.AllProjectFilterByLeaderID.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.AllProjectFilterByLeaderID.FlatAppearance.BorderSize = 0;
            this.AllProjectFilterByLeaderID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllProjectFilterByLeaderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllProjectFilterByLeaderID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllProjectFilterByLeaderID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AllProjectFilterByLeaderID.Location = new System.Drawing.Point(0, 132);
            this.AllProjectFilterByLeaderID.Name = "AllProjectFilterByLeaderID";
            this.AllProjectFilterByLeaderID.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.AllProjectFilterByLeaderID.Size = new System.Drawing.Size(226, 30);
            this.AllProjectFilterByLeaderID.TabIndex = 6;
            this.AllProjectFilterByLeaderID.Text = "Leader ID";
            this.AllProjectFilterByLeaderID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllProjectFilterByLeaderID.UseVisualStyleBackColor = false;
            // 
            // AllProjectFilterByDesc
            // 
            this.AllProjectFilterByDesc.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AllProjectFilterByDesc.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.AllProjectFilterByDesc.FlatAppearance.BorderSize = 0;
            this.AllProjectFilterByDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllProjectFilterByDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllProjectFilterByDesc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllProjectFilterByDesc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AllProjectFilterByDesc.Location = new System.Drawing.Point(0, 102);
            this.AllProjectFilterByDesc.Name = "AllProjectFilterByDesc";
            this.AllProjectFilterByDesc.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.AllProjectFilterByDesc.Size = new System.Drawing.Size(226, 30);
            this.AllProjectFilterByDesc.TabIndex = 5;
            this.AllProjectFilterByDesc.Text = "Project Description";
            this.AllProjectFilterByDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllProjectFilterByDesc.UseVisualStyleBackColor = false;
            this.AllProjectFilterByDesc.Click += new System.EventHandler(this.AllProjectFilterByDesc_Click);
            // 
            // AllProjectFilterByName
            // 
            this.AllProjectFilterByName.BackColor = System.Drawing.Color.DodgerBlue;
            this.AllProjectFilterByName.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.AllProjectFilterByName.FlatAppearance.BorderSize = 0;
            this.AllProjectFilterByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllProjectFilterByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllProjectFilterByName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllProjectFilterByName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AllProjectFilterByName.Location = new System.Drawing.Point(0, 72);
            this.AllProjectFilterByName.Name = "AllProjectFilterByName";
            this.AllProjectFilterByName.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.AllProjectFilterByName.Size = new System.Drawing.Size(226, 30);
            this.AllProjectFilterByName.TabIndex = 4;
            this.AllProjectFilterByName.Text = "Project Name";
            this.AllProjectFilterByName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllProjectFilterByName.UseVisualStyleBackColor = false;
            // 
            // AllProjectFilterByID
            // 
            this.AllProjectFilterByID.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AllProjectFilterByID.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.AllProjectFilterByID.FlatAppearance.BorderSize = 0;
            this.AllProjectFilterByID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllProjectFilterByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllProjectFilterByID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllProjectFilterByID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AllProjectFilterByID.Location = new System.Drawing.Point(0, 42);
            this.AllProjectFilterByID.Name = "AllProjectFilterByID";
            this.AllProjectFilterByID.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.AllProjectFilterByID.Size = new System.Drawing.Size(226, 30);
            this.AllProjectFilterByID.TabIndex = 3;
            this.AllProjectFilterByID.Text = "Project ID";
            this.AllProjectFilterByID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllProjectFilterByID.UseVisualStyleBackColor = false;
            this.AllProjectFilterByID.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AllProjectTabPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1209, 665);
            this.tabControl1.TabIndex = 5;
            // 
            // AllProjectTabPage
            // 
            this.AllProjectTabPage.Controls.Add(this.AllProjectListView);
            this.AllProjectTabPage.Controls.Add(this.b_eAdd);
            this.AllProjectTabPage.Controls.Add(this.panelFilterCategory);
            this.AllProjectTabPage.Controls.Add(this.DeleteProject);
            this.AllProjectTabPage.Controls.Add(this.AllProjectSearchBar);
            this.AllProjectTabPage.Controls.Add(this.ModifyProject);
            this.AllProjectTabPage.Controls.Add(this.CreateProject);
            this.AllProjectTabPage.Location = new System.Drawing.Point(4, 34);
            this.AllProjectTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.AllProjectTabPage.Name = "AllProjectTabPage";
            this.AllProjectTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.AllProjectTabPage.Size = new System.Drawing.Size(1201, 627);
            this.AllProjectTabPage.TabIndex = 0;
            this.AllProjectTabPage.Text = "All Project";
            this.AllProjectTabPage.UseVisualStyleBackColor = true;
            this.AllProjectTabPage.Click += new System.EventHandler(this.tabPage1_Click);
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
            this.p_Status});
            this.AllProjectListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.AllProjectListView.FullRowSelect = true;
            this.AllProjectListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AllProjectListView.HideSelection = false;
            this.AllProjectListView.Location = new System.Drawing.Point(19, 64);
            this.AllProjectListView.Margin = new System.Windows.Forms.Padding(4);
            this.AllProjectListView.Name = "AllProjectListView";
            this.AllProjectListView.Size = new System.Drawing.Size(1164, 488);
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
            this.p_LeaderID.Width = 290;
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
            this.DeleteProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProject.ForeColor = System.Drawing.Color.Red;
            this.DeleteProject.Location = new System.Drawing.Point(1054, 566);
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
            this.ModifyProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProject.ForeColor = System.Drawing.Color.Green;
            this.ModifyProject.Location = new System.Drawing.Point(917, 566);
            this.ModifyProject.Margin = new System.Windows.Forms.Padding(4);
            this.ModifyProject.Name = "ModifyProject";
            this.ModifyProject.Size = new System.Drawing.Size(129, 47);
            this.ModifyProject.TabIndex = 3;
            this.ModifyProject.Text = "Modify";
            this.ModifyProject.UseVisualStyleBackColor = true;
            this.ModifyProject.Click += new System.EventHandler(this.ModifyProject_Click);
            // 
            // CreateProject
            // 
            this.CreateProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CreateProject.Location = new System.Drawing.Point(19, 566);
            this.CreateProject.Margin = new System.Windows.Forms.Padding(4);
            this.CreateProject.Name = "CreateProject";
            this.CreateProject.Size = new System.Drawing.Size(201, 47);
            this.CreateProject.TabIndex = 2;
            this.CreateProject.Text = "Create New Project";
            this.CreateProject.UseVisualStyleBackColor = true;
            this.CreateProject.Click += new System.EventHandler(this.CreateProject_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(983, 627);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Status Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // PP_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 700);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PP_Main";
            this.Text = "Project Planning";
            this.Load += new System.EventHandler(this.PP_Main_Load);
            this.panelFilterCategory.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.AllProjectTabPage.ResumeLayout(false);
            this.AllProjectTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox AllProjectSearchBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button AllProjectFilterCategory;
        private System.Windows.Forms.Panel panelFilterCategory;
        private System.Windows.Forms.Button AllProjectFilterByID;
        private System.Windows.Forms.Button AllProjectFilterByLeaderID;
        private System.Windows.Forms.Button AllProjectFilterByDesc;
        private System.Windows.Forms.Button AllProjectFilterByName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AllProjectTabPage;
        private System.Windows.Forms.Button b_eAdd;
        private System.Windows.Forms.Button DeleteProject;
        private System.Windows.Forms.Button ModifyProject;
        private System.Windows.Forms.Button CreateProject;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView AllProjectListView;
        private System.Windows.Forms.ColumnHeader p_ID;
        private System.Windows.Forms.ColumnHeader p_Name;
        private System.Windows.Forms.ColumnHeader p_Desc;
        private System.Windows.Forms.ColumnHeader p_LeaderID;
        private System.Windows.Forms.ColumnHeader p_duration;
        private System.Windows.Forms.ColumnHeader p_budget;
        private System.Windows.Forms.ColumnHeader p_Status;
    }
}