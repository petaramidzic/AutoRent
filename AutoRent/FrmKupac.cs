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
    public partial class FrmKupac : Form
    {
        private int id_korisnika;
        public FrmKupac(int id)
        {
            InitializeComponent();
            id_korisnika = id;
        }       

        FrmPregled_rezervacija frmPregled_Rezervacija;

        private void pregledRezervacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (frmPregled_Rezervacija == null)
            {
                frmPregled_Rezervacija = new FrmPregled_rezervacija(id_korisnika);
                frmPregled_Rezervacija.MdiParent = this;
                frmPregled_Rezervacija.Show();
                frmPregled_Rezervacija.Closed += frmPregled_Rezervacija_Closed;
            }
            else
            {
                frmPregled_Rezervacija.Focus();
            }
        }

        private void frmPregled_Rezervacija_Closed(object sender, EventArgs e)
        {
            frmPregled_Rezervacija = null;
        }

        FrmRezervacija frmRezervacija;

        private void rezervacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRezervacija == null)
            {   
                frmRezervacija = new FrmRezervacija(id_korisnika);
                frmRezervacija.MdiParent = this;
                frmRezervacija.Show();
                frmRezervacija.Closed += frmRezervacija_Closed;
            }
            else
            {
                frmRezervacija.Focus();
            }
        }

        private void frmRezervacija_Closed(object sender, EventArgs e)
        {
            frmRezervacija = null;
        }

        private void FrmKupac_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
