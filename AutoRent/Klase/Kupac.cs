using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRent
{
    [Serializable]
    class Kupac:Korisnik
    {       
        public Kupac(int id, string ime, string prezime, string jmbg, DateTime datum_rodjenja, string telefon, string korisnicko_ime, string lozinka) : base(id, ime, prezime, jmbg, datum_rodjenja, telefon, korisnicko_ime, lozinka)
        {            

        }
        public Kupac()
        {

        }

        public override string ToString()
        {
            return "Korisnik: " + ime + " " + prezime + "\t(KUPAC)";
        }
    }
}
