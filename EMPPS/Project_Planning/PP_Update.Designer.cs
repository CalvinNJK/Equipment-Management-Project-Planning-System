﻿namespace EMPPS.Project_Planning
{
    partial class PP_Update
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddEqBtn = new System.Windows.Forms.Button();
            this.ClearEqBtn = new System.Windows.Forms.Button();
            this.p_status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.p_duration = new System.Windows.Forms.NumericUpDown();
            this.EquipmentListBox = new System.Windows.Forms.ListBox();
            this.p_desc = new System.Windows.Forms.RichTextBox();
            this.p_leaderID = new System.Windows.Forms.TextBox();
            this.p_name = new System.Windows.Forms.TextBox();
            this.p_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateProject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ch_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_CostPerDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChooseEquipmentListView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.p_duration)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label8.Location = new System.Drawing.Point(234, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "Leader ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label7.Location = new System.Drawing.Point(21, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Project ID";
            // 
            // AddEqBtn
            // 
            this.AddEqBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddEqBtn.ForeColor = System.Drawing.Color.Green;
            this.AddEqBtn.Location = new System.Drawing.Point(1005, 207);
            this.AddEqBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddEqBtn.Name = "AddEqBtn";
            this.AddEqBtn.Size = new System.Drawing.Size(201, 38);
            this.AddEqBtn.TabIndex = 45;
            this.AddEqBtn.Text = "Add Equipment";
            this.AddEqBtn.UseVisualStyleBackColor = true;
            this.AddEqBtn.Click += new System.EventHandler(this.AddEqBtn_Click);
            // 
            // ClearEqBtn
            // 
            this.ClearEqBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ClearEqBtn.ForeColor = System.Drawing.Color.Red;
            this.ClearEqBtn.Location = new System.Drawing.Point(796, 207);
            this.ClearEqBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClearEqBtn.Name = "ClearEqBtn";
            this.ClearEqBtn.Size = new System.Drawing.Size(201, 38);
            this.ClearEqBtn.TabIndex = 44;
            this.ClearEqBtn.Text = "Clear Equipment";
            this.ClearEqBtn.UseVisualStyleBackColor = true;
            this.ClearEqBtn.Click += new System.EventHandler(this.ClearEqBtn_Click);
            // 
            // p_status
            // 
            this.p_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.p_status.FormattingEnabled = true;
            this.p_status.Items.AddRange(new object[] {
            "Planning",
            "On Hold",
            "Completed"});
            this.p_status.Location = new System.Drawing.Point(235, 166);
            this.p_status.Name = "p_status";
            this.p_status.Size = new System.Drawing.Size(179, 33);
            this.p_status.TabIndex = 43;
            this.p_status.Text = "Select Status";
            this.p_status.SelectedIndexChanged += new System.EventHandler(this.p_status_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.Location = new System.Drawing.Point(234, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Project Status";
            // 
            // p_duration
            // 
            this.p_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.p_duration.Location = new System.Drawing.Point(24, 169);
            this.p_duration.Name = "p_duration";
            this.p_duration.Size = new System.Drawing.Size(178, 30);
            this.p_duration.TabIndex = 41;
            this.p_duration.ValueChanged += new System.EventHandler(this.p_duration_ValueChanged);
            // 
            // EquipmentListBox
            // 
            this.EquipmentListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EquipmentListBox.FormattingEnabled = true;
            this.EquipmentListBox.ItemHeight = 25;
            this.EquipmentListBox.Location = new System.Drawing.Point(796, 45);
            this.EquipmentListBox.Name = "EquipmentListBox";
            this.EquipmentListBox.Size = new System.Drawing.Size(410, 154);
            this.EquipmentListBox.TabIndex = 40;
            this.EquipmentListBox.SelectedIndexChanged += new System.EventHandler(this.EquipmentListBox_SelectedIndexChanged);
            // 
            // p_desc
            // 
            this.p_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.p_desc.Location = new System.Drawing.Point(449, 19);
            this.p_desc.Name = "p_desc";
            this.p_desc.Size = new System.Drawing.Size(316, 180);
            this.p_desc.TabIndex = 39;
            this.p_desc.Text = "Enter Project Description Here";
            this.p_desc.TextChanged += new System.EventHandler(this.p_desc_TextChanged);
            // 
            // p_leaderID
            // 
            this.p_leaderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.p_leaderID.Location = new System.Drawing.Point(236, 37);
            this.p_leaderID.Name = "p_leaderID";
            this.p_leaderID.Size = new System.Drawing.Size(178, 30);
            this.p_leaderID.TabIndex = 38;
            this.p_leaderID.TextChanged += new System.EventHandler(this.p_leaderID_TextChanged);
            // 
            // p_name
            // 
            this.p_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.p_name.Location = new System.Drawing.Point(24, 96);
            this.p_name.Name = "p_name";
            this.p_name.Size = new System.Drawing.Size(390, 30);
            this.p_name.TabIndex = 37;
            this.p_name.TextChanged += new System.EventHandler(this.p_name_TextChanged);
            // 
            // p_id
            // 
            this.p_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.p_id.Location = new System.Drawing.Point(24, 37);
            this.p_id.Name = "p_id";
            this.p_id.Size = new System.Drawing.Size(178, 30);
            this.p_id.TabIndex = 36;
            this.p_id.TextChanged += new System.EventHandler(this.p_id_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(791, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Equipment List";
            // 
            // CreateProject
            // 
            this.CreateProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CreateProject.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CreateProject.Location = new System.Drawing.Point(1005, 772);
            this.CreateProject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateProject.Name = "CreateProject";
            this.CreateProject.Size = new System.Drawing.Size(201, 38);
            this.CreateProject.TabIndex = 32;
            this.CreateProject.Text = "Update Project";
            this.CreateProject.UseVisualStyleBackColor = true;
            this.CreateProject.Click += new System.EventHandler(this.CreateProject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Project ID";
            // 
            // ch_Status
            // 
            this.ch_Status.Text = "Status";
            this.ch_Status.Width = 87;
            // 
            // ch_CostPerDay
            // 
            this.ch_CostPerDay.Text = "Cost Per Day";
            this.ch_CostPerDay.Width = 142;
            // 
            // ch_Cost
            // 
            this.ch_Cost.Text = "Cost";
            this.ch_Cost.Width = 100;
            // 
            // ch_Category
            // 
            this.ch_Category.Text = "Category";
            this.ch_Category.Width = 174;
            // 
            // ch_Desc
            // 
            this.ch_Desc.Text = "Description";
            this.ch_Desc.Width = 356;
            // 
            // ch_Name
            // 
            this.ch_Name.Text = "Name";
            this.ch_Name.Width = 221;
            // 
            // ch_ID
            // 
            this.ch_ID.Text = "ID";
            this.ch_ID.Width = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.Location = new System.Drawing.Point(20, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Project Duration (Month)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Project Name";
            // 
            // ChooseEquipmentListView
            // 
            this.ChooseEquipmentListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChooseEquipmentListView.CheckBoxes = true;
            this.ChooseEquipmentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_ID,
            this.ch_Name,
            this.ch_Desc,
            this.ch_Category,
            this.ch_Cost,
            this.ch_CostPerDay,
            this.ch_Status});
            this.ChooseEquipmentListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChooseEquipmentListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ChooseEquipmentListView.FullRowSelect = true;
            this.ChooseEquipmentListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ChooseEquipmentListView.HideSelection = false;
            this.ChooseEquipmentListView.Location = new System.Drawing.Point(24, 251);
            this.ChooseEquipmentListView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ChooseEquipmentListView.Name = "ChooseEquipmentListView";
            this.ChooseEquipmentListView.Size = new System.Drawing.Size(1182, 510);
            this.ChooseEquipmentListView.TabIndex = 30;
            this.ChooseEquipmentListView.UseCompatibleStateImageBehavior = false;
            this.ChooseEquipmentListView.View = System.Windows.Forms.View.Details;
            this.ChooseEquipmentListView.SelectedIndexChanged += new System.EventHandler(this.ChooseEquipmentListView_SelectedIndexChanged);
            // 
            // PP_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 816);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CreateProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChooseEquipmentListView);
            this.Name = "PP_Update";
            this.Text = "Update Project";
            ((System.ComponentModel.ISupportInitialize)(this.p_duration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddEqBtn;
        private System.Windows.Forms.Button ClearEqBtn;
        private System.Windows.Forms.ComboBox p_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown p_duration;
        private System.Windows.Forms.ListBox EquipmentListBox;
        private System.Windows.Forms.RichTextBox p_desc;
        private System.Windows.Forms.TextBox p_leaderID;
        private System.Windows.Forms.TextBox p_name;
        private System.Windows.Forms.TextBox p_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreateProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader ch_Status;
        private System.Windows.Forms.ColumnHeader ch_CostPerDay;
        private System.Windows.Forms.ColumnHeader ch_Cost;
        private System.Windows.Forms.ColumnHeader ch_Category;
        private System.Windows.Forms.ColumnHeader ch_Desc;
        private System.Windows.Forms.ColumnHeader ch_Name;
        private System.Windows.Forms.ColumnHeader ch_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView ChooseEquipmentListView;
    }
}