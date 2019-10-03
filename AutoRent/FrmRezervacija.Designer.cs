namespace AutoRent
{
    partial class FrmRezervacija
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
            this.lblMarka = new System.Windows.Forms.Label();
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.lblGodiste = new System.Windows.Forms.Label();
            this.cbGodiste = new System.Windows.Forms.ComboBox();
            this.lblKubikaza = new System.Windows.Forms.Label();
            this.cbKubikaza = new System.Windows.Forms.ComboBox();
            this.lblKaroserija = new System.Windows.Forms.Label();
            this.cbKaroserija = new System.Windows.Forms.ComboBox();
            this.lblBrojVrata = new System.Windows.Forms.Label();
            this.cbBrojVrata = new System.Windows.Forms.ComboBox();
            this.lblGorivo = new System.Windows.Forms.Label();
            this.cbGorivo = new System.Windows.Forms.ComboBox();
            this.lblPogon = new System.Windows.Forms.Label();
            this.cbPogon = new System.Windows.Forms.ComboBox();
            this.lblMenjac = new System.Windows.Forms.Label();
            this.cbMenjac = new System.Windows.Forms.ComboBox();
            this.btnPrikaziAutomobile = new System.Windows.Forms.Button();
            this.lbPrikazPonuda = new System.Windows.Forms.ListBox();
            this.lblDatumOd = new System.Windows.Forms.Label();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.lblDatumDo = new System.Windows.Forms.Label();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.lblCenaRezervacije = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.btnRezervisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(39, 41);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(88, 13);
            this.lblMarka.TabIndex = 0;
            this.lblMarka.Text = "Odaberite marku:";
            // 
            // cbMarka
            // 
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(42, 57);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(121, 21);
            this.cbMarka.TabIndex = 1;
            this.cbMarka.SelectedValueChanged += new System.EventHandler(this.cbMarka_SelectedValueChanged);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(42, 108);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(87, 13);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Odaberite model:";
            // 
            // cbModel
            // 
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(45, 125);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(121, 21);
            this.cbModel.TabIndex = 3;
            this.cbModel.SelectedValueChanged += new System.EventHandler(this.cbModel_SelectedValueChanged);
            // 
            // lblGodiste
            // 
            this.lblGodiste.AutoSize = true;
            this.lblGodiste.Location = new System.Drawing.Point(42, 169);
            this.lblGodiste.Name = "lblGodiste";
            this.lblGodiste.Size = new System.Drawing.Size(93, 13);
            this.lblGodiste.TabIndex = 4;
            this.lblGodiste.Text = "Odaberite godiste:";
            // 
            // cbGodiste
            // 
            this.cbGodiste.FormattingEnabled = true;
            this.cbGodiste.Location = new System.Drawing.Point(45, 186);
            this.cbGodiste.Name = "cbGodiste";
            this.cbGodiste.Size = new System.Drawing.Size(121, 21);
            this.cbGodiste.TabIndex = 5;
            this.cbGodiste.SelectedValueChanged += new System.EventHandler(this.cbGodiste_SelectedValueChanged);
            // 
            // lblKubikaza
            // 
            this.lblKubikaza.AutoSize = true;
            this.lblKubikaza.Location = new System.Drawing.Point(234, 41);
            this.lblKubikaza.Name = "lblKubikaza";
            this.lblKubikaza.Size = new System.Drawing.Size(102, 13);
            this.lblKubikaza.TabIndex = 6;
            this.lblKubikaza.Text = "Odaberite kubikazu:";
            // 
            // cbKubikaza
            // 
            this.cbKubikaza.FormattingEnabled = true;
            this.cbKubikaza.Location = new System.Drawing.Point(237, 56);
            this.cbKubikaza.Name = "cbKubikaza";
            this.cbKubikaza.Size = new System.Drawing.Size(121, 21);
            this.cbKubikaza.TabIndex = 7;
            this.cbKubikaza.SelectedValueChanged += new System.EventHandler(this.cbKubikaza_SelectedValueChanged);
            // 
            // lblKaroserija
            // 
            this.lblKaroserija.AutoSize = true;
            this.lblKaroserija.Location = new System.Drawing.Point(237, 108);
            this.lblKaroserija.Name = "lblKaroserija";
            this.lblKaroserija.Size = new System.Drawing.Size(104, 13);
            this.lblKaroserija.TabIndex = 8;
            this.lblKaroserija.Text = "Odaberite karoseriju:";
            // 
            // cbKaroserija
            // 
            this.cbKaroserija.FormattingEnabled = true;
            this.cbKaroserija.Location = new System.Drawing.Point(237, 124);
            this.cbKaroserija.Name = "cbKaroserija";
            this.cbKaroserija.Size = new System.Drawing.Size(121, 21);
            this.cbKaroserija.TabIndex = 9;
            this.cbKaroserija.SelectedValueChanged += new System.EventHandler(this.cbKaroserija_SelectedValueChanged);
            // 
            // lblBrojVrata
            // 
            this.lblBrojVrata.AutoSize = true;
            this.lblBrojVrata.Location = new System.Drawing.Point(237, 169);
            this.lblBrojVrata.Name = "lblBrojVrata";
            this.lblBrojVrata.Size = new System.Drawing.Size(103, 13);
            this.lblBrojVrata.TabIndex = 10;
            this.lblBrojVrata.Text = "Odaberite broj vrata:";
            // 
            // cbBrojVrata
            // 
            this.cbBrojVrata.FormattingEnabled = true;
            this.cbBrojVrata.Location = new System.Drawing.Point(237, 185);
            this.cbBrojVrata.Name = "cbBrojVrata";
            this.cbBrojVrata.Size = new System.Drawing.Size(121, 21);
            this.cbBrojVrata.TabIndex = 11;
            this.cbBrojVrata.SelectedValueChanged += new System.EventHandler(this.cbBrojVrata_SelectedValueChanged);
            // 
            // lblGorivo
            // 
            this.lblGorivo.AutoSize = true;
            this.lblGorivo.Location = new System.Drawing.Point(446, 41);
            this.lblGorivo.Name = "lblGorivo";
            this.lblGorivo.Size = new System.Drawing.Size(88, 13);
            this.lblGorivo.TabIndex = 12;
            this.lblGorivo.Text = "Odaberite gorivo:";
            // 
            // cbGorivo
            // 
            this.cbGorivo.FormattingEnabled = true;
            this.cbGorivo.Location = new System.Drawing.Point(449, 56);
            this.cbGorivo.Name = "cbGorivo";
            this.cbGorivo.Size = new System.Drawing.Size(121, 21);
            this.cbGorivo.TabIndex = 13;
            this.cbGorivo.SelectedValueChanged += new System.EventHandler(this.cbGorivo_SelectedValueChanged);
            // 
            // lblPogon
            // 
            this.lblPogon.AutoSize = true;
            this.lblPogon.Location = new System.Drawing.Point(449, 108);
            this.lblPogon.Name = "lblPogon";
            this.lblPogon.Size = new System.Drawing.Size(89, 13);
            this.lblPogon.TabIndex = 14;
            this.lblPogon.Text = "Odaberite pogon:";
            // 
            // cbPogon
            // 
            this.cbPogon.FormattingEnabled = true;
            this.cbPogon.Location = new System.Drawing.Point(449, 125);
            this.cbPogon.Name = "cbPogon";
            this.cbPogon.Size = new System.Drawing.Size(121, 21);
            this.cbPogon.TabIndex = 15;
            this.cbPogon.SelectedValueChanged += new System.EventHandler(this.cbPogon_SelectedValueChanged);
            // 
            // lblMenjac
            // 
            this.lblMenjac.AutoSize = true;
            this.lblMenjac.Location = new System.Drawing.Point(449, 169);
            this.lblMenjac.Name = "lblMenjac";
            this.lblMenjac.Size = new System.Drawing.Size(93, 13);
            this.lblMenjac.TabIndex = 16;
            this.lblMenjac.Text = "Odaberite menjac:";
            // 
            // cbMenjac
            // 
            this.cbMenjac.FormattingEnabled = true;
            this.cbMenjac.Location = new System.Drawing.Point(449, 185);
            this.cbMenjac.Name = "cbMenjac";
            this.cbMenjac.Size = new System.Drawing.Size(121, 21);
            this.cbMenjac.TabIndex = 17;
            this.cbMenjac.SelectedValueChanged += new System.EventHandler(this.cbMenjac_SelectedValueChanged);
            // 
            // btnPrikaziAutomobile
            // 
            this.btnPrikaziAutomobile.Location = new System.Drawing.Point(45, 228);
            this.btnPrikaziAutomobile.Name = "btnPrikaziAutomobile";
            this.btnPrikaziAutomobile.Size = new System.Drawing.Size(525, 40);
            this.btnPrikaziAutomobile.TabIndex = 18;
            this.btnPrikaziAutomobile.Text = "Prikazi dostupne termine odabranog automobila";
            this.btnPrikaziAutomobile.UseVisualStyleBackColor = true;
            this.btnPrikaziAutomobile.Click += new System.EventHandler(this.btnPrikaziAutomobile_Click);
            // 
            // lbPrikazPonuda
            // 
            this.lbPrikazPonuda.FormattingEnabled = true;
            this.lbPrikazPonuda.Location = new System.Drawing.Point(45, 280);
            this.lbPrikazPonuda.Name = "lbPrikazPonuda";
            this.lbPrikazPonuda.Size = new System.Drawing.Size(525, 108);
            this.lbPrikazPonuda.TabIndex = 19;
            this.lbPrikazPonuda.SelectedValueChanged += new System.EventHandler(this.lbPrikazPonuda_SelectedValueChanged);
            // 
            // lblDatumOd
            // 
            this.lblDatumOd.AutoSize = true;
            this.lblDatumOd.Location = new System.Drawing.Point(45, 402);
            this.lblDatumOd.Name = "lblDatumOd";
            this.lblDatumOd.Size = new System.Drawing.Size(147, 13);
            this.lblDatumOd.TabIndex = 20;
            this.lblDatumOd.Text = "Odaberite datum preuzimanja:";
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Location = new System.Drawing.Point(48, 419);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumOd.TabIndex = 21;
            this.dtpDatumOd.ValueChanged += new System.EventHandler(this.dtpDatumOd_ValueChanged);
            // 
            // lblDatumDo
            // 
            this.lblDatumDo.AutoSize = true;
            this.lblDatumDo.Location = new System.Drawing.Point(48, 460);
            this.lblDatumDo.Name = "lblDatumDo";
            this.lblDatumDo.Size = new System.Drawing.Size(132, 13);
            this.lblDatumDo.TabIndex = 22;
            this.lblDatumDo.Text = "Odaberite datum vracanja:";
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Location = new System.Drawing.Point(51, 477);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumDo.TabIndex = 23;
            this.dtpDatumDo.ValueChanged += new System.EventHandler(this.dtpDatumDo_ValueChanged);
            // 
            // lblCenaRezervacije
            // 
            this.lblCenaRezervacije.AutoSize = true;
            this.lblCenaRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenaRezervacije.Location = new System.Drawing.Point(348, 444);
            this.lblCenaRezervacije.Name = "lblCenaRezervacije";
            this.lblCenaRezervacije.Size = new System.Drawing.Size(198, 18);
            this.lblCenaRezervacije.TabIndex = 24;
            this.lblCenaRezervacije.Text = "Ukupna cena rezervacije:";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(435, 477);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(100, 20);
            this.txtCena.TabIndex = 25;
            // 
            // btnRezervisi
            // 
            this.btnRezervisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervisi.Location = new System.Drawing.Point(51, 518);
            this.btnRezervisi.Name = "btnRezervisi";
            this.btnRezervisi.Size = new System.Drawing.Size(519, 42);
            this.btnRezervisi.TabIndex = 26;
            this.btnRezervisi.Text = "Rezervisi";
            this.btnRezervisi.UseVisualStyleBackColor = true;
            this.btnRezervisi.Click += new System.EventHandler(this.btnRezervisi_Click);
            // 
            // FrmRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.btnRezervisi);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.lblCenaRezervacije);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.lblDatumDo);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.lblDatumOd);
            this.Controls.Add(this.lbPrikazPonuda);
            this.Controls.Add(this.btnPrikaziAutomobile);
            this.Controls.Add(this.cbMenjac);
            this.Controls.Add(this.lblMenjac);
            this.Controls.Add(this.cbPogon);
            this.Controls.Add(this.lblPogon);
            this.Controls.Add(this.cbGorivo);
            this.Controls.Add(this.lblGorivo);
            this.Controls.Add(this.cbBrojVrata);
            this.Controls.Add(this.lblBrojVrata);
            this.Controls.Add(this.cbKaroserija);
            this.Controls.Add(this.lblKaroserija);
            this.Controls.Add(this.cbKubikaza);
            this.Controls.Add(this.lblKubikaza);
            this.Controls.Add(this.cbGodiste);
            this.Controls.Add(this.lblGodiste);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.cbMarka);
            this.Controls.Add(this.lblMarka);
            this.Name = "FrmRezervacija";
            this.Text = "FrmRezervacija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.Label lblGodiste;
        private System.Windows.Forms.ComboBox cbGodiste;
        private System.Windows.Forms.Label lblKubikaza;
        private System.Windows.Forms.ComboBox cbKubikaza;
        private System.Windows.Forms.Label lblKaroserija;
        private System.Windows.Forms.ComboBox cbKaroserija;
        private System.Windows.Forms.Label lblBrojVrata;
        private System.Windows.Forms.ComboBox cbBrojVrata;
        private System.Windows.Forms.Label lblGorivo;
        private System.Windows.Forms.ComboBox cbGorivo;
        private System.Windows.Forms.Label lblPogon;
        private System.Windows.Forms.ComboBox cbPogon;
        private System.Windows.Forms.Label lblMenjac;
        private System.Windows.Forms.ComboBox cbMenjac;
        private System.Windows.Forms.Button btnPrikaziAutomobile;
        private System.Windows.Forms.ListBox lbPrikazPonuda;
        private System.Windows.Forms.Label lblDatumOd;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.Label lblDatumDo;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.Label lblCenaRezervacije;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Button btnRezervisi;
    }
}