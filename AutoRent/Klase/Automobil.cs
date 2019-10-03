using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRent
{
    [Serializable]
    public class Automobil
    {
        private int id;
        private string marka;
        private string model;
        private int godiste;
        private int kubikaza;
        private string pogon;
        private string menjac;
        private string karoserija;
        private string gorivo;
        private string broj_vrata;

        public Automobil(int id, string marka, string model, int godiste, int kubikaza, string pogon, string menjac, string karoserija, string gorivo, string broj_vrata)
        {
            this.id = id;
            this.marka = marka;
            this.model = model;
            this.godiste = godiste;
            this.kubikaza = kubikaza;
            this.pogon = pogon;
            this.menjac = menjac;
            this.karoserija = karoserija;
            this.gorivo = gorivo;
            this.broj_vrata = broj_vrata;
        }
        public Automobil()
        {

        }
        public string Broj_vrata
        {
            get { return broj_vrata; }
            set { broj_vrata = value; }
        }

        public string Gorivo
        {
            get { return gorivo; }
            set { gorivo = value; }
        }

        public string Karoserija
        {
            get { return karoserija; }
            set { karoserija = value; }
        }

        public string Menjac
        {
            get { return menjac; }
            set { menjac = value; }
        }

        public string Pogon
        {
            get { return pogon; }
            set { pogon = value; }
        }


        public int Kubikaza
        {
            get { return kubikaza; }
            set { kubikaza = value; }
        }

        public int Godiste
        {
            get { return godiste; }
            set { godiste = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }


        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public static int GetNewId(List<Automobil> lista)
        {
            if (lista!=null)
            {
                return lista.Max(x => x.Id) + 1;
            }
            else
            {
                return 1;
            }
        }

        public override string ToString()
        {
            return "ID: " + id + "\tMarka: " + marka + "\tModel: " + model + "\tGodiste: " + godiste;
        }
    }
}
