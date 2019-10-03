using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRent
{
    [Serializable]
    class Ponuda
    {

        private int id;
        private int id_auto;
        private DateTime datum_od;
        private DateTime datum_do;
        private double cena_dan;

        public Ponuda(int id, int id_auto, DateTime datum_od, DateTime datum_do, double cena_dan)
        {
            this.id = id;
            this.id_auto = id_auto;
            this.datum_od = datum_od;
            this.datum_do = datum_do;
            this.cena_dan = cena_dan;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public double Cena_dan
        {
            get { return cena_dan; }
            set { cena_dan = value; }
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

        public int Id_auto
        {
            get { return id_auto; }
            set { id_auto = value; }
        }

        public override string ToString()
        {
            return "ID ponude: " + id + "; ID Automobila " + id_auto + "; Datum od: " + datum_od.ToShortDateString() + "; Datum do: " + datum_do.ToShortDateString() + "; Cena po danu: " + cena_dan;
        }
        public static int GetNewId(List<Ponuda> lista)
        {
            if (lista.Any())
            {
                return lista.Max(x => x.Id) + 1;
            }
            else
            {
                return 1;
            }
        }
        public Ponuda()
        {
                
        }
    }
}
