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
    public partial class FrmAdmRezervacije : Form
    {
        List<Kupac> kupci;
        List<Rezervacije> rezervacije;

        string datoteka_kupci = "kupci.bin";
        string datoteka_rezervacije = "rezervacije.bin";

        public FrmAdmRezervacije()
        {
            InitializeComponent();
            UcitajKupceiRezervacije();

        }

        private void UcitajKupceiRezervacije()
        {
            kupci = (List<Kupac>)Datoteka.Procitaj(datoteka_kupci);
            rezervacije = (List<Rezervacije>)Datoteka.Procitaj(datoteka_rezervacije);

            if(rezervacije == null)
            {
                rezervacije = new List<Rezervacije>();
            }

            cbPregledKupaca.DataSource = kupci;
            cbPregledKupaca.SelectedIndex = -1;            
        }

        private void cbPregledKupaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kupac selektovani_kupac =(Kupac)cbPregledKupaca.SelectedValue;

            lbPregledRezervacija.Items.Clear();

            if(selektovani_kupac == null)
            {
                selektovani_kupac = new Kupac();
            }
            int id_selektovanog_kupca = selektovani_kupac.Id; 

            foreach (Rezervacije r in rezervacije)
            {
                if ( r.Id_kupac== id_selektovanog_kupca )
                {
                    lbPregledRezervacija.Items.Add(r);
                }
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Rezervacije rezervacija = (Rezervacije)lbPregledRezervacija.SelectedItem;
            rezervacije.Remove(rezervacija);
            Datoteka.Upisi(datoteka_rezervacije, rezervacije);

            lbPregledRezervacija.Items.Clear();

            foreach (Rezervacije r in rezervacije)
            {
                lbPregledRezervacija.Items.Add(r);
            }

        }
        
    }
}
