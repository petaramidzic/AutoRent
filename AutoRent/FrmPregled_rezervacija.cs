using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRent
{
    public partial class FrmPregled_rezervacija : Form
    {
        private int id_korisnika;
        List<Rezervacije> sverezervacije;
        List<Automobil> automobili;
        string datoteka_rezervacije = "rezervacije.bin";
        string datoteka_automobili = "automobili.bin";

        public FrmPregled_rezervacija(int id)
        {
            InitializeComponent();
            id_korisnika = id;
            UcitajRezervacije();

        }

        private void UcitajRezervacije()
        {
            sverezervacije = (List<Rezervacije>)Datoteka.Procitaj(datoteka_rezervacije);
            automobili = (List<Automobil>)Datoteka.Procitaj(datoteka_automobili);

            if (sverezervacije == null)
            {
                sverezervacije = new List<Rezervacije>();
            }
            if (automobili == null)
            {
                automobili = new List<Automobil>();
            }

            var rezervacija = from r in sverezervacije where r.Id_kupac == id_korisnika select r;

            lbRezervacije.Items.Clear();
            foreach (var r in rezervacija)
            {
                lbRezervacije.Items.Add(r);
            }
        }

        private void btnNovaRezervacija_Click(object sender, EventArgs e)
        {
            FrmRezervacija frmRezervacija = new FrmRezervacija(id_korisnika);
            this.Close();            
            frmRezervacija.ShowDialog();
        }

        private void lbRezervacije_SelectedValueChanged(object sender, EventArgs e)
        {
            Rezervacije rezervacija = (Rezervacije)lbRezervacije.SelectedItem;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Rezervacije rezervacija = (Rezervacije)lbRezervacije.SelectedItem;
            sverezervacije.Remove(rezervacija);
            Datoteka.Upisi(datoteka_rezervacije, sverezervacije);
            UcitajRezervacije();
        }
    }
}
