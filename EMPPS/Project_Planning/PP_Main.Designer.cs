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
            this.AllProject = new System.Windows.Forms.Label();
            this.AllProjectSearchBar = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AllProjectFilterCategory = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.AllProjectFilterCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllProjectFilterCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllProjectFilterCategory.Image = ((System.Drawing.Image)(resources.GetObject("AllProjectFilterCategory.Image")));
            this.AllProjectFilterCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AllProjectFilterCategory.Location = new System.Drawing.Point(0, 0);
            this.AllProjectFilterCategory.Name = "AllProjectFilterCategory";
            this.AllProjectFilterCategory.Size = new System.Drawing.Size(226, 58);
            this.AllProjectFilterCategory.TabIndex = 2;
            this.AllProjectFilterCategory.Text = "Filter By";
            this.AllProjectFilterCategory.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(646, 106);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(226, 317);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.AllProjectFilterCategory);
            this.panel1.Location = new System.Drawing.Point(646, 106);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 252);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(0, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filter By";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PP_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.AllProjectSearchBar);
            this.Controls.Add(this.AllProject);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PP_Main";
            this.Text = "Project Planning";
            this.Load += new System.EventHandler(this.PP_Main_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AllProject;
        private System.Windows.Forms.TextBox AllProjectSearchBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button AllProjectFilterCategory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}