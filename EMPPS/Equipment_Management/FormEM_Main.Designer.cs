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
            System.Windows.Forms.ColumnHeader chA_Eid;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEM_Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label_totalCatUsed = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label_TotalEqCost = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_TotalCat = new System.Windows.Forms.Label();
            this.label_Damaged = new System.Windows.Forms.Label();
            this.label_OnLoan = new System.Windows.Forms.Label();
            this.label_Available = new System.Windows.Forms.Label();
            this.label_TotalEquipment = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox_FilterByCat = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label_TotalEquipment2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.b_eAdd = new System.Windows.Forms.Button();
            this.b_eDelete = new System.Windows.Forms.Button();
            this.b_eModify = new System.Windows.Forms.Button();
            this.listView_eq = new System.Windows.Forms.ListView();
            this.ch_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_CostPerDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label_TotalDamaged = new System.Windows.Forms.Label();
            this.label_TotalAvailable = new System.Windows.Forms.Label();
            this.label_TotalOnLoan = new System.Windows.Forms.Label();
            this.button_ToAvailable = new System.Windows.Forms.Button();
            this.button_ToDamaged = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.listView_damagedStatus = new System.Windows.Forms.ListView();
            this.chD_Eid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chD_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chD_Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_availableStatus = new System.Windows.Forms.ListView();
            this.chA_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chA_Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_onloanStatus = new System.Windows.Forms.ListView();
            this.chOL_Eid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOL_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOL_Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOL_PID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOL_PName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOL_PDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categorizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCategToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chOL_LID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileHandlingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileHandlingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            chA_Eid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileHandlingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileHandlingBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // chA_Eid
            // 
            chA_Eid.Text = "ID";
            chA_Eid.Width = 84;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(966, 652);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label_totalCatUsed);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label_TotalEqCost);
            this.tabPage1.Controls.Add(this.label9);
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
            this.tabPage1.Size = new System.Drawing.Size(958, 619);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(696, 529);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 20);
            this.label15.TabIndex = 20;
            this.label15.Text = " RM";
            // 
            // label_totalCatUsed
            // 
            this.label_totalCatUsed.AutoSize = true;
            this.label_totalCatUsed.Location = new System.Drawing.Point(696, 419);
            this.label_totalCatUsed.Name = "label_totalCatUsed";
            this.label_totalCatUsed.Size = new System.Drawing.Size(13, 20);
            this.label_totalCatUsed.TabIndex = 19;
            this.label_totalCatUsed.Text = " ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(508, 449);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(186, 20);
            this.label14.TabIndex = 18;
            this.label14.Text = "Categories in system :";
            // 
            // label_TotalEqCost
            // 
            this.label_TotalEqCost.AutoSize = true;
            this.label_TotalEqCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalEqCost.Location = new System.Drawing.Point(732, 520);
            this.label_TotalEqCost.Name = "label_TotalEqCost";
            this.label_TotalEqCost.Size = new System.Drawing.Size(19, 29);
            this.label_TotalEqCost.TabIndex = 17;
            this.label_TotalEqCost.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(502, 529);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Total Equipment Cost :";
            // 
            // label_TotalCat
            // 
            this.label_TotalCat.AutoSize = true;
            this.label_TotalCat.Location = new System.Drawing.Point(696, 449);
            this.label_TotalCat.Name = "label_TotalCat";
            this.label_TotalCat.Size = new System.Drawing.Size(13, 20);
            this.label_TotalCat.TabIndex = 15;
            this.label_TotalCat.Text = " ";
            // 
            // label_Damaged
            // 
            this.label_Damaged.AutoSize = true;
            this.label_Damaged.Location = new System.Drawing.Point(234, 479);
            this.label_Damaged.Name = "label_Damaged";
            this.label_Damaged.Size = new System.Drawing.Size(13, 20);
            this.label_Damaged.TabIndex = 14;
            this.label_Damaged.Text = " ";
            // 
            // label_OnLoan
            // 
            this.label_OnLoan.AutoSize = true;
            this.label_OnLoan.Location = new System.Drawing.Point(234, 449);
            this.label_OnLoan.Name = "label_OnLoan";
            this.label_OnLoan.Size = new System.Drawing.Size(13, 20);
            this.label_OnLoan.TabIndex = 13;
            this.label_OnLoan.Text = " ";
            // 
            // label_Available
            // 
            this.label_Available.AutoSize = true;
            this.label_Available.Location = new System.Drawing.Point(234, 419);
            this.label_Available.Name = "label_Available";
            this.label_Available.Size = new System.Drawing.Size(13, 20);
            this.label_Available.TabIndex = 12;
            this.label_Available.Text = " ";
            // 
            // label_TotalEquipment
            // 
            this.label_TotalEquipment.AutoSize = true;
            this.label_TotalEquipment.Location = new System.Drawing.Point(234, 529);
            this.label_TotalEquipment.Name = "label_TotalEquipment";
            this.label_TotalEquipment.Size = new System.Drawing.Size(13, 20);
            this.label_TotalEquipment.TabIndex = 11;
            this.label_TotalEquipment.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(136, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Damaged :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(145, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "On Loan :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(141, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Available :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(525, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Categories in used :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Equipments :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(602, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Equipment Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 27);
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
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.IsDockedInsideChartArea = false;
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(483, 67);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(442, 328);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.IsDockedInsideChartArea = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(24, 67);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "s1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(442, 328);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox_FilterByCat);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label_TotalEquipment2);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.b_eAdd);
            this.tabPage2.Controls.Add(this.b_eDelete);
            this.tabPage2.Controls.Add(this.b_eModify);
            this.tabPage2.Controls.Add(this.listView_eq);
            this.tabPage2.Controls.Add(this.textBox_Search);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(958, 619);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Equipment Inventory";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox_FilterByCat
            // 
            this.comboBox_FilterByCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_FilterByCat.FormattingEnabled = true;
            this.comboBox_FilterByCat.Location = new System.Drawing.Point(664, 42);
            this.comboBox_FilterByCat.Name = "comboBox_FilterByCat";
            this.comboBox_FilterByCat.Size = new System.Drawing.Size(266, 28);
            this.comboBox_FilterByCat.TabIndex = 16;
            this.comboBox_FilterByCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterByCat_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(660, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(160, 20);
            this.label17.TabIndex = 15;
            this.label17.Text = "Filter by Category :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(24, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 20);
            this.label16.TabIndex = 14;
            this.label16.Text = "Search by Name :";
            // 
            // label_TotalEquipment2
            // 
            this.label_TotalEquipment2.AutoSize = true;
            this.label_TotalEquipment2.Location = new System.Drawing.Point(419, 575);
            this.label_TotalEquipment2.Name = "label_TotalEquipment2";
            this.label_TotalEquipment2.Size = new System.Drawing.Size(13, 20);
            this.label_TotalEquipment2.TabIndex = 13;
            this.label_TotalEquipment2.Text = " ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(198, 575);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Total Found Equipments :";
            // 
            // b_eAdd
            // 
            this.b_eAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_eAdd.Location = new System.Drawing.Point(28, 566);
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
            this.b_eDelete.Location = new System.Drawing.Point(833, 566);
            this.b_eDelete.Name = "b_eDelete";
            this.b_eDelete.Size = new System.Drawing.Size(97, 38);
            this.b_eDelete.TabIndex = 10;
            this.b_eDelete.Text = "Remove";
            this.b_eDelete.UseVisualStyleBackColor = true;
            this.b_eDelete.Click += new System.EventHandler(this.b_eDelete_Click);
            // 
            // b_eModify
            // 
            this.b_eModify.Enabled = false;
            this.b_eModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_eModify.ForeColor = System.Drawing.Color.Green;
            this.b_eModify.Location = new System.Drawing.Point(730, 566);
            this.b_eModify.Name = "b_eModify";
            this.b_eModify.Size = new System.Drawing.Size(97, 38);
            this.b_eModify.TabIndex = 9;
            this.b_eModify.Text = "Modify";
            this.b_eModify.UseVisualStyleBackColor = true;
            this.b_eModify.Click += new System.EventHandler(this.b_eModify_Click);
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
            this.listView_eq.Location = new System.Drawing.Point(28, 83);
            this.listView_eq.Name = "listView_eq";
            this.listView_eq.Size = new System.Drawing.Size(902, 477);
            this.listView_eq.TabIndex = 7;
            this.listView_eq.UseCompatibleStateImageBehavior = false;
            this.listView_eq.View = System.Windows.Forms.View.Details;
            this.listView_eq.SelectedIndexChanged += new System.EventHandler(this.listView_eq_SelectedIndexChanged);
            // 
            // ch_ID
            // 
            this.ch_ID.Text = "ID";
            this.ch_ID.Width = 91;
            // 
            // ch_Name
            // 
            this.ch_Name.Text = "Name";
            this.ch_Name.Width = 150;
            // 
            // ch_Desc
            // 
            this.ch_Desc.Text = "Description";
            this.ch_Desc.Width = 150;
            // 
            // ch_Category
            // 
            this.ch_Category.Text = "Category";
            this.ch_Category.Width = 174;
            // 
            // ch_Cost
            // 
            this.ch_Cost.Text = "Cost";
            this.ch_Cost.Width = 100;
            // 
            // ch_CostPerDay
            // 
            this.ch_CostPerDay.Text = "Cost Per Day";
            this.ch_CostPerDay.Width = 120;
            // 
            // ch_Status
            // 
            this.ch_Status.Text = "Status";
            this.ch_Status.Width = 87;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(28, 43);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(615, 26);
            this.textBox_Search.TabIndex = 6;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label_TotalDamaged);
            this.tabPage3.Controls.Add(this.label_TotalAvailable);
            this.tabPage3.Controls.Add(this.label_TotalOnLoan);
            this.tabPage3.Controls.Add(this.button_ToAvailable);
            this.tabPage3.Controls.Add(this.button_ToDamaged);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.listView_damagedStatus);
            this.tabPage3.Controls.Add(this.listView_availableStatus);
            this.tabPage3.Controls.Add(this.listView_onloanStatus);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(958, 619);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Status Management";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label_TotalDamaged
            // 
            this.label_TotalDamaged.AutoSize = true;
            this.label_TotalDamaged.Location = new System.Drawing.Point(697, 264);
            this.label_TotalDamaged.Name = "label_TotalDamaged";
            this.label_TotalDamaged.Size = new System.Drawing.Size(23, 20);
            this.label_TotalDamaged.TabIndex = 15;
            this.label_TotalDamaged.Text = "( )";
            // 
            // label_TotalAvailable
            // 
            this.label_TotalAvailable.AutoSize = true;
            this.label_TotalAvailable.Location = new System.Drawing.Point(226, 264);
            this.label_TotalAvailable.Name = "label_TotalAvailable";
            this.label_TotalAvailable.Size = new System.Drawing.Size(23, 20);
            this.label_TotalAvailable.TabIndex = 14;
            this.label_TotalAvailable.Text = "( )";
            // 
            // label_TotalOnLoan
            // 
            this.label_TotalOnLoan.AutoSize = true;
            this.label_TotalOnLoan.Location = new System.Drawing.Point(221, 21);
            this.label_TotalOnLoan.Name = "label_TotalOnLoan";
            this.label_TotalOnLoan.Size = new System.Drawing.Size(23, 20);
            this.label_TotalOnLoan.TabIndex = 13;
            this.label_TotalOnLoan.Text = "( )";
            // 
            // button_ToAvailable
            // 
            this.button_ToAvailable.Enabled = false;
            this.button_ToAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ToAvailable.ForeColor = System.Drawing.Color.Green;
            this.button_ToAvailable.Location = new System.Drawing.Point(489, 565);
            this.button_ToAvailable.Name = "button_ToAvailable";
            this.button_ToAvailable.Size = new System.Drawing.Size(120, 38);
            this.button_ToAvailable.TabIndex = 12;
            this.button_ToAvailable.Text = "<   Available";
            this.button_ToAvailable.UseVisualStyleBackColor = true;
            this.button_ToAvailable.Click += new System.EventHandler(this.button_ToAvailable_Click);
            // 
            // button_ToDamaged
            // 
            this.button_ToDamaged.Enabled = false;
            this.button_ToDamaged.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ToDamaged.ForeColor = System.Drawing.Color.Red;
            this.button_ToDamaged.Location = new System.Drawing.Point(346, 565);
            this.button_ToDamaged.Name = "button_ToDamaged";
            this.button_ToDamaged.Size = new System.Drawing.Size(120, 38);
            this.button_ToDamaged.TabIndex = 11;
            this.button_ToDamaged.Text = "Damaged   >";
            this.button_ToDamaged.UseVisualStyleBackColor = true;
            this.button_ToDamaged.Click += new System.EventHandler(this.button_ToDamaged_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(485, 264);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(206, 24);
            this.label13.TabIndex = 7;
            this.label13.Text = "Damaged Equipment";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 24);
            this.label12.TabIndex = 6;
            this.label12.Text = "Available Equipment";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 24);
            this.label11.TabIndex = 5;
            this.label11.Text = "On Loan Equipment";
            // 
            // listView_damagedStatus
            // 
            this.listView_damagedStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chD_Eid,
            this.chD_Name,
            this.chD_Category});
            this.listView_damagedStatus.HideSelection = false;
            this.listView_damagedStatus.Location = new System.Drawing.Point(489, 291);
            this.listView_damagedStatus.Name = "listView_damagedStatus";
            this.listView_damagedStatus.Size = new System.Drawing.Size(444, 268);
            this.listView_damagedStatus.TabIndex = 2;
            this.listView_damagedStatus.UseCompatibleStateImageBehavior = false;
            this.listView_damagedStatus.View = System.Windows.Forms.View.Details;
            this.listView_damagedStatus.SelectedIndexChanged += new System.EventHandler(this.listView_damagedStatus_SelectedIndexChanged);
            // 
            // chD_Eid
            // 
            this.chD_Eid.Text = "ID";
            this.chD_Eid.Width = 85;
            // 
            // chD_Name
            // 
            this.chD_Name.Text = "Name";
            this.chD_Name.Width = 153;
            // 
            // chD_Category
            // 
            this.chD_Category.Text = "Category";
            this.chD_Category.Width = 202;
            // 
            // listView_availableStatus
            // 
            this.listView_availableStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            chA_Eid,
            this.chA_Name,
            this.chA_Category});
            this.listView_availableStatus.HideSelection = false;
            this.listView_availableStatus.Location = new System.Drawing.Point(22, 291);
            this.listView_availableStatus.Name = "listView_availableStatus";
            this.listView_availableStatus.Size = new System.Drawing.Size(444, 268);
            this.listView_availableStatus.TabIndex = 1;
            this.listView_availableStatus.UseCompatibleStateImageBehavior = false;
            this.listView_availableStatus.View = System.Windows.Forms.View.Details;
            this.listView_availableStatus.SelectedIndexChanged += new System.EventHandler(this.listView_availableStatus_SelectedIndexChanged);
            // 
            // chA_Name
            // 
            this.chA_Name.Text = "Name";
            this.chA_Name.Width = 152;
            // 
            // chA_Category
            // 
            this.chA_Category.Text = " Category";
            this.chA_Category.Width = 185;
            // 
            // listView_onloanStatus
            // 
            this.listView_onloanStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chOL_Eid,
            this.chOL_Name,
            this.chOL_Category,
            this.chOL_PID,
            this.chOL_PName,
            this.chOL_LID,
            this.chOL_PDuration});
            this.listView_onloanStatus.HideSelection = false;
            this.listView_onloanStatus.Location = new System.Drawing.Point(22, 47);
            this.listView_onloanStatus.Name = "listView_onloanStatus";
            this.listView_onloanStatus.Size = new System.Drawing.Size(911, 201);
            this.listView_onloanStatus.TabIndex = 0;
            this.listView_onloanStatus.UseCompatibleStateImageBehavior = false;
            this.listView_onloanStatus.View = System.Windows.Forms.View.Details;
            this.listView_onloanStatus.SelectedIndexChanged += new System.EventHandler(this.listView_onloanStatus_SelectedIndexChanged);
            // 
            // chOL_Eid
            // 
            this.chOL_Eid.Text = "ID";
            this.chOL_Eid.Width = 85;
            // 
            // chOL_Name
            // 
            this.chOL_Name.Text = "Name";
            this.chOL_Name.Width = 153;
            // 
            // chOL_Category
            // 
            this.chOL_Category.Text = "Category";
            this.chOL_Category.Width = 202;
            // 
            // chOL_PID
            // 
            this.chOL_PID.Text = "Project ID";
            this.chOL_PID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chOL_PID.Width = 85;
            // 
            // chOL_PName
            // 
            this.chOL_PName.Text = "Project Name";
            this.chOL_PName.Width = 222;
            // 
            // chOL_PDuration
            // 
            this.chOL_PDuration.Text = "Duration";
            this.chOL_PDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chOL_PDuration.Width = 75;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCategoryToolStripMenuItem,
            this.categorizationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 24);
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
            // chOL_LID
            // 
            this.chOL_LID.Text = "Leader ID";
            this.chOL_LID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chOL_LID.Width = 85;
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
            this.ClientSize = new System.Drawing.Size(967, 680);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.ListView listView_eq;
        private System.Windows.Forms.ColumnHeader ch_ID;
        private System.Windows.Forms.ColumnHeader ch_Name;
        private System.Windows.Forms.ColumnHeader ch_Desc;
        private System.Windows.Forms.ColumnHeader ch_Category;
        private System.Windows.Forms.ColumnHeader ch_Cost;
        private System.Windows.Forms.ColumnHeader ch_CostPerDay;
        private System.Windows.Forms.ColumnHeader ch_Status;
        private System.Windows.Forms.TextBox textBox_Search;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_TotalEqCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listView_damagedStatus;
        private System.Windows.Forms.ListView listView_availableStatus;
        private System.Windows.Forms.ListView listView_onloanStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_ToAvailable;
        private System.Windows.Forms.Button button_ToDamaged;
        private System.Windows.Forms.ColumnHeader chA_Name;
        private System.Windows.Forms.ColumnHeader chA_Category;
        private System.Windows.Forms.ColumnHeader chD_Eid;
        private System.Windows.Forms.ColumnHeader chD_Name;
        private System.Windows.Forms.ColumnHeader chD_Category;
        private System.Windows.Forms.ColumnHeader chOL_Eid;
        private System.Windows.Forms.ColumnHeader chOL_Name;
        private System.Windows.Forms.ColumnHeader chOL_Category;
        private System.Windows.Forms.Label label_TotalDamaged;
        private System.Windows.Forms.Label label_TotalAvailable;
        private System.Windows.Forms.Label label_TotalOnLoan;
        private System.Windows.Forms.Label label_totalCatUsed;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox_FilterByCat;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ColumnHeader chOL_PID;
        private System.Windows.Forms.ColumnHeader chOL_PName;
        private System.Windows.Forms.ColumnHeader chOL_PDuration;
        private System.Windows.Forms.ColumnHeader chOL_LID;
    }
}