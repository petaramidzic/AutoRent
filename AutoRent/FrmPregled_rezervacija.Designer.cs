namespace AutoRent
{
    partial class FrmPregled_rezervacija
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
            this.lbRezervacije = new System.Windows.Forms.ListBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnNovaRezervacija = new System.Windows.Forms.Button();
            this.lblVaseRezervacije = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbRezervacije
            // 
            this.lbRezervacije.FormattingEnabled = true;
            this.lbRezervacije.Location = new System.Drawing.Point(35, 47);
            this.lbRezervacije.Name = "lbRezervacije";
            this.lbRezervacije.Size = new System.Drawing.Size(698, 147);
            this.lbRezervacije.TabIndex = 0;
            this.lbRezervacije.SelectedValueChanged += new System.EventHandler(this.lbRezervacije_SelectedValueChanged);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(96, 228);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(98, 23);
            this.btnObrisi.TabIndex = 1;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnNovaRezervacija
            // 
            this.btnNovaRezervacija.Location = new System.Drawing.Point(493, 228);
            this.btnNovaRezervacija.Name = "btnNovaRezervacija";
            this.btnNovaRezervacija.Size = new System.Drawing.Size(103, 23);
            this.btnNovaRezervacija.TabIndex = 2;
            this.btnNovaRezervacija.Text = "Nova rezervacija";
            this.btnNovaRezervacija.UseVisualStyleBackColor = true;
            this.btnNovaRezervacija.Click += new System.EventHandler(this.btnNovaRezervacija_Click);
            // 
            // lblVaseRezervacije
            // 
            this.lblVaseRezervacije.AutoSize = true;
            this.lblVaseRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaseRezervacije.Location = new System.Drawing.Point(35, 13);
            this.lblVaseRezervacije.Name = "lblVaseRezervacije";
            this.lblVaseRezervacije.Size = new System.Drawing.Size(146, 20);
            this.lblVaseRezervacije.TabIndex = 3;
            this.lblVaseRezervacije.Text = "Vase rezervacije:";
            // 
            // FrmPregled_rezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVaseRezervacije);
            this.Controls.Add(this.btnNovaRezervacija);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lbRezervacije);
            this.Name = "FrmPregled_rezervacija";
            this.Text = "FrmPregled_rezervacija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbRezervacije;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnNovaRezervacija;
        private System.Windows.Forms.Label lblVaseRezervacije;
    }
}