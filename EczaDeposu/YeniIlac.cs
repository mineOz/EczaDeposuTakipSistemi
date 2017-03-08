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
    public partial class YeniIlac : Form
    {
        string connStr = EczaDeposu.ConnectionString.GetConnectionString();
        int adet = 0;
        float  birim_fiyat;
        string ilac_adi;
        string uretici_firma;
        string ilac_aciklama;

        string ilac_turu;


        public YeniIlac()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnYeniIlacEkle_Click(object sender, EventArgs e)
        {
            int hata = 0;
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmdAddDrug =
                new SqlCommand("INSERT INTO ILACLAR (ILAC_ADI,URETICI_FIRMA,ACIKLAMA,ADET,BIRIM_FIYAT,S_K_T,ILAC_TURU)" +
                               "VALUES (@ilac_adi,@uretici_firma,@aciklama,@adet,@birim_fiyat,@s_k_t,@ilac_turu)", conn);

            cmdAddDrug.Parameters.Add(new SqlParameter("@ilac_adi", SqlDbType.NVarChar, 50));
            cmdAddDrug.Parameters.Add(new SqlParameter("@uretici_firma", SqlDbType.NVarChar, 50));
            cmdAddDrug.Parameters.Add(new SqlParameter("@ilac_turu", SqlDbType.NVarChar, 50));
            cmdAddDrug.Parameters.Add(new SqlParameter("@aciklama", SqlDbType.NVarChar, 50));
            /* int x = Int32.Parse(TextBoxD1.Text); */
            cmdAddDrug.Parameters.Add(new SqlParameter("@adet", SqlDbType.Int));
            cmdAddDrug.Parameters.Add(new SqlParameter("@birim_fiyat", SqlDbType.Float));
            /* float.Parse("41.00027357629127", CultureInfo.InvariantCulture.NumberFormat); */
            cmdAddDrug.Parameters.Add(new SqlParameter("@s_k_t", SqlDbType.Date));


            if (txtIlacAdi.Text == string.Empty)
                hata = 1;
            if (txtFirmaAdi.Text == string.Empty)
                hata = 1;
            if (txtIlacTuru.Text == string.Empty)
                hata = 1;
            if (txtBirimFiyat.Text == string.Empty)
                hata = 1;
            if (hata == 1)

            {

                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                cmdAddDrug.Parameters["@ilac_adi"].Value = txtIlacAdi.Text;
                ilac_adi = txtIlacAdi.Text;
                cmdAddDrug.Parameters["@uretici_firma"].Value = txtFirmaAdi.Text;
                uretici_firma = txtFirmaAdi.Text;
                cmdAddDrug.Parameters["@ilac_turu"].Value = txtIlacTuru.Text;
                ilac_turu = txtIlacTuru.Text;
                cmdAddDrug.Parameters["@aciklama"].Value = rtbAciklama.Text;
                ilac_aciklama = rtbAciklama.Text;
                adet = Convert.ToInt32(nupStokAdedi.Value);
                cmdAddDrug.Parameters["@adet"].Value = adet;
                birim_fiyat = float.Parse(txtBirimFiyat.Text);
                cmdAddDrug.Parameters["@birim_fiyat"].Value = birim_fiyat;
                cmdAddDrug.Parameters["@s_k_t"].Value = dtpSonKullanma.Value.Date;

                try
                {
                    conn.Open();
                    cmdAddDrug.ExecuteNonQuery();
                    basariDurumu.Text = "Ekleme Islemi Basariyla Gerceklestirildi...";
                    /*barkod_no = (int)cmdAddDrug.Parameters["@barkod_no"].Value; DUZELTILCEK KOD */
                    rtbSonucMesaji.Text = ilac_adi + " adli ilactan " + adet + " adet basariyla depoya eklenmistir\n" +
                        "Toplam Maliyeti = " + birim_fiyat * adet + " TL";




                }
                catch
                {
                    MessageBox.Show("Veritabanina baglanamadi", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);// icon eklemeyi unutma..
                }
                finally
                {
                    conn.Close();

                }


            }
        }

        private void ClearForm()
        {
            txtBirimFiyat.Clear();
            txtFirmaAdi.Clear();
            txtIlacTuru.Clear();
            txtIlacAdi.Clear();
            rtbAciklama.Clear();
            dtpSonKullanma.Value = DateTime.Now;
            nupStokAdedi.Value = 1;
            
        }

       private void txtIlacAdi_TextChanged(object sender, EventArgs e)
        {/* 
            if (txtIlacAdi.Text == "")
            {
                btnYeniIlacEkle.Enabled = false;
                MessageBox.Show("Veritabanina baglanamadi", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);// icon eklemeyi unutma..

            }
            else
            {
                btnYeniIlacEkle.Enabled = true;
            }*/
        }

        private void YeniIlac_Load(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
           btnYeniIlacEkle_Click(sender, e); 
        }

        private void temizleToolStripButton_Click(object sender, EventArgs e)
        {
            btnTemizle_Click(sender, e);
        }

        private void iptalToolStripButton_Click(object sender, EventArgs e)
        {
            btnIptal_Click(sender, e);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtIlacAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
          && !char.IsSeparator(e.KeyChar);
        }

        private void txtFirmaAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
          && !char.IsSeparator(e.KeyChar);
        }

        private void txtIlacTuru_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
          && !char.IsSeparator(e.KeyChar);
        }

        private void rtbAciklama_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
         && !char.IsSeparator(e.KeyChar);
        }

        private void txtBirimFiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpSonKullanma_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
