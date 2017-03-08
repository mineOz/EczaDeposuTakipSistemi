using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaDeposu
{
    public partial class EczaDeposuForm : Form
    {
        public EczaDeposuForm()
        {
            InitializeComponent();
        }

        private void EczaDeposuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnIlaclar_Click(object sender, EventArgs e)
        {
           

        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void urunlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form yeni_ilac = new YeniIlac();
            yeni_ilac.Show();

        }

        private void urunIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
        private void urunSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ilac_silme = new IlacSil();
            ilac_silme.Show();

        }

        private void urunGuncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ilac_guncelleme = new IlacGuncelleme();
            ilac_guncelleme.Show();
        }

        private void eczanelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form eczaneler = new Eczaneler();
            eczaneler.Show();
        }

        

        private void siparisEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form siparis_ekle = new SiparisEkle();
            siparis_ekle.Show();
        }

       

        private void stokIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form Stok_MDI = new StokIslemleriMDI();
            Stok_MDI.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://kordonecza.net/");
        }

        private void siparisOnaylaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form siparis_onayla = new SiparisOnayla();
            siparis_onayla.Show();
        }
    }
}
