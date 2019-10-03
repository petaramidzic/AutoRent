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
    public partial class Administracija : Form
    {
        public Administracija()
        {
            InitializeComponent();            
        }
        FrmAutomobil frmAutomobil;
        FrmAdmKupac frmAdmKupac;
        FrmAdmPonuda frmAdmPonuda;
        FrmAdmRezervacije frmAdmRezervacije;
        FrmAdmStatistika frmAdmStatistika;

        private void automobilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAutomobil == null)
            {
                frmAutomobil = new FrmAutomobil();                
                frmAutomobil.MdiParent = this;
                frmAutomobil.Show();
                frmAutomobil.Closed += frmAutomobil_Closed;
            }
            else
            {
                frmAutomobil.Focus();
            }
            
        }

        void frmAutomobil_Closed(object sender , EventArgs e)
        {
            frmAutomobil = null;
        }

        private void kupacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAdmKupac == null)
            {
                frmAdmKupac = new FrmAdmKupac();
                frmAdmKupac.MdiParent = this;
                frmAdmKupac.Show();
                frmAdmKupac.Closed += frmAdmKupac_Closed;
            }
            else
            {
                frmAdmKupac.Focus();
            }
        }

        private void frmAdmKupac_Closed(object sender, EventArgs e)
        {
            frmAdmKupac = null;
        }

        private void ponudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAdmPonuda == null)
            {
                frmAdmPonuda = new FrmAdmPonuda();
                frmAdmPonuda.MdiParent = this;
                frmAdmPonuda.Show();
                frmAdmPonuda.Closed += frmAdmPonuda_Closed;
            }
            else
            {
                frmAdmPonuda.Focus();
            }
        }

        private void frmAdmPonuda_Closed(object sender, EventArgs e)
        {
            frmAdmPonuda = null;
        }

        private void rezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAdmRezervacije == null)
            {
                frmAdmRezervacije = new FrmAdmRezervacije();
                frmAdmRezervacije.MdiParent = this;
                frmAdmRezervacije.Show();
                frmAdmRezervacije.Closed += frmAdmRezervacije_Closed;
            }
            else
            {
                frmAdmRezervacije.Focus();
            }
        }

        private void frmAdmRezervacije_Closed(object sender, EventArgs e)
        {
            frmAdmRezervacije = null;
        }

        private void statistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAdmStatistika == null)
            {
                frmAdmStatistika = new FrmAdmStatistika();
                frmAdmStatistika.MdiParent = this;
                frmAdmStatistika.Show();
                frmAdmStatistika.Closed += frmAdmStatistika_Closed;
            }
            else
            {
                frmAdmStatistika.Focus();
            }
        }

        private void frmAdmStatistika_Closed(object sender, EventArgs e)
        {
            frmAdmStatistika = null;
        }

        private void Administracija_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
