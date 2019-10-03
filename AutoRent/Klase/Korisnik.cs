using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutoRent
{
    [Serializable]
    public class Korisnik
    {
        protected int id;
        protected string ime;
        protected string prezime;
        protected string jmbg;
        protected DateTime datum_rodjenja;
        protected string telefon;
        protected bool is_admin;
        protected string korisnicko_ime;
        protected string lozinka;
        protected string uloga; 

        public Korisnik(int id, string ime, string prezime, string jmbg, DateTime datum_rodjenja, string telefon, string korisnicko_ime, string lozinka)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.datum_rodjenja = datum_rodjenja;
            this.telefon = telefon;
            this.korisnicko_ime = korisnicko_ime;
            this.lozinka = lozinka;
        }        

        public string Korisnicko_ime
        {
            get { return korisnicko_ime; }
            set { korisnicko_ime = value; }
        }        

        public string Lozinka
        {
            get { return lozinka; }
            set { lozinka = value; }
        }

        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }

        public DateTime Datum_rodjenja
        {
            get { return datum_rodjenja; }
            set { datum_rodjenja = value; }
        }

        public string Jmbg
        {
            get { return jmbg; }
            set { jmbg = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Uloga
        {
            get { return uloga; }
            set { uloga = value; }
        }

        public static int GetNewId(List<Korisnik> lista)
        {
            if (lista.Any())
            {
                return lista.Max (x => x.Id) + 1;
            }

            else
            {
                return 1;
            }
        }
        public Korisnik()
        {

        }
    }
}
