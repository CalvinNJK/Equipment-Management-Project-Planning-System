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
            this.AllProject = new System.Windows.Forms.Label();
            this.AllProjectSearchBar = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AllProjectFilterCategory = new System.Windows.Forms.Button();
            this.panelFilterCategory = new System.Windows.Forms.Panel();
            this.AllProjectFilterByID = new System.Windows.Forms.Button();
            this.AllProjectFilterByName = new System.Windows.Forms.Button();
            this.AllProjectFilterByDesc = new System.Windows.Forms.Button();
            this.AllProjectFilterByLeaderID = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelFilterCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllProject
            // 
            this.AllProject.AutoSize = true;
            this.AllProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllProject.Location = new System.Drawing.Point(18, 28);
            this.AllProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AllProject.Name = "AllProject";
            this.AllProject.Size = new System.Drawing.Size(99, 25);
            this.AllProject.TabIndex = 0;
            this.AllProject.Text = "All Project";
            this.AllProject.Click += new System.EventHandler(this.label1_Click);
            // 
            // AllProjectSearchBar
            // 
            this.AllProjectSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AllProjectSearchBar.Location = new System.Drawing.Point(675, 28);
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
            this.AllProjectFilterCategory.Image = global::EMPPS.Properties.Resources.Expand;
            this.AllProjectFilterCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AllProjectFilterCategory.Location = new System.Drawing.Point(0, 2);
            this.AllProjectFilterCategory.Name = "AllProjectFilterCategory";
            this.AllProjectFilterCategory.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.AllProjectFilterCategory.Size = new System.Drawing.Size(226, 42);
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
            this.panelFilterCategory.Location = new System.Drawing.Point(1070, 20);
            this.panelFilterCategory.Margin = new System.Windows.Forms.Padding(0);
            this.panelFilterCategory.MaximumSize = new System.Drawing.Size(226, 253);
            this.panelFilterCategory.MinimumSize = new System.Drawing.Size(226, 44);
            this.panelFilterCategory.Name = "panelFilterCategory";
            this.panelFilterCategory.Size = new System.Drawing.Size(226, 44);
            this.panelFilterCategory.TabIndex = 4;
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
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PP_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.panelFilterCategory);
            this.Controls.Add(this.AllProjectSearchBar);
            this.Controls.Add(this.AllProject);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PP_Main";
            this.Text = "Project Planning";
            this.Load += new System.EventHandler(this.PP_Main_Load);
            this.panelFilterCategory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AllProject;
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
    }
}