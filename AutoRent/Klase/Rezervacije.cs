using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRent
{
    [Serializable]
    class Rezervacije
    {
        private int id_auto;
        private int id_kupac;
        private DateTime datum_od;
        private DateTime datum_do;
        private double cena;

        public Rezervacije(int id_auto, int id_kupac, DateTime datum_od, DateTime datum_do, double cena)
        {
            this.id_auto = id_auto;
            this.id_kupac = id_kupac;
            this.datum_od = datum_od;
            this.datum_do = datum_do;
            this.cena = cena;
        }
        public Rezervacije()
        {

        }

        public double Cena
        {
            get { return cena; }
            set { cena = value; }
        }


        public DateTime Datum_do
        {
            get { return datum_do; }
            set { datum_do = value; }
        }


        public DateTime Datum_od
        {
            get { return datum_od; }
            set { datum_od = value; }
        }


        public int Id_kupac
        {
            get { return id_kupac; }
            set { id_kupac = value; }
        }


        public int Id_auto
        {
            get { return id_auto; }
            set { id_auto = value; }
        }

        public override string ToString()
        {
            return "Id Automobila: " + id_auto + "\tDatum od: " + datum_od.ToShortDateString() + "\tDatum do: " + datum_do.ToShortDateString() + "\tCena: " + cena; 
        }  
    }
}
