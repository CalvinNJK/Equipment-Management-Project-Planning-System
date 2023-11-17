namespace EMPPS.Equipment_Management
{
    partial class FormCategory
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
            this.label1 = new System.Windows.Forms.Label();
            this.b_cAdd = new System.Windows.Forms.Button();
            this.b_cDelete = new System.Windows.Forms.Button();
            this.b_cModify = new System.Windows.Forms.Button();
            this.listView_c = new System.Windows.Forms.ListView();
            this.ch_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Category Configuration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_cAdd
            // 
            this.b_cAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_cAdd.Location = new System.Drawing.Point(35, 446);
            this.b_cAdd.Name = "b_cAdd";
            this.b_cAdd.Size = new System.Drawing.Size(97, 38);
            this.b_cAdd.TabIndex = 35;
            this.b_cAdd.Text = "Add";
            this.b_cAdd.UseVisualStyleBackColor = true;
            this.b_cAdd.Click += new System.EventHandler(this.b_cAdd_Click);
            // 
            // b_cDelete
            // 
            this.b_cDelete.Enabled = false;
            this.b_cDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_cDelete.ForeColor = System.Drawing.Color.Red;
            this.b_cDelete.Location = new System.Drawing.Point(182, 490);
            this.b_cDelete.Name = "b_cDelete";
            this.b_cDelete.Size = new System.Drawing.Size(97, 38);
            this.b_cDelete.TabIndex = 34;
            this.b_cDelete.Text = "Delete";
            this.b_cDelete.UseVisualStyleBackColor = true;
            this.b_cDelete.Click += new System.EventHandler(this.b_cDelete_Click);
            // 
            // b_cModify
            // 
            this.b_cModify.Enabled = false;
            this.b_cModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_cModify.ForeColor = System.Drawing.Color.Green;
            this.b_cModify.Location = new System.Drawing.Point(182, 446);
            this.b_cModify.Name = "b_cModify";
            this.b_cModify.Size = new System.Drawing.Size(97, 38);
            this.b_cModify.TabIndex = 33;
            this.b_cModify.Text = "Modify";
            this.b_cModify.UseVisualStyleBackColor = true;
            this.b_cModify.Click += new System.EventHandler(this.b_cModify_Click);
            // 
            // listView_c
            // 
            this.listView_c.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Name});
            this.listView_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_c.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView_c.HideSelection = false;
            this.listView_c.Location = new System.Drawing.Point(35, 72);
            this.listView_c.Name = "listView_c";
            this.listView_c.Size = new System.Drawing.Size(244, 358);
            this.listView_c.TabIndex = 32;
            this.listView_c.UseCompatibleStateImageBehavior = false;
            this.listView_c.View = System.Windows.Forms.View.Details;
            this.listView_c.SelectedIndexChanged += new System.EventHandler(this.listView_c_SelectedIndexChanged);
            // 
            // ch_Name
            // 
            this.ch_Name.Text = "Name";
            this.ch_Name.Width = 239;
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_cAdd);
            this.Controls.Add(this.b_cDelete);
            this.Controls.Add(this.b_cModify);
            this.Controls.Add(this.listView_c);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCategory";
            this.Load += new System.EventHandler(this.FormCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_cAdd;
        private System.Windows.Forms.Button b_cDelete;
        private System.Windows.Forms.Button b_cModify;
        private System.Windows.Forms.ListView listView_c;
        private System.Windows.Forms.ColumnHeader ch_Name;
    }
}