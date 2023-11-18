namespace EMPPS.Equipment_Management
{
    partial class FormEquipmentModify
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
            this.textBox_costPerDay = new System.Windows.Forms.TextBox();
            this.l_costPerDay = new System.Windows.Forms.Label();
            this.button_Modify = new System.Windows.Forms.Button();
            this.comboBox_cat = new System.Windows.Forms.ComboBox();
            this.textBox_cost = new System.Windows.Forms.TextBox();
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.l_category = new System.Windows.Forms.Label();
            this.l_cost = new System.Windows.Forms.Label();
            this.l_desc = new System.Windows.Forms.Label();
            this.l_name = new System.Windows.Forms.Label();
            this.l_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_costPerDay
            // 
            this.textBox_costPerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_costPerDay.Location = new System.Drawing.Point(143, 378);
            this.textBox_costPerDay.Name = "textBox_costPerDay";
            this.textBox_costPerDay.Size = new System.Drawing.Size(205, 24);
            this.textBox_costPerDay.TabIndex = 81;
            // 
            // l_costPerDay
            // 
            this.l_costPerDay.AutoSize = true;
            this.l_costPerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_costPerDay.Location = new System.Drawing.Point(33, 381);
            this.l_costPerDay.Name = "l_costPerDay";
            this.l_costPerDay.Size = new System.Drawing.Size(101, 18);
            this.l_costPerDay.TabIndex = 80;
            this.l_costPerDay.Text = "Cost Per Day:";
            // 
            // button_Modify
            // 
            this.button_Modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Modify.Location = new System.Drawing.Point(87, 449);
            this.button_Modify.Margin = new System.Windows.Forms.Padding(50, 3, 50, 10);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(204, 53);
            this.button_Modify.TabIndex = 79;
            this.button_Modify.Text = "MODIFY";
            this.button_Modify.UseVisualStyleBackColor = true;
            this.button_Modify.Click += new System.EventHandler(this.button_Modify_Click);
            // 
            // comboBox_cat
            // 
            this.comboBox_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_cat.FormattingEnabled = true;
            this.comboBox_cat.Location = new System.Drawing.Point(143, 297);
            this.comboBox_cat.Name = "comboBox_cat";
            this.comboBox_cat.Size = new System.Drawing.Size(205, 26);
            this.comboBox_cat.TabIndex = 78;
            // 
            // textBox_cost
            // 
            this.textBox_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cost.Location = new System.Drawing.Point(143, 343);
            this.textBox_cost.Name = "textBox_cost";
            this.textBox_cost.Size = new System.Drawing.Size(205, 24);
            this.textBox_cost.TabIndex = 77;
            // 
            // textBox_desc
            // 
            this.textBox_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_desc.Location = new System.Drawing.Point(143, 192);
            this.textBox_desc.Multiline = true;
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(205, 84);
            this.textBox_desc.TabIndex = 76;
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(143, 146);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(205, 24);
            this.textBox_name.TabIndex = 75;
            // 
            // textBox_id
            // 
            this.textBox_id.Enabled = false;
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(143, 105);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(205, 24);
            this.textBox_id.TabIndex = 74;
            // 
            // l_category
            // 
            this.l_category.AutoSize = true;
            this.l_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_category.Location = new System.Drawing.Point(33, 300);
            this.l_category.Name = "l_category";
            this.l_category.Size = new System.Drawing.Size(76, 18);
            this.l_category.TabIndex = 73;
            this.l_category.Text = "Category :";
            // 
            // l_cost
            // 
            this.l_cost.AutoSize = true;
            this.l_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_cost.Location = new System.Drawing.Point(33, 346);
            this.l_cost.Name = "l_cost";
            this.l_cost.Size = new System.Drawing.Size(48, 18);
            this.l_cost.TabIndex = 72;
            this.l_cost.Text = "Cost :";
            // 
            // l_desc
            // 
            this.l_desc.AutoSize = true;
            this.l_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_desc.Location = new System.Drawing.Point(33, 192);
            this.l_desc.Name = "l_desc";
            this.l_desc.Size = new System.Drawing.Size(91, 18);
            this.l_desc.TabIndex = 71;
            this.l_desc.Text = "Description :";
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_name.Location = new System.Drawing.Point(33, 149);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(56, 18);
            this.l_name.TabIndex = 70;
            this.l_name.Text = "Name :";
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_id.Location = new System.Drawing.Point(33, 106);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(30, 18);
            this.l_id.TabIndex = 69;
            this.l_id.Text = "ID :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 68;
            this.label1.Text = "MODIFY EQUIPMENT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormEquipmentModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 542);
            this.Controls.Add(this.textBox_costPerDay);
            this.Controls.Add(this.l_costPerDay);
            this.Controls.Add(this.button_Modify);
            this.Controls.Add(this.comboBox_cat);
            this.Controls.Add(this.textBox_cost);
            this.Controls.Add(this.textBox_desc);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.l_category);
            this.Controls.Add(this.l_cost);
            this.Controls.Add(this.l_desc);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.l_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormEquipmentModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Equipment";
            this.Load += new System.EventHandler(this.EquipmentModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_costPerDay;
        private System.Windows.Forms.Label l_costPerDay;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.ComboBox comboBox_cat;
        private System.Windows.Forms.TextBox textBox_cost;
        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label l_category;
        private System.Windows.Forms.Label l_cost;
        private System.Windows.Forms.Label l_desc;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.Label label1;
    }
}