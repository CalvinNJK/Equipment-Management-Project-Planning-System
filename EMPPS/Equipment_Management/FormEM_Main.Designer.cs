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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.b_eAdd = new System.Windows.Forms.Button();
            this.b_eDelete = new System.Windows.Forms.Button();
            this.b_eModify = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView_eq = new System.Windows.Forms.ListView();
            this.ch_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_CostPerDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categorizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCategToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_TotalEquipment = new System.Windows.Forms.Label();
            this.label_Available = new System.Windows.Forms.Label();
            this.label_OnLoan = new System.Windows.Forms.Label();
            this.label_Damaged = new System.Windows.Forms.Label();
            this.label_TotalCat = new System.Windows.Forms.Label();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileHandlingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileHandlingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label_TotalEquipment2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(877, 609);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label_TotalCat);
            this.tabPage1.Controls.Add(this.label_Damaged);
            this.tabPage1.Controls.Add(this.label_OnLoan);
            this.tabPage1.Controls.Add(this.label_Available);
            this.tabPage1.Controls.Add(this.label_TotalEquipment);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.chart2);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(869, 576);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Equipment Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Equipment Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Alignment = System.Drawing.StringAlignment.Center;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.IsDockedInsideChartArea = false;
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(446, 67);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "s1";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(400, 328);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Alignment = System.Drawing.StringAlignment.Center;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.IsDockedInsideChartArea = false;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(24, 67);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "s1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(400, 328);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label_TotalEquipment2);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.b_eAdd);
            this.tabPage2.Controls.Add(this.b_eDelete);
            this.tabPage2.Controls.Add(this.b_eModify);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.listView_eq);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(869, 576);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Equipment Inventory";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // b_eAdd
            // 
            this.b_eAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_eAdd.Location = new System.Drawing.Point(28, 527);
            this.b_eAdd.Name = "b_eAdd";
            this.b_eAdd.Size = new System.Drawing.Size(151, 38);
            this.b_eAdd.TabIndex = 11;
            this.b_eAdd.Text = "Add Equipment";
            this.b_eAdd.UseVisualStyleBackColor = true;
            this.b_eAdd.Click += new System.EventHandler(this.b_eAdd_Click);
            // 
            // b_eDelete
            // 
            this.b_eDelete.Enabled = false;
            this.b_eDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_eDelete.ForeColor = System.Drawing.Color.Red;
            this.b_eDelete.Location = new System.Drawing.Point(744, 527);
            this.b_eDelete.Name = "b_eDelete";
            this.b_eDelete.Size = new System.Drawing.Size(97, 38);
            this.b_eDelete.TabIndex = 10;
            this.b_eDelete.Text = "Delete";
            this.b_eDelete.UseVisualStyleBackColor = true;
            this.b_eDelete.Click += new System.EventHandler(this.b_eDelete_Click);
            // 
            // b_eModify
            // 
            this.b_eModify.Enabled = false;
            this.b_eModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_eModify.ForeColor = System.Drawing.Color.Green;
            this.b_eModify.Location = new System.Drawing.Point(641, 527);
            this.b_eModify.Name = "b_eModify";
            this.b_eModify.Size = new System.Drawing.Size(97, 38);
            this.b_eModify.TabIndex = 9;
            this.b_eModify.Text = "Modify";
            this.b_eModify.UseVisualStyleBackColor = true;
            this.b_eModify.Click += new System.EventHandler(this.b_eModify_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(593, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.listView_eq.Location = new System.Drawing.Point(28, 58);
            this.listView_eq.Name = "listView_eq";
            this.listView_eq.Size = new System.Drawing.Size(813, 463);
            this.listView_eq.TabIndex = 7;
            this.listView_eq.UseCompatibleStateImageBehavior = false;
            this.listView_eq.View = System.Windows.Forms.View.Details;
            this.listView_eq.SelectedIndexChanged += new System.EventHandler(this.listView_eq_SelectedIndexChanged);
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
            // ch_Category
            // 
            this.ch_Category.Text = "Category";
            this.ch_Category.Width = 84;
            // 
            // ch_Cost
            // 
            this.ch_Cost.Text = "Cost";
            this.ch_Cost.Width = 90;
            // 
            // ch_CostPerDay
            // 
            this.ch_CostPerDay.Text = "Cost Per Day";
            this.ch_CostPerDay.Width = 147;
            // 
            // ch_Status
            // 
            this.ch_Status.Text = "Status";
            this.ch_Status.Width = 185;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(869, 576);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Status Management";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCategoryToolStripMenuItem,
            this.categorizationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 24);
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
            this.addCategoryToolStripMenuItem1.Click += new System.EventHandler(this.addCategoryToolStripMenuItem1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Equipments :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(481, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Categories :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Available :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(112, 501);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "On Loan :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(103, 531);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Damaged :";
            // 
            // label_TotalEquipment
            // 
            this.label_TotalEquipment.AutoSize = true;
            this.label_TotalEquipment.Location = new System.Drawing.Point(205, 428);
            this.label_TotalEquipment.Name = "label_TotalEquipment";
            this.label_TotalEquipment.Size = new System.Drawing.Size(13, 20);
            this.label_TotalEquipment.TabIndex = 11;
            this.label_TotalEquipment.Text = " ";
            // 
            // label_Available
            // 
            this.label_Available.AutoSize = true;
            this.label_Available.Location = new System.Drawing.Point(205, 471);
            this.label_Available.Name = "label_Available";
            this.label_Available.Size = new System.Drawing.Size(13, 20);
            this.label_Available.TabIndex = 12;
            this.label_Available.Text = " ";
            // 
            // label_OnLoan
            // 
            this.label_OnLoan.AutoSize = true;
            this.label_OnLoan.Location = new System.Drawing.Point(205, 501);
            this.label_OnLoan.Name = "label_OnLoan";
            this.label_OnLoan.Size = new System.Drawing.Size(0, 20);
            this.label_OnLoan.TabIndex = 13;
            // 
            // label_Damaged
            // 
            this.label_Damaged.AutoSize = true;
            this.label_Damaged.Location = new System.Drawing.Point(205, 531);
            this.label_Damaged.Name = "label_Damaged";
            this.label_Damaged.Size = new System.Drawing.Size(0, 20);
            this.label_Damaged.TabIndex = 14;
            // 
            // label_TotalCat
            // 
            this.label_TotalCat.AutoSize = true;
            this.label_TotalCat.Location = new System.Drawing.Point(638, 428);
            this.label_TotalCat.Name = "label_TotalCat";
            this.label_TotalCat.Size = new System.Drawing.Size(13, 20);
            this.label_TotalCat.TabIndex = 15;
            this.label_TotalCat.Text = " ";
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
            // label_TotalEquipment2
            // 
            this.label_TotalEquipment2.AutoSize = true;
            this.label_TotalEquipment2.Location = new System.Drawing.Point(363, 536);
            this.label_TotalEquipment2.Name = "label_TotalEquipment2";
            this.label_TotalEquipment2.Size = new System.Drawing.Size(13, 20);
            this.label_TotalEquipment2.TabIndex = 13;
            this.label_TotalEquipment2.Text = " ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(198, 536);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Total Equipments :";
            // 
            // FormEM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 633);
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
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private System.Windows.Forms.BindingSource fileHandlingBindingSource1;
        private System.Windows.Forms.BindingSource fileHandlingBindingSource;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categorizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCategToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button b_eAdd;
        private System.Windows.Forms.Button b_eDelete;
        private System.Windows.Forms.Button b_eModify;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView_eq;
        private System.Windows.Forms.ColumnHeader ch_ID;
        private System.Windows.Forms.ColumnHeader ch_Name;
        private System.Windows.Forms.ColumnHeader ch_Desc;
        private System.Windows.Forms.ColumnHeader ch_Category;
        private System.Windows.Forms.ColumnHeader ch_Cost;
        private System.Windows.Forms.ColumnHeader ch_CostPerDay;
        private System.Windows.Forms.ColumnHeader ch_Status;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_TotalEquipment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_Damaged;
        private System.Windows.Forms.Label label_OnLoan;
        private System.Windows.Forms.Label label_Available;
        private System.Windows.Forms.Label label_TotalCat;
        private System.Windows.Forms.Label label_TotalEquipment2;
        private System.Windows.Forms.Label label10;
    }
}