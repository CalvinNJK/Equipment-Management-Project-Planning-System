namespace EMPPS.Project_Planning
{
    partial class PP_Add
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
            this.ChooseEquipmentListView = new System.Windows.Forms.ListView();
            this.ch_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_CostPerDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.CreateProject = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.p_id = new System.Windows.Forms.TextBox();
            this.p_name = new System.Windows.Forms.TextBox();
            this.p_leaderID = new System.Windows.Forms.TextBox();
            this.p_desc = new System.Windows.Forms.RichTextBox();
            this.EquipmentListBox = new System.Windows.Forms.ListBox();
            this.p_duration = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.p_status = new System.Windows.Forms.ComboBox();
            this.ClearEqBtn = new System.Windows.Forms.Button();
            this.AddEqBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.budgetLabel = new System.Windows.Forms.Label();
            this.p_budget = new System.Windows.Forms.Label();
            this.calBudgetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.p_duration)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseEquipmentListView
            // 
            this.ChooseEquipmentListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChooseEquipmentListView.CheckBoxes = true;
            this.ChooseEquipmentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_ID,
            this.ch_Name,
            this.ch_Desc,
            this.ch_Cost,
            this.ch_CostPerDay,
            this.ch_Category,
            this.ch_Status});
            this.ChooseEquipmentListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChooseEquipmentListView.FullRowSelect = true;
            this.ChooseEquipmentListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ChooseEquipmentListView.HideSelection = false;
            this.ChooseEquipmentListView.Location = new System.Drawing.Point(26, 244);
            this.ChooseEquipmentListView.Margin = new System.Windows.Forms.Padding(6);
            this.ChooseEquipmentListView.Name = "ChooseEquipmentListView";
            this.ChooseEquipmentListView.Size = new System.Drawing.Size(1182, 464);
            this.ChooseEquipmentListView.TabIndex = 8;
            this.ChooseEquipmentListView.UseCompatibleStateImageBehavior = false;
            this.ChooseEquipmentListView.View = System.Windows.Forms.View.Details;
            // 
            // ch_ID
            // 
            this.ch_ID.Text = "ID";
            this.ch_ID.Width = 91;
            // 
            // ch_Name
            // 
            this.ch_Name.Text = "Name";
            this.ch_Name.Width = 221;
            // 
            // ch_Desc
            // 
            this.ch_Desc.Text = "Description";
            this.ch_Desc.Width = 346;
            // 
            // ch_Cost
            // 
            this.ch_Cost.DisplayIndex = 4;
            this.ch_Cost.Text = "Cost";
            this.ch_Cost.Width = 100;
            // 
            // ch_CostPerDay
            // 
            this.ch_CostPerDay.DisplayIndex = 5;
            this.ch_CostPerDay.Text = "Cost Per Day";
            this.ch_CostPerDay.Width = 142;
            // 
            // ch_Category
            // 
            this.ch_Category.DisplayIndex = 3;
            this.ch_Category.Text = "Category";
            this.ch_Category.Width = 174;
            // 
            // ch_Status
            // 
            this.ch_Status.Text = "Status";
            this.ch_Status.Width = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Project ID";
            // 
            // CreateProject
            // 
            this.CreateProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CreateProject.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CreateProject.Location = new System.Drawing.Point(1007, 719);
            this.CreateProject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateProject.Name = "CreateProject";
            this.CreateProject.Size = new System.Drawing.Size(201, 38);
            this.CreateProject.TabIndex = 10;
            this.CreateProject.Text = "Create New Project";
            this.CreateProject.UseVisualStyleBackColor = true;
            this.CreateProject.Click += new System.EventHandler(this.CreateProject_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Project Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.Location = new System.Drawing.Point(22, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Project Duration (Month)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(793, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Equipment List";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 28;
            // 
            // p_id
            // 
            this.p_id.Location = new System.Drawing.Point(26, 30);
            this.p_id.Name = "p_id";
            this.p_id.Size = new System.Drawing.Size(178, 30);
            this.p_id.TabIndex = 15;
            this.p_id.TextChanged += new System.EventHandler(this.p_id_TextChanged);
            // 
            // p_name
            // 
            this.p_name.Location = new System.Drawing.Point(26, 89);
            this.p_name.Name = "p_name";
            this.p_name.Size = new System.Drawing.Size(390, 30);
            this.p_name.TabIndex = 16;
            this.p_name.TextChanged += new System.EventHandler(this.p_name_TextChanged);
            // 
            // p_leaderID
            // 
            this.p_leaderID.Location = new System.Drawing.Point(238, 30);
            this.p_leaderID.Name = "p_leaderID";
            this.p_leaderID.Size = new System.Drawing.Size(178, 30);
            this.p_leaderID.TabIndex = 17;
            this.p_leaderID.TextChanged += new System.EventHandler(this.p_leaderID_TextChanged);
            // 
            // p_desc
            // 
            this.p_desc.Location = new System.Drawing.Point(451, 12);
            this.p_desc.Name = "p_desc";
            this.p_desc.Size = new System.Drawing.Size(316, 180);
            this.p_desc.TabIndex = 18;
            this.p_desc.Text = "Enter Project Description Here";
            this.p_desc.TextChanged += new System.EventHandler(this.p_desc_TextChanged);
            // 
            // EquipmentListBox
            // 
            this.EquipmentListBox.FormattingEnabled = true;
            this.EquipmentListBox.ItemHeight = 25;
            this.EquipmentListBox.Location = new System.Drawing.Point(798, 38);
            this.EquipmentListBox.Name = "EquipmentListBox";
            this.EquipmentListBox.Size = new System.Drawing.Size(410, 154);
            this.EquipmentListBox.TabIndex = 19;
            this.EquipmentListBox.SelectedIndexChanged += new System.EventHandler(this.EquipmentListBox_SelectedIndexChanged);
            // 
            // p_duration
            // 
            this.p_duration.Location = new System.Drawing.Point(26, 162);
            this.p_duration.Name = "p_duration";
            this.p_duration.Size = new System.Drawing.Size(178, 30);
            this.p_duration.TabIndex = 21;
            this.p_duration.ValueChanged += new System.EventHandler(this.p_duration_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.Location = new System.Drawing.Point(236, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Project Status";
            // 
            // p_status
            // 
            this.p_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.p_status.FormattingEnabled = true;
            this.p_status.Items.AddRange(new object[] {
            "Planning",
            "On Hold",
            "Completed"});
            this.p_status.Location = new System.Drawing.Point(237, 159);
            this.p_status.Name = "p_status";
            this.p_status.Size = new System.Drawing.Size(179, 33);
            this.p_status.TabIndex = 23;
            this.p_status.Text = "Select Status";
            this.p_status.SelectedIndexChanged += new System.EventHandler(this.p_status_SelectedIndexChanged);
            // 
            // ClearEqBtn
            // 
            this.ClearEqBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ClearEqBtn.ForeColor = System.Drawing.Color.Red;
            this.ClearEqBtn.Location = new System.Drawing.Point(798, 200);
            this.ClearEqBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClearEqBtn.Name = "ClearEqBtn";
            this.ClearEqBtn.Size = new System.Drawing.Size(201, 38);
            this.ClearEqBtn.TabIndex = 24;
            this.ClearEqBtn.Text = "Clear Equipment";
            this.ClearEqBtn.UseVisualStyleBackColor = true;
            this.ClearEqBtn.Click += new System.EventHandler(this.ClearEqBtn_Click);
            // 
            // AddEqBtn
            // 
            this.AddEqBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddEqBtn.ForeColor = System.Drawing.Color.Olive;
            this.AddEqBtn.Location = new System.Drawing.Point(1007, 200);
            this.AddEqBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddEqBtn.Name = "AddEqBtn";
            this.AddEqBtn.Size = new System.Drawing.Size(201, 38);
            this.AddEqBtn.TabIndex = 25;
            this.AddEqBtn.Text = "Add Equipment";
            this.AddEqBtn.UseVisualStyleBackColor = true;
            this.AddEqBtn.Click += new System.EventHandler(this.AddEqBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label7.Location = new System.Drawing.Point(23, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Project ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label8.Location = new System.Drawing.Point(236, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Leader ID";
            // 
            // budgetLabel
            // 
            this.budgetLabel.AutoSize = true;
            this.budgetLabel.Location = new System.Drawing.Point(24, 207);
            this.budgetLabel.Name = "budgetLabel";
            this.budgetLabel.Size = new System.Drawing.Size(180, 25);
            this.budgetLabel.TabIndex = 30;
            this.budgetLabel.Text = "Project Budget: RM";
            // 
            // p_budget
            // 
            this.p_budget.AutoSize = true;
            this.p_budget.ForeColor = System.Drawing.Color.Green;
            this.p_budget.Location = new System.Drawing.Point(300, 207);
            this.p_budget.Name = "p_budget";
            this.p_budget.Size = new System.Drawing.Size(50, 25);
            this.p_budget.TabIndex = 31;
            this.p_budget.Text = "0.00";
            this.p_budget.Click += new System.EventHandler(this.p_budget_Click);
            // 
            // calBudgetBtn
            // 
            this.calBudgetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.calBudgetBtn.ForeColor = System.Drawing.Color.Green;
            this.calBudgetBtn.Location = new System.Drawing.Point(451, 200);
            this.calBudgetBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calBudgetBtn.Name = "calBudgetBtn";
            this.calBudgetBtn.Size = new System.Drawing.Size(219, 38);
            this.calBudgetBtn.TabIndex = 32;
            this.calBudgetBtn.Text = "Calculate Budget";
            this.calBudgetBtn.UseVisualStyleBackColor = true;
            this.calBudgetBtn.Click += new System.EventHandler(this.calBudgetBtn_Click);
            // 
            // PP_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 761);
            this.Controls.Add(this.calBudgetBtn);
            this.Controls.Add(this.p_budget);
            this.Controls.Add(this.budgetLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddEqBtn);
            this.Controls.Add(this.ClearEqBtn);
            this.Controls.Add(this.p_status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.p_duration);
            this.Controls.Add(this.EquipmentListBox);
            this.Controls.Add(this.p_desc);
            this.Controls.Add(this.p_leaderID);
            this.Controls.Add(this.p_name);
            this.Controls.Add(this.p_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CreateProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChooseEquipmentListView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PP_Add";
            this.Text = "Create New Project";
            this.Load += new System.EventHandler(this.PP_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p_duration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ChooseEquipmentListView;
        private System.Windows.Forms.ColumnHeader ch_ID;
        private System.Windows.Forms.ColumnHeader ch_Name;
        private System.Windows.Forms.ColumnHeader ch_Desc;
        private System.Windows.Forms.ColumnHeader ch_Category;
        private System.Windows.Forms.ColumnHeader ch_Cost;
        private System.Windows.Forms.ColumnHeader ch_CostPerDay;
        private System.Windows.Forms.ColumnHeader ch_Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateProject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox p_id;
        private System.Windows.Forms.TextBox p_name;
        private System.Windows.Forms.TextBox p_leaderID;
        private System.Windows.Forms.RichTextBox p_desc;
        private System.Windows.Forms.ListBox EquipmentListBox;
        private System.Windows.Forms.NumericUpDown p_duration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox p_status;
        private System.Windows.Forms.Button ClearEqBtn;
        private System.Windows.Forms.Button AddEqBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label budgetLabel;
        private System.Windows.Forms.Label p_budget;
        private System.Windows.Forms.Button calBudgetBtn;
    }
}