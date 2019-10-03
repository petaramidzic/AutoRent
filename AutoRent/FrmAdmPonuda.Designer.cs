namespace AutoRent
{
    partial class FrmAdmPonuda
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
            this.lbNaslov = new System.Windows.Forms.Label();
            this.lbAutomobil = new System.Windows.Forms.Label();
            this.lbAutomobili = new System.Windows.Forms.ListBox();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.lblDatumOd = new System.Windows.Forms.Label();
            this.lblDatumDo = new System.Windows.Forms.Label();
            this.lblCenapoDanu = new System.Windows.Forms.Label();
            this.lbPonude = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbNaslov
            // 
            this.lbNaslov.AutoSize = true;
            this.lbNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNaslov.Location = new System.Drawing.Point(292, 26);
            this.lbNaslov.Name = "lbNaslov";
            this.lbNaslov.Size = new System.Drawing.Size(172, 24);
            this.lbNaslov.TabIndex = 0;
            this.lbNaslov.Text = "Kreiranje ponude";
            // 
            // lbAutomobil
            // 
            this.lbAutomobil.AutoSize = true;
            this.lbAutomobil.Location = new System.Drawing.Point(35, 91);
            this.lbAutomobil.Name = "lbAutomobil";
            this.lbAutomobil.Size = new System.Drawing.Size(126, 13);
            this.lbAutomobil.TabIndex = 1;
            this.lbAutomobil.Text = "Izaberite automobil iz liste";
            // 
            // lbAutomobili
            // 
            this.lbAutomobili.FormattingEnabled = true;
            this.lbAutomobili.Location = new System.Drawing.Point(38, 118);
            this.lbAutomobili.Name = "lbAutomobili";
            this.lbAutomobili.Size = new System.Drawing.Size(397, 134);
            this.lbAutomobili.TabIndex = 2;
            this.lbAutomobili.SelectedValueChanged += new System.EventHandler(this.lbAutomobili_SelectedValueChanged);
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Location = new System.Drawing.Point(550, 117);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumOd.TabIndex = 3;
            this.dtpDatumOd.ValueChanged += new System.EventHandler(this.dtpDatumOd_ValueChanged);
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Location = new System.Drawing.Point(550, 171);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumDo.TabIndex = 4;
            this.dtpDatumDo.ValueChanged += new System.EventHandler(this.dtpDatumDo_ValueChanged);
            // 
            // lblDatumOd
            // 
            this.lblDatumOd.AutoSize = true;
            this.lblDatumOd.Location = new System.Drawing.Point(485, 124);
            this.lblDatumOd.Name = "lblDatumOd";
            this.lblDatumOd.Size = new System.Drawing.Size(56, 13);
            this.lblDatumOd.TabIndex = 5;
            this.lblDatumOd.Text = "Datum od:";
            // 
            // lblDatumDo
            // 
            this.lblDatumDo.AutoSize = true;
            this.lblDatumDo.Location = new System.Drawing.Point(485, 178);
            this.lblDatumDo.Name = "lblDatumDo";
            this.lblDatumDo.Size = new System.Drawing.Size(56, 13);
            this.lblDatumDo.TabIndex = 6;
            this.lblDatumDo.Text = "Datum do:";
            // 
            // lblCenapoDanu
            // 
            this.lblCenapoDanu.AutoSize = true;
            this.lblCenapoDanu.Location = new System.Drawing.Point(467, 227);
            this.lblCenapoDanu.Name = "lblCenapoDanu";
            this.lblCenapoDanu.Size = new System.Drawing.Size(77, 13);
            this.lblCenapoDanu.TabIndex = 8;
            this.lblCenapoDanu.Text = "Cena po danu:";
            // 
            // lbPonude
            // 
            this.lbPonude.FormattingEnabled = true;
            this.lbPonude.Location = new System.Drawing.Point(38, 309);
            this.lbPonude.Name = "lbPonude";
            this.lbPonude.Size = new System.Drawing.Size(616, 147);
            this.lbPonude.TabIndex = 9;
            this.lbPonude.SelectedValueChanged += new System.EventHandler(this.lbPonude_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Trenutne ponude";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(675, 263);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(675, 388);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmeni.TabIndex = 12;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(675, 433);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 13;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(650, 220);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(100, 20);
            this.txtCena.TabIndex = 14;
            // 
            // FrmAdmPonuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPonude);
            this.Controls.Add(this.lblCenapoDanu);
            this.Controls.Add(this.lblDatumDo);
            this.Controls.Add(this.lblDatumOd);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.lbAutomobili);
            this.Controls.Add(this.lbAutomobil);
            this.Controls.Add(this.lbNaslov);
            this.Name = "FrmAdmPonuda";
            this.Text = "FrmAdmPonuda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNaslov;
        private System.Windows.Forms.Label lbAutomobil;
        private System.Windows.Forms.ListBox lbAutomobili;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.Label lblDatumOd;
        private System.Windows.Forms.Label lblDatumDo;
        private System.Windows.Forms.Label lblCenapoDanu;
        private System.Windows.Forms.ListBox lbPonude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.TextBox txtCena;
    }
}