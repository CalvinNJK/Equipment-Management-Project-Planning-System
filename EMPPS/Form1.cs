﻿using EMPPS.Project_Planning;
using EMPPS.Equipment_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_em_Click(object sender, EventArgs e)
        {
            var em_win = new EM_Main();
            em_win.Show();
            this.Hide();
            
        }

        private void button_pp_Click(object sender, EventArgs e)
        {
            var pp_win = new PP_Main();
            pp_win.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
