namespace AutoRent
{
    partial class Administracija
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.automobilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kupacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ponudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automobilToolStripMenuItem,
            this.kupacToolStripMenuItem,
            this.ponudaToolStripMenuItem,
            this.rezervacijeToolStripMenuItem,
            this.statistikaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // automobilToolStripMenuItem
            // 
            this.automobilToolStripMenuItem.Name = "automobilToolStripMenuItem";
            this.automobilToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.automobilToolStripMenuItem.Text = "Automobil";
            this.automobilToolStripMenuItem.Click += new System.EventHandler(this.automobilToolStripMenuItem_Click);
            // 
            // kupacToolStripMenuItem
            // 
            this.kupacToolStripMenuItem.Name = "kupacToolStripMenuItem";
            this.kupacToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.kupacToolStripMenuItem.Text = "Kupac";
            this.kupacToolStripMenuItem.Click += new System.EventHandler(this.kupacToolStripMenuItem_Click);
            // 
            // ponudaToolStripMenuItem
            // 
            this.ponudaToolStripMenuItem.Name = "ponudaToolStripMenuItem";
            this.ponudaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ponudaToolStripMenuItem.Text = "Ponuda";
            this.ponudaToolStripMenuItem.Click += new System.EventHandler(this.ponudaToolStripMenuItem_Click);
            // 
            // rezervacijeToolStripMenuItem
            // 
            this.rezervacijeToolStripMenuItem.Name = "rezervacijeToolStripMenuItem";
            this.rezervacijeToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.rezervacijeToolStripMenuItem.Text = "Rezervacije";
            this.rezervacijeToolStripMenuItem.Click += new System.EventHandler(this.rezervacijeToolStripMenuItem_Click);
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            this.statistikaToolStripMenuItem.Click += new System.EventHandler(this.statistikaToolStripMenuItem_Click);
            // 
            // Administracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Administracija";
            this.Text = "Administracija";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administracija_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem automobilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kupacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ponudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
    }
}