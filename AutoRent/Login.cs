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
    public partial class frmLogin : Form
    {
        List<Administrator> administratori;
        string datoteka_administratori = "administratori.bin";
        List<Kupac> kupci;
        string datoteka_kupci = "kupci.bin";
        List<Korisnik> korisnici;
        Korisnik korisnik;
        private int id_korisnika;
        public frmLogin()
        {
            InitializeComponent();
            txtboxUserPass.PasswordChar = '*';
        }

        private void ProcitajAdministratore()
        {
            administratori = (List<Administrator>)Datoteka.Procitaj(datoteka_administratori);
            if (administratori == null)
            {
                administratori = new List<Administrator>();
            }
        }
        private void ProcitajKupce()
        {
            kupci = (List<Kupac>)Datoteka.Procitaj(datoteka_kupci);
            if (kupci == null)
            {
                kupci = new List<Kupac>();
            }
        }
        private void UcitajListe()
        {
            korisnici = new List<Korisnik>();
            if (korisnici == null)
            {
                korisnici = new List<Korisnik>();
            }
            ProcitajKupce();
            ProcitajAdministratore();
            korisnici.AddRange(kupci);
            korisnici.AddRange(administratori);
        }

        private void ProveriKorisnika()
        {
            string username = txtboxUserLogin.Text.ToLower();
            string password = txtboxUserPass.Text;

            korisnik = (Korisnik)korisnici.Find(u => u.Korisnicko_ime == username && u.Lozinka == password);
            if (korisnik == null)
            {
                korisnik = new Korisnik();
            }

            if (korisnik.GetType().Name == "Administrator")
            {
                MessageBox.Show("Dobrodosli " + korisnik.Korisnicko_ime);
                this.Hide();
                Administracija administracija = new Administracija();
                administracija.ShowDialog();
            }
            else if (korisnik.GetType().Name == "Kupac")
            {
                MessageBox.Show("Dobrodosli " + korisnik.Korisnicko_ime);
                this.Hide();
                FrmKupac frmkupac = new FrmKupac(id_korisnika);
                frmkupac.ShowDialog();
            }
            else
            {
                MessageBox.Show("Takav korisnik ne postoji pokusajte ponovo!", "Upozorenje");
                this.Focus();
                txtboxUserLogin.Text = "";
                txtboxUserPass.Text = "";
            }
        }

        private void PronadjiIdKorisnika(ref int id_korisnika)
        {
            string username = txtboxUserLogin.Text;
            string password = txtboxUserPass.Text;

            korisnik = (Korisnik)korisnici.Find(u => u.Korisnicko_ime == username && u.Lozinka == password);
            if (korisnik == null)
            {
                korisnik = new Korisnik();
            }
            id_korisnika = korisnik.Id;
        }
        private void ListePovera()
        {
            UcitajListe();
            PronadjiIdKorisnika(ref id_korisnika);
            ProveriKorisnika();            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ListePovera();
        }
    }
}
