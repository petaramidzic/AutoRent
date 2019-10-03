using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AutoRent
{
    public partial class FrmRezervacija : Form
    {
        List<Automobil> automobili;
        List<Ponuda> ponude;
        List<Rezervacije> rezervacije;
        Korisnik korisnik = new Korisnik();
        private int id_korisnika;

        string datoteka_automobili = "automobili.bin";
        string datoteka_ponude = "ponude.bin";
        string datoteka_rezervacije = "rezervacije.bin";

        public FrmRezervacija(int id)
        {
            InitializeComponent();
            id_korisnika = id;
            automobili = (List<Automobil>)Datoteka.Procitaj(datoteka_automobili);
            ponude = (List<Ponuda>)Datoteka.Procitaj(datoteka_ponude);
            rezervacije = (List<Rezervacije>)Datoteka.Procitaj(datoteka_rezervacije);
            UcitajMarku();
        }

        private void UcitajMarku()
        {
            var marke_start = automobili.Select(m => m.Marka).Distinct();

            cbMarka.Items.Add("--Izaberite Marku--");
            foreach (var marka in marke_start)
            {
                cbMarka.Items.Add(marka);
            }
            cbMarka.SelectedIndex = 0;
            dtpDatumOd.Enabled = false;
            dtpDatumDo.Enabled = false;
        }

        private void cbMarka_SelectedValueChanged(object sender, EventArgs e)
        {
            var modeli = (from m in automobili
                        where m.Marka == (string)cbMarka.SelectedItem
                        select m.Model).Distinct();

            cbModel.Items.Clear();

            foreach (var model in modeli)
            {
                cbModel.Items.Add(model);
                if (cbModel.Items.Count <= 1)
                {
                    cbModel.SelectedIndex = 0;
                }
            }
            lbPrikazPonuda.Items.Clear();
        }

        private void cbModel_SelectedValueChanged(object sender, EventArgs e)
        {
            var godista = (from m in automobili
                         where m.Model == (string)cbModel.SelectedItem &&
                               m.Marka == (string)cbMarka.SelectedItem
                         select m.Godiste).Distinct();

            cbGodiste.Items.Clear();

            foreach (var godiste in godista)
            {
                cbGodiste.Items.Add(godiste);
                if (cbGodiste.Items.Count <= 1)
                {
                    cbGodiste.SelectedIndex = 0;
                }
            }
            lbPrikazPonuda.Items.Clear();
        }

        private void cbGodiste_SelectedValueChanged(object sender, EventArgs e)
        {
            var kubikaze = (from g in automobili
                          where g.Godiste == (int)cbGodiste.SelectedItem &&
                                g.Model == (string)cbModel.SelectedItem &&
                                g.Marka == (string)cbMarka.SelectedItem
                          select g.Kubikaza).Distinct();

            cbKubikaza.Items.Clear();

            foreach (var kubikaza in kubikaze)
            {
                cbKubikaza.Items.Add(kubikaza);
                if (cbKubikaza.Items.Count <= 1)
                {
                    cbKubikaza.SelectedIndex = 0;
                }
            }
            lbPrikazPonuda.Items.Clear();
        }

        private void cbKubikaza_SelectedValueChanged(object sender, EventArgs e)
        {
            var karoserije = (from k in automobili
                           where k.Kubikaza == (int)cbKubikaza.SelectedItem &&
                                 k.Godiste == (int)cbGodiste.SelectedItem &&
                                 k.Model == (string)cbModel.SelectedItem &&
                                 k.Marka == (string)cbMarka.SelectedItem
                           select k.Karoserija).Distinct();

            cbKaroserija.Items.Clear();

            foreach (var karoserija in karoserije)
            {
                cbKaroserija.Items.Add(karoserija);
                if (cbKaroserija.Items.Count <= 1)
                {
                    cbKaroserija.SelectedIndex = 0;
                }
            }
            lbPrikazPonuda.Items.Clear();
        }

        private void cbKaroserija_SelectedValueChanged(object sender, EventArgs e)
        {
            var broj_vrata = (from k in automobili
                             where k.Karoserija == (string)cbKaroserija.SelectedItem &&
                                   k.Kubikaza == (int)cbKubikaza.SelectedItem &&
                                   k.Godiste == (int)cbGodiste.SelectedItem &&
                                   k.Model == (string)cbModel.SelectedItem &&
                                   k.Marka == (string)cbMarka.SelectedItem
                             select k.Broj_vrata).Distinct();

            cbBrojVrata.Items.Clear();

            foreach (var vrata in broj_vrata)
            {
                cbBrojVrata.Items.Add(vrata);
                if (cbBrojVrata.Items.Count <= 1)
                {
                    cbBrojVrata.SelectedIndex = 0;
                }
            }
            lbPrikazPonuda.Items.Clear();
        }

        private void cbBrojVrata_SelectedValueChanged(object sender, EventArgs e)
        {
            var goriva = (from v in automobili
                        where v.Broj_vrata == (string)cbBrojVrata.SelectedItem &&
                              v.Karoserija == (string)cbKaroserija.SelectedItem &&
                              v.Kubikaza == (int)cbKubikaza.SelectedItem &&
                              v.Godiste == (int)cbGodiste.SelectedItem &&
                              v.Model == (string)cbModel.SelectedItem &&
                              v.Marka == (string)cbMarka.SelectedItem
                        select v.Gorivo).Distinct();

            cbGorivo.Items.Clear();

            foreach (var gorivo in goriva)
            {
                cbGorivo.Items.Add(gorivo);
                if (cbGorivo.Items.Count <= 1)
                {
                    cbGorivo.SelectedIndex = 0;
                }
            }
            lbPrikazPonuda.Items.Clear();
        }

        private void cbGorivo_SelectedValueChanged(object sender, EventArgs e)
        {
            var pogoni = (from g in automobili
                         where g.Gorivo == (string)cbGorivo.SelectedItem &&
                               g.Broj_vrata == (string)cbBrojVrata.SelectedItem &&
                               g.Karoserija == (string)cbKaroserija.SelectedItem &&
                               g.Kubikaza == (int)cbKubikaza.SelectedItem &&
                               g.Godiste == (int)cbGodiste.SelectedItem &&
                               g.Model == (string)cbModel.SelectedItem &&
                               g.Marka == (string)cbMarka.SelectedItem
                         select g.Pogon).Distinct();

            cbPogon.Items.Clear();

            foreach (var pogon in pogoni)
            {
                cbPogon.Items.Add(pogon);
                if (cbPogon.Items.Count <= 1)
                {
                    cbPogon.SelectedIndex = 0;
                }
            }
            lbPrikazPonuda.Items.Clear();
        }

        private void cbPogon_SelectedValueChanged(object sender, EventArgs e)
        {
            var menjaci = (from p in automobili
                         where p.Pogon == (string)cbPogon.SelectedItem &&
                               p.Gorivo == (string)cbGorivo.SelectedItem &&
                               p.Broj_vrata == (string)cbBrojVrata.SelectedItem &&
                               p.Karoserija == (string)cbKaroserija.SelectedItem &&
                               p.Kubikaza == (int)cbKubikaza.SelectedItem &&
                               p.Godiste == (int)cbGodiste.SelectedItem &&
                               p.Model == (string)cbModel.SelectedItem &&
                               p.Marka == (string)cbMarka.SelectedItem
                         select p.Menjac).Distinct();

            cbMenjac.Items.Clear();

            foreach (var menjac in menjaci)
            {
                cbMenjac.Items.Add(menjac);
                if (cbMenjac.Items.Count <= 1)
                {
                    cbMenjac.SelectedIndex = 0;
                }
            }
            lbPrikazPonuda.Items.Clear();
        }

        private void cbMenjac_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbMenjac.Items.Count <= 1)
            {
                cbMenjac.SelectedIndex = 0;
            }
            lbPrikazPonuda.Items.Clear();
        }

        private int VratiIdTrazenogAutomobila()
        {
            string marka = cbMarka.Text;
            string model = cbModel.Text;
            int godiste;
            Int32.TryParse(cbGodiste.Text, out godiste);
            int kubikaza;
            Int32.TryParse(cbKubikaza.Text, out kubikaza);
            string pogon = cbPogon.Text;
            string menjac = cbMenjac.Text;
            string karoserija = cbKaroserija.Text;
            string gorivo = cbGorivo.Text;
            string broj_vrata = cbBrojVrata.Text;

            var pronadjen_auto = automobili.Find(a => a.Marka == marka &&
                                                 a.Model == model &&
                                                 a.Godiste == godiste &&
                                                 a.Kubikaza == kubikaza &&
                                                 a.Pogon == pogon &&
                                                 a.Menjac == menjac &&
                                                 a.Karoserija == karoserija &&
                                                 a.Gorivo == gorivo &&
                                                 a.Broj_vrata == broj_vrata);

            return pronadjen_auto.Id;
        }

        private void btnPrikaziAutomobile_Click(object sender, EventArgs e)
        {
            int id_auto = VratiIdTrazenogAutomobila();
            List<Ponuda> pronadjena_ponuda = ponude.FindAll(p => p.Id_auto == id_auto);

            lbPrikazPonuda.Items.Clear();

            if (pronadjena_ponuda.Any())
            {
                foreach (var ponuda in pronadjena_ponuda)
                {
                    lbPrikazPonuda.Items.Add(ponuda);
                }
                dtpDatumOd.Enabled = true;
                dtpDatumDo.Enabled = true;
            }
            else
            {
                lbPrikazPonuda.Items.Add("Trenutno nema ponuda za odabrani automobil!");
            }
            
        }

        private void lbPrikazPonuda_SelectedValueChanged(object sender, EventArgs e)
        {
            Ponuda ponuda = (Ponuda)lbPrikazPonuda.SelectedItem;

            if (ponuda == null)
            {
                ponuda = new Ponuda();
            }
            dtpDatumOd.MinDate = DateTime.Now.AddDays(-365);
            dtpDatumOd.MaxDate = dtpDatumOd.MinDate.AddDays(365);
            dtpDatumOd.Value = ponuda.Datum_od;

            dtpDatumDo.MinDate = DateTime.Now.AddDays(-365);
            dtpDatumDo.MaxDate = dtpDatumDo.MinDate.AddDays(365);
            dtpDatumDo.Value = ponuda.Datum_do;

            DateTime datum_od = dtpDatumOd.Value;
            DateTime datum_do = dtpDatumDo.Value;

            int broj_dana = (datum_do - datum_od).Days;
            txtCena.Text = Convert.ToString(ponuda.Cena_dan * broj_dana);
            txtCena.ReadOnly = true;
        }

        private void dtpDatumOd_ValueChanged(object sender, EventArgs e)
        {
            Ponuda ponuda = (Ponuda)lbPrikazPonuda.SelectedItem;

            dtpDatumOd.MinDate = ponuda.Datum_od;
            dtpDatumOd.MaxDate = ponuda.Datum_do.AddDays(-1);

            dtpDatumDo.MinDate = DateTime.Now.AddDays(-365);
            dtpDatumDo.MaxDate = DateTime.Now.AddDays(365);
            dtpDatumDo.Value = ponuda.Datum_do.AddDays(-1);

            DateTime datum_od = dtpDatumOd.Value;
            DateTime datum_do = dtpDatumDo.Value;

            int broj_dana = (datum_do - datum_od).Days;
            txtCena.Text = Convert.ToString(ponuda.Cena_dan * broj_dana);
            txtCena.ReadOnly = true;
        }

        private void dtpDatumDo_ValueChanged(object sender, EventArgs e)
        {
            Ponuda ponuda = (Ponuda)lbPrikazPonuda.SelectedItem;

            dtpDatumDo.MinDate = dtpDatumOd.Value.AddDays(1);
            dtpDatumDo.MaxDate = ponuda.Datum_do;

            DateTime datum_od = dtpDatumOd.Value;
            DateTime datum_do = dtpDatumDo.Value;

            int broj_dana = (datum_do - datum_od).Days;
            txtCena.Text = Convert.ToString(ponuda.Cena_dan * broj_dana);
            txtCena.ReadOnly = true;
        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            int id_auto = VratiIdTrazenogAutomobila();
            DateTime datum_od = dtpDatumOd.Value;
            DateTime datum_do = dtpDatumOd.Value;
            double cena;
            Double.TryParse(txtCena.Text, out cena);

            if (rezervacije == null)
            {
                rezervacije = new List<Rezervacije>();
            }

            int broj_dana = (datum_do - datum_od).Days;
            txtCena.Text = cena.ToString();
            rezervacije.Add(new Rezervacije(id_auto, id_korisnika, datum_od, datum_do, cena));
            Datoteka.Upisi(datoteka_rezervacije, rezervacije);
            this.Close();
        }
    }
}

