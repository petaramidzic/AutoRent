using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRent
{
    [Serializable]
    class Administrator:Korisnik
    {
        
        public Administrator(int id, string ime, string prezime, string jmbg, DateTime datum_rodjenja, string telefon, string korisnicko_ime, string lozinka) : base (id, ime, prezime, jmbg, datum_rodjenja, telefon,korisnicko_ime,lozinka)
        {
            
        }
        public Administrator()
        {

        }

        public override string ToString()
        {
            return "Korisnik: " + ime + " " + prezime + "\t(ADMINISTRATOR)";
        }
    }
}
