using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutoRent
{
    public partial class FrmAdmKupac : Form
    {
        List<Administrator> administratori;
        List<Kupac> kupci;
        List<Korisnik> korisnici;
        string datoteka_administratori = "administratori.bin";
        string datoteka_kupci = "kupci.bin";

        public FrmAdmKupac()
        {
            InitializeComponent();
            UcitajListe();
            DodajuListBox();
            PopuniPolja();
        }

        private void PopuniPolja()
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtJMBG.Text = "";
            txtJMBG.MaxLength = 13;
            txtDatumRodjenja.Text = "";
            txtTelefon.Text = "";
            var pozicija = Enum.GetValues(typeof(Uloga));
            cbPozicija.DataSource = pozicija;
            cbPozicija.SelectedIndex = -1;
            txtKorisnickoIme.Text = "";
            txtLozinka.Text = "";
            txtLozinka.PasswordChar = '*';
            cbPozicija.Enabled = true;
        }

        private bool ProveraPoljaUnosa()
        {
            if (String.IsNullOrEmpty(txtIme.Text) && String.IsNullOrWhiteSpace(txtIme.Text))
            {
                MessageBox.Show("Morate uneti polje Ime!");
                return false;
            }

            if (String.IsNullOrEmpty(txtPrezime.Text) || String.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                MessageBox.Show("Morate uneti polje Prezime!");
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtJMBG.Text) || String.IsNullOrEmpty(txtJMBG.Text))
            {
                MessageBox.Show("Polje JMBG mora biti popunjeno!");
                return false;
            }
            if (txtJMBG.Text.Length != 13)
            {
                MessageBox.Show("Polje JMBG mora sadrzati 13 cifara!");
                return false;
            }
            if (String.IsNullOrEmpty(txtPrezime.Text) || String.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                MessageBox.Show("Morate uneti polje Datum!");
                return false;
            }
            if (String.IsNullOrEmpty(txtTelefon.Text) || String.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                MessageBox.Show("Morate uneti polje Telefon!");
                return false;
            }
            if (cbPozicija.SelectedItem == null || cbPozicija.SelectedIndex == -1)
            {
                MessageBox.Show("Morate uneti polje Pozicija!");
                return false;
            }
            if (String.IsNullOrEmpty(txtKorisnickoIme.Text) || String.IsNullOrWhiteSpace(txtKorisnickoIme.Text))
            {
                MessageBox.Show("Morate uneti polje Korisnicko ime!");
                return false;
            }
            if (String.IsNullOrEmpty(txtLozinka.Text) || String.IsNullOrWhiteSpace(txtLozinka.Text))
            {
                MessageBox.Show("Morate uneti polje Lozinka!");
                return false;
            }
            return true;
        }

        private void NapraviKorisnika(int id)
        {
            if (ProveraPoljaUnosa())
            {
                string ime = txtIme.Text;
                string prezime = txtPrezime.Text;
                string jmbg = txtJMBG.Text;
                DateTime datum = Convert.ToDateTime(txtDatumRodjenja.Text);
                string telefon = txtTelefon.Text;
                string uloga = cbPozicija.SelectedValue.ToString();
                string korisnicko_ime = txtKorisnickoIme.Text.ToLower();
                string lozinka = txtLozinka.Text.ToString();

                Korisnik korisnik = korisnici.FirstOrDefault(x => x.Korisnicko_ime == txtKorisnickoIme.Text);

                if (korisnik == null)
                {
                    if (uloga == "administrator")
                    {
                        administratori.Add(new Administrator(id, ime, prezime, jmbg, datum, telefon, korisnicko_ime, lozinka));
                        Datoteka.Upisi(datoteka_administratori, administratori);
                    }
                    else
                    {
                        kupci.Add(new Kupac(id, ime, prezime, jmbg, datum, telefon, korisnicko_ime, lozinka));
                        Datoteka.Upisi(datoteka_kupci, kupci);
                    }
                }
                else
                {
                    MessageBox.Show("Korisnik sa tim korisnickim imenom vec postoji!");
                }
                UcitajListe();
                DodajuListBox();
                PopuniPolja();
            }
        }
        private void UcitajListe()
        {
            korisnici = new List<Korisnik>();
            ProcitajKupce();
            ProcitajAdministratore();
            korisnici.AddRange(kupci);
            korisnici.AddRange(administratori);
        }
        private void DodajuListBox()
        {
            lbKorisnici.Items.Clear();

            if (korisnici.Any())
            {
                foreach (var korisnik in korisnici)
                {
                    lbKorisnici.Items.Add(korisnik);
                }
            }
        }
        private void btnUnesi_Click(object sender, EventArgs e)
        {
            NapraviKorisnika(Korisnik.GetNewId(korisnici));
        }
        private void ProcitajKupce()
        {
            kupci = (List<Kupac>)Datoteka.Procitaj(datoteka_kupci);
            if (kupci == null)
            {
                kupci = new List<Kupac>();
            }
        }
        private void ProcitajAdministratore()
        {
            administratori = (List<Administrator>)Datoteka.Procitaj(datoteka_administratori);
            if (administratori == null)
            {
                administratori = new List<Administrator>();
            }
        }
        private void PronadjiKorisnikaObrisi()
        {
            Korisnik korisnik = (Korisnik)lbKorisnici.SelectedItem;

            DialogResult rezultat = MessageBox.Show("Da li zelite da obrisete korisnika?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rezultat == DialogResult.Yes)
            {
                if (korisnik.GetType().Name == "Kupac")
                {
                    kupci.Remove((Kupac)korisnik);
                    Datoteka.Upisi(datoteka_kupci, kupci);
                }
                else
                {
                    administratori.Remove((Administrator)korisnik);
                    Datoteka.Upisi(datoteka_administratori, administratori);
                }
                korisnici.Remove(korisnik);
                DodajuListBox();
            }
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            PronadjiKorisnikaObrisi();
            PopuniPolja();
        }
        private void lbKorisnici_SelectedValueChanged(object sender, EventArgs e)
        {
            Korisnik korisnik = (Korisnik)lbKorisnici.SelectedItem;
            txtIme.Text = korisnik.Ime.ToString();
            txtPrezime.Text = korisnik.Prezime.ToString();
            txtJMBG.Text = korisnik.Jmbg.ToString();
            txtDatumRodjenja.Text = korisnik.Datum_rodjenja.ToShortDateString();
            txtTelefon.Text = korisnik.Telefon.ToString();
            txtKorisnickoIme.Text = korisnik.Korisnicko_ime.ToString();
            txtLozinka.Text = korisnik.Lozinka.ToString();
            if (korisnik.GetType().Name == "Administrator")
            {
                cbPozicija.SelectedIndex = 0;
            }
            else
            {
                cbPozicija.SelectedIndex = 1;
            }
            cbPozicija.Enabled = false;

        }
        private void AzurirajKorisnika(int id)
        {
            if (ProveraPoljaUnosa())
            {
                string ime = txtIme.Text;
                string prezime = txtPrezime.Text;
                string jmbg = txtJMBG.Text;
                DateTime datum = Convert.ToDateTime(txtDatumRodjenja.Text);
                string telefon = txtTelefon.Text;
                string uloga = cbPozicija.SelectedValue.ToString();
                string korisnicko_ime = txtKorisnickoIme.Text.ToLower();
                string lozinka = txtLozinka.Text.ToString();

                Korisnik korisnik = korisnici.FirstOrDefault(x => x.Korisnicko_ime == txtKorisnickoIme.Text);

                if (korisnik == null)
                {
                    if (uloga == "administrator")
                    {
                        administratori.Add(new Administrator(id, ime, prezime, jmbg, datum, telefon, korisnicko_ime, lozinka));
                        Datoteka.Upisi(datoteka_administratori, administratori);
                    }
                    else
                    {
                        kupci.Add(new Kupac(id, ime, prezime, jmbg, datum, telefon, korisnicko_ime, lozinka));
                        Datoteka.Upisi(datoteka_kupci, kupci);
                    }
                }
                UcitajListe();
                DodajuListBox();
                PopuniPolja();
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = (Korisnik)lbKorisnici.SelectedItem;
            int id = korisnik.Id;

            if (korisnik.GetType().Name == "Kupac")
            {

                kupci.Remove((Kupac)korisnik);
                AzurirajKorisnika(id);
            }
            else
            {
                administratori.Remove((Administrator)korisnik);
                AzurirajKorisnika(id);
            }
        }
    }
}

