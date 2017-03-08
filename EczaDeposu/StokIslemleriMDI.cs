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
    public partial class StokIslemleriMDI : Form
    {
        public StokIslemleriMDI()
        {
            InitializeComponent();
         
        }

        private void stokTopluSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopluSil stok_sil = new TopluSil();
            stok_sil.MdiParent = this;
            stok_sil.Show();
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        

        private void tümİlaçlarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Listele stok_listele = new Listele();
            stok_listele.MdiParent = this;
            stok_listele.Show();
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void ilaçTürüneGöreListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TureGoreListele tur_listele = new TureGoreListele();
            tur_listele.MdiParent = this;
            tur_listele.Show();
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}


