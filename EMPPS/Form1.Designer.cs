namespace EMPPS
{
    partial class Form1
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
            this.button_em = new System.Windows.Forms.Button();
            this.button_pp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_em
            // 
            this.button_em.Location = new System.Drawing.Point(268, 112);
            this.button_em.Name = "button_em";
            this.button_em.Size = new System.Drawing.Size(260, 23);
            this.button_em.TabIndex = 0;
            this.button_em.Text = "Equipment Management";
            this.button_em.UseVisualStyleBackColor = true;
            this.button_em.Click += new System.EventHandler(this.button_em_Click);
            // 
            // button_pp
            // 
            this.button_pp.Location = new System.Drawing.Point(268, 172);
            this.button_pp.Name = "button_pp";
            this.button_pp.Size = new System.Drawing.Size(245, 23);
            this.button_pp.TabIndex = 1;
            this.button_pp.Text = "Project Planning";
            this.button_pp.UseVisualStyleBackColor = true;
            this.button_pp.Click += new System.EventHandler(this.button_pp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_pp);
            this.Controls.Add(this.button_em);
            this.Name = "Form1";
            this.Text = "Equipment Management & Project Planning Systen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_em;
        private System.Windows.Forms.Button button_pp;
    }
}

