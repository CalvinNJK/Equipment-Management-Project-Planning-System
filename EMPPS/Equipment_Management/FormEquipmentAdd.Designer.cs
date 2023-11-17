namespace EMPPS.Equipment_Management
{
    partial class FormEquipmentAdd
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_cost = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.radioButton_Damaged = new System.Windows.Forms.RadioButton();
            this.radioButton_Available = new System.Windows.Forms.RadioButton();
            this.comboBox_cat = new System.Windows.Forms.ComboBox();
            this.textBox_costPerDay = new System.Windows.Forms.TextBox();
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.l_status = new System.Windows.Forms.Label();
            this.l_category = new System.Windows.Forms.Label();
            this.l_cost = new System.Windows.Forms.Label();
            this.l_desc = new System.Windows.Forms.Label();
            this.l_name = new System.Windows.Forms.Label();
            this.l_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 63;
            this.label2.Text = "Cost :";
            // 
            // textBox_cost
            // 
            this.textBox_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cost.Location = new System.Drawing.Point(147, 346);
            this.textBox_cost.Name = "textBox_cost";
            this.textBox_cost.Size = new System.Drawing.Size(205, 24);
            this.textBox_cost.TabIndex = 62;
            // 
            // button_Add
            // 
            this.button_Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(83, 528);
            this.button_Add.Margin = new System.Windows.Forms.Padding(50, 3, 50, 10);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(204, 53);
            this.button_Add.TabIndex = 61;
            this.button_Add.Text = "ADD";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // radioButton_Damaged
            // 
            this.radioButton_Damaged.AutoSize = true;
            this.radioButton_Damaged.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Damaged.Location = new System.Drawing.Point(147, 468);
            this.radioButton_Damaged.Name = "radioButton_Damaged";
            this.radioButton_Damaged.Size = new System.Drawing.Size(90, 22);
            this.radioButton_Damaged.TabIndex = 60;
            this.radioButton_Damaged.Text = "Damaged";
            this.radioButton_Damaged.UseVisualStyleBackColor = true;
            this.radioButton_Damaged.CheckedChanged += new System.EventHandler(this.radioButton_Damaged_CheckedChanged);
            // 
            // radioButton_Available
            // 
            this.radioButton_Available.AutoSize = true;
            this.radioButton_Available.Checked = true;
            this.radioButton_Available.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Available.Location = new System.Drawing.Point(147, 440);
            this.radioButton_Available.Name = "radioButton_Available";
            this.radioButton_Available.Size = new System.Drawing.Size(83, 22);
            this.radioButton_Available.TabIndex = 59;
            this.radioButton_Available.TabStop = true;
            this.radioButton_Available.Text = "Available";
            this.radioButton_Available.UseVisualStyleBackColor = true;
            this.radioButton_Available.CheckedChanged += new System.EventHandler(this.radioButton_Available_CheckedChanged);
            // 
            // comboBox_cat
            // 
            this.comboBox_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_cat.FormattingEnabled = true;
            this.comboBox_cat.Location = new System.Drawing.Point(147, 281);
            this.comboBox_cat.Name = "comboBox_cat";
            this.comboBox_cat.Size = new System.Drawing.Size(205, 26);
            this.comboBox_cat.TabIndex = 58;
            // 
            // textBox_costPerDay
            // 
            this.textBox_costPerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_costPerDay.Location = new System.Drawing.Point(147, 381);
            this.textBox_costPerDay.Name = "textBox_costPerDay";
            this.textBox_costPerDay.Size = new System.Drawing.Size(205, 24);
            this.textBox_costPerDay.TabIndex = 57;
            // 
            // textBox_desc
            // 
            this.textBox_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_desc.Location = new System.Drawing.Point(147, 176);
            this.textBox_desc.Multiline = true;
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(205, 84);
            this.textBox_desc.TabIndex = 56;
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(147, 130);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(205, 24);
            this.textBox_name.TabIndex = 55;
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(147, 89);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(205, 24);
            this.textBox_id.TabIndex = 54;
            // 
            // l_status
            // 
            this.l_status.AutoSize = true;
            this.l_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_status.Location = new System.Drawing.Point(37, 442);
            this.l_status.Name = "l_status";
            this.l_status.Size = new System.Drawing.Size(54, 18);
            this.l_status.TabIndex = 53;
            this.l_status.Text = "Status:";
            // 
            // l_category
            // 
            this.l_category.AutoSize = true;
            this.l_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_category.Location = new System.Drawing.Point(37, 284);
            this.l_category.Name = "l_category";
            this.l_category.Size = new System.Drawing.Size(76, 18);
            this.l_category.TabIndex = 52;
            this.l_category.Text = "Category :";
            // 
            // l_cost
            // 
            this.l_cost.AutoSize = true;
            this.l_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_cost.Location = new System.Drawing.Point(37, 384);
            this.l_cost.Name = "l_cost";
            this.l_cost.Size = new System.Drawing.Size(101, 18);
            this.l_cost.TabIndex = 51;
            this.l_cost.Text = "Cost Per Day:";
            // 
            // l_desc
            // 
            this.l_desc.AutoSize = true;
            this.l_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_desc.Location = new System.Drawing.Point(37, 176);
            this.l_desc.Name = "l_desc";
            this.l_desc.Size = new System.Drawing.Size(91, 18);
            this.l_desc.TabIndex = 50;
            this.l_desc.Text = "Description :";
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_name.Location = new System.Drawing.Point(37, 133);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(56, 18);
            this.l_name.TabIndex = 49;
            this.l_name.Text = "Name :";
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_id.Location = new System.Drawing.Point(37, 90);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(30, 18);
            this.l_id.TabIndex = 48;
            this.l_id.Text = "ID :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "ADD EQUIPMENT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormEquipmentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(389, 613);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_cost);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.radioButton_Damaged);
            this.Controls.Add(this.radioButton_Available);
            this.Controls.Add(this.comboBox_cat);
            this.Controls.Add(this.textBox_costPerDay);
            this.Controls.Add(this.textBox_desc);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.l_status);
            this.Controls.Add(this.l_category);
            this.Controls.Add(this.l_cost);
            this.Controls.Add(this.l_desc);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.l_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEquipmentAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Equipement";
            this.Load += new System.EventHandler(this.EquipmentDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_cost;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.RadioButton radioButton_Damaged;
        private System.Windows.Forms.RadioButton radioButton_Available;
        private System.Windows.Forms.ComboBox comboBox_cat;
        private System.Windows.Forms.TextBox textBox_costPerDay;
        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label l_status;
        private System.Windows.Forms.Label l_category;
        private System.Windows.Forms.Label l_cost;
        private System.Windows.Forms.Label l_desc;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.Label label1;
    }
}