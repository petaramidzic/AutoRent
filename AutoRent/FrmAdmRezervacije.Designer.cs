namespace AutoRent
{
    partial class FrmAdmRezervacije
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
            this.cbPregledKupaca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPregledRezervacija = new System.Windows.Forms.ListBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPregledKupaca
            // 
            this.cbPregledKupaca.FormattingEnabled = true;
            this.cbPregledKupaca.Location = new System.Drawing.Point(269, 98);
            this.cbPregledKupaca.Name = "cbPregledKupaca";
            this.cbPregledKupaca.Size = new System.Drawing.Size(287, 21);
            this.cbPregledKupaca.TabIndex = 0;
            this.cbPregledKupaca.SelectedIndexChanged += new System.EventHandler(this.cbPregledKupaca_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pregled rezervacija po kupcima";
            // 
            // lbPregledRezervacija
            // 
            this.lbPregledRezervacija.FormattingEnabled = true;
            this.lbPregledRezervacija.Location = new System.Drawing.Point(58, 142);
            this.lbPregledRezervacija.Name = "lbPregledRezervacija";
            this.lbPregledRezervacija.Size = new System.Drawing.Size(658, 173);
            this.lbPregledRezervacija.TabIndex = 2;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(326, 353);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(104, 23);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // FrmAdmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lbPregledRezervacija);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPregledKupaca);
            this.Name = "FrmAdmRezervacije";
            this.Text = "FrmAdmRezervacije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPregledKupaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbPregledRezervacija;
        private System.Windows.Forms.Button btnObrisi;
    }
}