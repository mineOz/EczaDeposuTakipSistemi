using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaDeposu
{
    public partial class SiparisEkle : Form
    {
        string connStr = EczaDeposu.ConnectionString.GetConnectionString();
        string siparis_adi = null;
        int adet;

        public SiparisEkle()
        {
            InitializeComponent();
        }

    

        private void SiparisEkle_Load(object sender, EventArgs e)
        {
            this.getIlaclerFromDb();
        }

        private void getIlaclerFromDb()
        {
            cbEczaneList.Items.Clear();

            SqlConnection conn = new SqlConnection(connStr);

            string sql = "SELECT ECZANE_NO,ECZANE_ADI FROM ECZANE";

            SqlCommand cmdNoListele = new SqlCommand(sql, conn);

            try
            {
                conn.Open();

                SqlDataReader rdrBarkod = cmdNoListele.ExecuteReader();

                while (rdrBarkod.Read())
                {
                    cbEczaneList.Items.Add(rdrBarkod["ECZANE_NO"].ToString() + " " + rdrBarkod["ECZANE_ADI"].ToString());

                }


                rdrBarkod.Close();


            }
            catch
            {
                MessageBox.Show("Eczaneler Veritabanından Çekilemedi!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {

            txtSiparisEdilenIlac.Clear();
            npSiparisAdet.Value = 0;
            rtbFatura.Clear();
            dtpSiparisTarihi.Value = DateTime.Today;

        }

        private void olusturToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void temizleToolStripButton_Click(object sender, EventArgs e)
        {
            btnTemizle_Click(sender, e);
        }

        private void iptalToolStripButton_Click(object sender, EventArgs e)
        {
            btnIptal_Click(sender, e);
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            decimal isNegative=0;
         
            SqlConnection conn = new SqlConnection(connStr);


            string sql = "insert into ILAC_SIPARIS (ILAC_BARKOD,ECZANE_NO,SIPARIS_TARIHI,ILAC_ADETI)"+
                         "VALUES(@ilac_barkod,@eczane_no,@siparis_tarihi,@ilac_adeti)";

            SqlCommand cmdAddOrder = new SqlCommand(sql, conn);

            cmdAddOrder.Parameters.Add(new SqlParameter("@ilac_barkod",SqlDbType.Int));
            cmdAddOrder.Parameters.Add(new SqlParameter("@eczane_no", SqlDbType.Int));
            cmdAddOrder.Parameters.Add(new SqlParameter("@siparis_tarihi", SqlDbType.Date));
            cmdAddOrder.Parameters.Add(new SqlParameter("@ilac_adeti", SqlDbType.Int));

            cmdAddOrder.Parameters["@ilac_barkod"].Value = this.getSiparisBarkod(txtSiparisEdilenIlac.Text);
            cmdAddOrder.Parameters["@eczane_no"].Value = Int32.Parse(cbEczaneList.Text.Substring(0,4));
            cmdAddOrder.Parameters["@siparis_tarihi"].Value = dtpSiparisTarihi.Value.Date;
            cmdAddOrder.Parameters["@ilac_adeti"].Value = npSiparisAdet.Value;

            try
            {
                conn.Open();
                cmdAddOrder.ExecuteNonQuery();
                rtbFatura.Text = "Siparis basariyla olusturulmustur.Siparisi onaylamak icin Onay Menusune gecis yapabilirsiniz";
                basariDurumu.Text = "Islem basariyla gerceklestirilmistir";
            }
            catch
            {
                MessageBox.Show("Veritabanina baglanamadi!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private int getSiparisBarkod(String ilacAdi)
        {
            int barkod = 0;

            SqlConnection conn = new SqlConnection(connStr);

            string sql = "SELECT BARKOD_NO FROM ILACLAR WHERE ILAC_ADI = @ilac_adi";

            SqlCommand cmdFindBakord = new SqlCommand(sql, conn);

            cmdFindBakord.Parameters.Add(new SqlParameter("@ilac_adi", SqlDbType.NVarChar, 50));

            cmdFindBakord.Parameters["@ilac_adi"].Value = ilacAdi;

            try
            {
                conn.Open();
                SqlDataReader rdrIlacNo = cmdFindBakord.ExecuteReader();

                while (rdrIlacNo.Read())
                {
                    barkod = Int32.Parse(rdrIlacNo["BARKOD_NO"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Veritabanina baglanamadi!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return barkod;
        }


        private void txtSiparisEdilenIlac_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
       && !char.IsSeparator(e.KeyChar);
        }
    }
}
