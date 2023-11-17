namespace EMPPS.Equipment_Management
{
    partial class FormEM_Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.b_eAdd = new System.Windows.Forms.Button();
            this.b_eDelete = new System.Windows.Forms.Button();
            this.b_eModify = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView_eq = new System.Windows.Forms.ListView();
            this.ch_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categorizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCategToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ch_CostPerDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileHandlingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileHandlingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileHandlingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileHandlingBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(743, 540);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.b_eAdd);
            this.tabPage1.Controls.Add(this.b_eDelete);
            this.tabPage1.Controls.Add(this.b_eModify);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.listView_eq);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(735, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Equipment Inventory";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // b_eAdd
            // 
            this.b_eAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_eAdd.Location = new System.Drawing.Point(20, 460);
            this.b_eAdd.Name = "b_eAdd";
            this.b_eAdd.Size = new System.Drawing.Size(151, 38);
            this.b_eAdd.TabIndex = 5;
            this.b_eAdd.Text = "Add Equipment";
            this.b_eAdd.UseVisualStyleBackColor = true;
            this.b_eAdd.Click += new System.EventHandler(this.b_eAdd_Click);
            // 
            // b_eDelete
            // 
            this.b_eDelete.Enabled = false;
            this.b_eDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_eDelete.ForeColor = System.Drawing.Color.Red;
            this.b_eDelete.Location = new System.Drawing.Point(616, 460);
            this.b_eDelete.Name = "b_eDelete";
            this.b_eDelete.Size = new System.Drawing.Size(97, 38);
            this.b_eDelete.TabIndex = 4;
            this.b_eDelete.Text = "Delete";
            this.b_eDelete.UseVisualStyleBackColor = true;
            this.b_eDelete.Click += new System.EventHandler(this.b_eDelete_Click);
            // 
            // b_eModify
            // 
            this.b_eModify.Enabled = false;
            this.b_eModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_eModify.ForeColor = System.Drawing.Color.Green;
            this.b_eModify.Location = new System.Drawing.Point(513, 460);
            this.b_eModify.Name = "b_eModify";
            this.b_eModify.Size = new System.Drawing.Size(97, 38);
            this.b_eModify.TabIndex = 3;
            this.b_eModify.Text = "Modify";
            this.b_eModify.UseVisualStyleBackColor = true;
            this.b_eModify.Click += new System.EventHandler(this.b_eModify_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(592, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView_eq
            // 
            this.listView_eq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_eq.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_ID,
            this.ch_Name,
            this.ch_Desc,
            this.ch_Category,
            this.ch_Cost,
            this.ch_CostPerDay,
            this.ch_Status});
            this.listView_eq.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView_eq.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_eq.HideSelection = false;
            this.listView_eq.Location = new System.Drawing.Point(20, 58);
            this.listView_eq.Name = "listView_eq";
            this.listView_eq.Size = new System.Drawing.Size(693, 396);
            this.listView_eq.TabIndex = 1;
            this.listView_eq.UseCompatibleStateImageBehavior = false;
            this.listView_eq.View = System.Windows.Forms.View.Details;
            this.listView_eq.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ch_ID
            // 
            this.ch_ID.Text = "ID";
            this.ch_ID.Width = 72;
            // 
            // ch_Name
            // 
            this.ch_Name.Text = "Name";
            this.ch_Name.Width = 77;
            // 
            // ch_Desc
            // 
            this.ch_Desc.Text = "Description";
            this.ch_Desc.Width = 140;
            // 
            // ch_Cost
            // 
            this.ch_Cost.Text = "Cost";
            this.ch_Cost.Width = 90;
            // 
            // ch_Category
            // 
            this.ch_Category.Text = "Category";
            this.ch_Category.Width = 84;
            // 
            // ch_Status
            // 
            this.ch_Status.Text = "Status";
            this.ch_Status.Width = 172;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(735, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Status Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCategoryToolStripMenuItem,
            this.categorizationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addCategoryToolStripMenuItem
            // 
            this.addCategoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEquipmentToolStripMenuItem});
            this.addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            this.addCategoryToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.addCategoryToolStripMenuItem.Text = "Equipment Inventory";
            // 
            // addEquipmentToolStripMenuItem
            // 
            this.addEquipmentToolStripMenuItem.Name = "addEquipmentToolStripMenuItem";
            this.addEquipmentToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addEquipmentToolStripMenuItem.Text = "Add Equipment";
            this.addEquipmentToolStripMenuItem.Click += new System.EventHandler(this.addEquipmentToolStripMenuItem_Click);
            // 
            // categorizationToolStripMenuItem
            // 
            this.categorizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCategToolStripMenuItem,
            this.addCategoryToolStripMenuItem1});
            this.categorizationToolStripMenuItem.Name = "categorizationToolStripMenuItem";
            this.categorizationToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.categorizationToolStripMenuItem.Text = "Categorization";
            // 
            // editCategToolStripMenuItem
            // 
            this.editCategToolStripMenuItem.Name = "editCategToolStripMenuItem";
            this.editCategToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.editCategToolStripMenuItem.Text = "Configuration";
            this.editCategToolStripMenuItem.Click += new System.EventHandler(this.editCategToolStripMenuItem_Click);
            // 
            // addCategoryToolStripMenuItem1
            // 
            this.addCategoryToolStripMenuItem1.Name = "addCategoryToolStripMenuItem1";
            this.addCategoryToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.addCategoryToolStripMenuItem1.Text = "Add Category";
            // 
            // ch_CostPerDay
            // 
            this.ch_CostPerDay.Text = "Cost Per Day";
            this.ch_CostPerDay.Width = 147;
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataSource = typeof(EMPPS.Classes.Equipment);
            // 
            // fileHandlingBindingSource
            // 
            this.fileHandlingBindingSource.DataSource = typeof(EMPPS.FileHandling);
            // 
            // fileHandlingBindingSource1
            // 
            this.fileHandlingBindingSource1.DataSource = typeof(EMPPS.FileHandling);
            // 
            // FormEM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 566);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEM_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipment Management";
            this.Load += new System.EventHandler(this.EM_Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileHandlingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileHandlingBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private System.Windows.Forms.BindingSource fileHandlingBindingSource1;
        private System.Windows.Forms.BindingSource fileHandlingBindingSource;
        private System.Windows.Forms.ListView listView_eq;
        private System.Windows.Forms.ColumnHeader ch_ID;
        private System.Windows.Forms.ColumnHeader ch_Name;
        private System.Windows.Forms.ColumnHeader ch_Desc;
        private System.Windows.Forms.ColumnHeader ch_Cost;
        private System.Windows.Forms.ColumnHeader ch_Category;
        private System.Windows.Forms.ColumnHeader ch_Status;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button b_eDelete;
        private System.Windows.Forms.Button b_eModify;
        private System.Windows.Forms.Button b_eAdd;
        private System.Windows.Forms.ToolStripMenuItem addEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categorizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCategToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem1;
        private System.Windows.Forms.ColumnHeader ch_CostPerDay;
    }
}