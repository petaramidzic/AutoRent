using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AutoRent
{
    public partial class FrmAdmPonuda : Form
    {
        List<Automobil> automobili;
        List<Ponuda> ponude;
        string datoteka_ponude = "ponude.bin";
        string datoteka_automobili = "automobili.bin";


        public FrmAdmPonuda()
        {
            InitializeComponent();
            UcitajListe();
            PopuniLbAutomobil();
            PopuniLbPonude();
            PodesiDatume();
        }

        private void UcitajListe()
        {
            automobili = (List<Automobil>)Datoteka.Procitaj(datoteka_automobili);

            if (automobili == null)
            {
                automobili = new List<Automobil>();
            }

            ponude = (List<Ponuda>)Datoteka.Procitaj(datoteka_ponude);

            if (ponude == null)
            {
                ponude = new List<Ponuda>();
            }
        }
        private void PopuniLbAutomobil()
        {
            lbAutomobili.Items.Clear();

            if (automobili.Any())
            {
                foreach (var auto in automobili)
                {
                    lbAutomobili.Items.Add(auto);
                }
            }
        }
        private void PopuniLbPonude()
        {
            lbPonude.Items.Clear();

            if (ponude.Any())
            {
                foreach (var ponuda in ponude)
                {
                    lbPonude.Items.Add(ponuda);
                }
            }
        }

        private void PodesiDatume()
        {
            dtpDatumOd.MinDate = DateTime.Now.AddDays(-365);
            dtpDatumOd.MaxDate = DateTime.Now.AddDays(365);
            dtpDatumDo.MinDate = DateTime.Now.AddDays(-365);
            dtpDatumDo.MaxDate = DateTime.Now.AddDays(365);
        }

        private void NapraviPonudu(int id)
        {
            Automobil automobil = (Automobil)lbAutomobili.SelectedItem;

            int id_ponude = id;
            int id_auto = automobil.Id;

            DateTime datum_od = dtpDatumOd.Value;
            DateTime datum_do = dtpDatumDo.Value;
            double cena;
            Double.TryParse(txtCena.Text, out cena);

            if (datum_do < datum_od)
            {
                MessageBox.Show("Datum kraja vazenja ponude ne moze biti manji od datume pocetka trajanja ponude", "Upozorenje!");
            }
            else
            {
                ponude.Add(new Ponuda(id, id_auto, datum_od, datum_do, cena));
            }
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            NapraviPonudu(Ponuda.GetNewId(ponude));
            Datoteka.Upisi(datoteka_ponude, ponude);
            PopuniLbPonude();
        }

        private void dtpDatumOd_ValueChanged(object sender, EventArgs e)
        {
            dtpDatumDo.MinDate = dtpDatumOd.Value.AddDays(1);
            dtpDatumDo.MaxDate = dtpDatumDo.Value.AddDays(365);
        }

        private void dtpDatumDo_ValueChanged(object sender, EventArgs e)
        {
            dtpDatumDo.MinDate = dtpDatumOd.Value.AddDays(1);
            dtpDatumDo.MaxDate = dtpDatumOd.Value.AddDays(365);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            Ponuda ponuda = (Ponuda)lbPonude.SelectedItem;
            lbAutomobili.Enabled = false;

            int id_ponude = ponuda.Id;
            int id_auto = ponuda.Id_auto;
            DateTime datum_od = dtpDatumOd.Value;
            DateTime datum_do = dtpDatumDo.Value;
            double cena;
            Double.TryParse(txtCena.Text, out cena);

            ponude.Remove(ponuda);
            ponude.Add(new Ponuda(id_ponude, id_auto, datum_od, datum_do, cena));
            ponude = ponude.OrderBy(x => x.Id).ToList();
            Datoteka.Upisi(datoteka_ponude, ponude);
            PopuniLbPonude();
            lbAutomobili.Enabled = true;
        }

        private void lbPonude_SelectedValueChanged(object sender, EventArgs e)
        {
            Ponuda ponuda = (Ponuda)lbPonude.SelectedItem;

            PodesiDatume();
            dtpDatumOd.Value = ponuda.Datum_od;
            dtpDatumDo.Value = ponuda.Datum_do;
            dtpDatumDo.MinDate = dtpDatumOd.Value.AddDays(1);
            txtCena.Text = ponuda.Cena_dan.ToString();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Ponuda ponuda = (Ponuda)lbPonude.SelectedItem;

            ponude.Remove(ponuda);
            ponude = ponude.OrderBy(x => x.Id).ToList();
            Datoteka.Upisi(datoteka_ponude, ponude);
            PopuniLbPonude();
        }

        private void lbAutomobili_SelectedValueChanged(object sender, EventArgs e)
        {
            Ponuda ponuda = (Ponuda)lbPonude.SelectedItem;

            dtpDatumOd.MinDate = DateTime.Now.AddDays(-365);
            dtpDatumOd.MaxDate = DateTime.Now.AddDays(365);

            dtpDatumDo.MinDate = DateTime.Now.AddDays(-365);
            dtpDatumDo.MaxDate = DateTime.Now.AddDays(365);
        }
    }
}
