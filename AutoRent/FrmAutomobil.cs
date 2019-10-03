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
    public partial class FrmAutomobil : Form
    {
        List<Automobil> automobili;
        string datoteka_automobili = "automobili.bin";

        public FrmAutomobil()
        {
            InitializeComponent();
            automobili = new List<Automobil>();
            PopuniPolja();
            DodajuListBox();
        }

        private void btnUnesiAutomobil_Click(object sender, EventArgs e)
        {
            NapraviAutomobil(Automobil.GetNewId(automobili));
        }

        private void PopuniPolja()
        {
            txtMarka.Text = "";
            txtModel.Text = "";
            txtGodiste.Text = "";
            txtKubikaza.Text = "";

            var menjaci = Enum.GetValues(typeof(Menjac));
            cbMenjac.DataSource = menjaci;
            cbMenjac.SelectedIndex = -1;

            var karoserija = Enum.GetValues(typeof(Karoserija));
            cbKaroserija.DataSource = karoserija;
            cbKaroserija.SelectedIndex = -1;

            var brojvrata = Enum.GetValues(typeof(BrojVrata));
            cbBrojVrata.DataSource = brojvrata;
            cbBrojVrata.SelectedIndex = -1;

            var gorivo = Enum.GetValues(typeof(Gorivo));
            cbGorivo.DataSource = gorivo;
            cbGorivo.SelectedIndex = -1;

            var pogon = Enum.GetValues(typeof(Pogon));
            cbPogon.DataSource = pogon;
            cbPogon.SelectedIndex = -1;
        }

        private bool ProveraPoljaUnosa()
        {
            if (String.IsNullOrEmpty(txtMarka.Text) && String.IsNullOrWhiteSpace(txtMarka.Text))
            {
                MessageBox.Show("Morate uneti polje Marka!");
                return false;
            }

            if (String.IsNullOrEmpty(txtModel.Text) && String.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Morate uneti polje Model!");
                return false;
            }
            if (String.IsNullOrEmpty(txtGodiste.Text) && String.IsNullOrWhiteSpace(txtGodiste.Text))
            {
                MessageBox.Show("Morate uneti polje Godiste!");
                return false;
            }
            if (String.IsNullOrEmpty(txtKubikaza.Text) && String.IsNullOrWhiteSpace(txtKubikaza.Text))
            {
                MessageBox.Show("Morate uneti polje Kubikaza!");
                return false;
            }
            if (cbPogon.SelectedItem == null || cbPogon.SelectedIndex == -1)
            {
                MessageBox.Show("Morate uneti polje Pogon!");
                return false;
            }
            if (cbMenjac.SelectedItem == null || cbMenjac.SelectedIndex == -1)
            {
                MessageBox.Show("Morate uneti polje Menjac!");
                return false;
            }
            if (cbKaroserija.SelectedItem == null || cbKaroserija.SelectedIndex == -1)
            {
                MessageBox.Show("Morate uneti polje Karoserija!");
                return false;
            }
            if (cbGorivo.SelectedItem == null || cbGorivo.SelectedIndex == -1)
            {
                MessageBox.Show("Morate uneti polje Gorivo!");
                return false;
            }
            if (cbBrojVrata.SelectedItem == null || cbBrojVrata.SelectedIndex == -1)
            {
                MessageBox.Show("Morate uneti polje Broj Vrata!");
                return false;
            }
            return true;
        }

        private void NapraviAutomobil(int id)
        {
            if (ProveraPoljaUnosa())
            {
                string marka = txtMarka.Text;
                string model = txtModel.Text;
                int godiste;
                Int32.TryParse(txtGodiste.Text, out godiste);
                int kubikaza;
                Int32.TryParse(txtKubikaza.Text, out kubikaza);
                string pogon = cbPogon.SelectedValue.ToString();
                string menjac = cbMenjac.SelectedValue.ToString();
                string karoserija = cbKaroserija.SelectedValue.ToString();
                string gorivo = cbGorivo.SelectedValue.ToString();
                string brojvrata = cbBrojVrata.SelectedValue.ToString();

                if (automobili == null)
                {
                    automobili = new List<Automobil>();
                }
                automobili.Add(new Automobil(id, marka, model, godiste, kubikaza, pogon, menjac, karoserija, gorivo, brojvrata));
                automobili = automobili.OrderBy(x => x.Id).ToList();
                Datoteka.Upisi(datoteka_automobili, automobili);
                DodajuListBox();
                PopuniPolja();
            }
        }

        private void DodajuListBox()
        {
            lbAutomobili.Items.Clear();
            automobili = (List<Automobil>)Datoteka.Procitaj(datoteka_automobili);
            if (automobili != null)
            {
                foreach (var auto in automobili)
                {
                    lbAutomobili.Items.Add(auto);
                }
            }
        }

        private void lbAutomobili_SelectedIndexChanged(object sender, EventArgs e)
        {
            Automobil automobil = (Automobil)lbAutomobili.SelectedItem;
            OsveziPolja(automobil);
        }

        private void OsveziPolja(Automobil automobil)
        {
            txtMarka.Text = automobil.Marka.ToString();
            txtModel.Text = automobil.Model.ToString();
            txtGodiste.Text = automobil.Godiste.ToString();
            txtKubikaza.Text = automobil.Kubikaza.ToString();
            cbPogon.Text = automobil.Pogon.ToString();
            cbMenjac.Text = automobil.Menjac.ToString();
            cbKaroserija.Text = automobil.Karoserija.ToString();
            cbGorivo.Text = automobil.Gorivo.ToString();
            cbBrojVrata.Text = automobil.Broj_vrata.ToString();
        }

        private void btnIzmeniAutomobil_Click(object sender, EventArgs e)
        {
            if (ProveraPoljaUnosa())
            {
                Automobil automobil = (Automobil)lbAutomobili.SelectedItem;
                int id = automobil.Id;
                automobili.Remove(automobil);
                NapraviAutomobil(id);                
                //DodajuListBox();
                PopuniPolja();
            }            
        }

        private void btnObrisiAutomobil_Click(object sender, EventArgs e)
        {
            DialogResult rezultat = MessageBox.Show("Da li zelite da obrisete automobil?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rezultat == DialogResult.Yes)
            {
                Automobil automobil = (Automobil)lbAutomobili.SelectedItem;
                automobili.Remove(automobil);
                automobili = automobili.OrderBy(x => x.Id).ToList();
                Datoteka.Upisi(datoteka_automobili, automobili);
                DodajuListBox();
                PopuniPolja();
            }
            else if (rezultat == DialogResult.No)
            {
                Automobil automobil = (Automobil)lbAutomobili.SelectedItem;
                OsveziPolja(automobil);
            }

        }
    }
}
