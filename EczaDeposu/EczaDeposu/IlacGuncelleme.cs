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
    public partial class IlacGuncelleme : Form
    {
        string connStr = EczaDeposu.ConnectionString.GetConnectionString();
        int barkod_no = 0;
        

        public IlacGuncelleme()
        {
            InitializeComponent();
        }
        private void ClearForm()
        {
            txtBarkodNo.Clear();
            txtBirimFiyat.Clear();
            txtFirmaAdi.Clear();
            txtIlacAdi.Clear();
            rtbAciklama.Clear();
            dtpSonKullanma.Value = DateTime.Now;
            nupStokAdedi.Value = 1;

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);

            string sql = "select * from ilaclar where barkod_no = @barkod_no";

            SqlCommand cmdBulBarkod = new SqlCommand(sql, conn);
            cmdBulBarkod.Parameters.Add(new SqlParameter("@barkod_no", SqlDbType.Int));
            barkod_no = Int32.Parse(txtBarkodNo.Text);
            cmdBulBarkod.Parameters["@barkod_no"].Value = barkod_no;


            try
            {
                conn.Open();

                SqlDataReader rdrBarkod = cmdBulBarkod.ExecuteReader();

                while (rdrBarkod.Read())
                {
                    txtIlacAdi.Text = rdrBarkod["ILAC_ADI"].ToString();
                    txtFirmaAdi.Text = rdrBarkod["URETICI_FIRMA"].ToString();
                    rtbAciklama.Text = rdrBarkod["ACIKLAMA"].ToString();
                    txtBirimFiyat.Text = rdrBarkod["BIRIM_FIYAT"].ToString();
                    nupStokAdedi.Value = decimal.Parse(rdrBarkod["ADET"].ToString());
                    dtpSonKullanma.Value = DateTime.Parse(rdrBarkod["S_K_T"].ToString());
                    
                    
                }


            }
            catch
            {
                MessageBox.Show("Veritabanina baglanamadi!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);
            int hata = 0;
            if (barkod_no != 0)
            {
                string sql = "UPDATE ILACLAR SET ILAC_ADI=@ilac_adi, URETICI_FIRMA=@uretici_firma, ACIKLAMA=@aciklama, ADET = @adet, BIRIM_FIYAT = @birim_fiyat, S_K_T = @s_k_t WHERE BARKOD_NO=@barkod_no";

                SqlCommand cmdGuncelle = new SqlCommand(sql, conn);

                cmdGuncelle.Parameters.Add(new SqlParameter("@barkod_no", SqlDbType.Int)); 
                cmdGuncelle.Parameters.Add(new SqlParameter("@ilac_adi", SqlDbType.NVarChar, 50));
                
                cmdGuncelle.Parameters.Add(new SqlParameter("@uretici_firma", SqlDbType.NVarChar, 50));
                cmdGuncelle.Parameters["@uretici_firma"].Value = txtFirmaAdi.Text;

                cmdGuncelle.Parameters.Add(new SqlParameter("@aciklama", SqlDbType.NVarChar, 50));
                
                cmdGuncelle.Parameters.Add(new SqlParameter("@adet", SqlDbType.Int));
               
                cmdGuncelle.Parameters.Add(new SqlParameter("@birim_fiyat", SqlDbType.Float));
                /* float.Parse("41.00027357629127", CultureInfo.InvariantCulture.NumberFormat); */
                
                cmdGuncelle.Parameters.Add(new SqlParameter("@s_k_t", SqlDbType.Date));
               

                if (txtIlacAdi.Text == string.Empty)

                    hata = 1;

                if (txtFirmaAdi.Text == string.Empty)

                    hata = 1;


                if (txtBirimFiyat.Text == string.Empty)

                    hata = 1;


                if (hata == 1)

                {

                    MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    cmdGuncelle.Parameters["@barkod_no"].Value = barkod_no;
                    cmdGuncelle.Parameters["@ilac_adi"].Value = txtIlacAdi.Text;
                    cmdGuncelle.Parameters["@aciklama"].Value = rtbAciklama.Text;
                    cmdGuncelle.Parameters["@adet"].Value = Convert.ToInt32(nupStokAdedi.Value);
                    cmdGuncelle.Parameters["@birim_fiyat"].Value = float.Parse(txtBirimFiyat.Text);
                    cmdGuncelle.Parameters["@s_k_t"].Value = dtpSonKullanma.Value.Date;

                    try
                    {
                        conn.Open();
                        cmdGuncelle.ExecuteNonQuery();
                        basariDurumu.Text = "Guncelleme Islemi Basari Ile Gerceklestirildi...";
                        barkod_no = 0;


                    }
                    catch
                    {
                        MessageBox.Show("Veritabanina baglanamadi!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void txtBarkodNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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

        private void rtbAciklama_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
       && !char.IsSeparator(e.KeyChar);
        }

        private void txtBirimFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void guncelleToolStripButton_Click(object sender, EventArgs e)
        {
            this.btnGuncelle_Click(sender, e);
        }

        private void temizleToolStripButton_Click(object sender, EventArgs e)
        {
            this.btnTemizle_Click(sender, e);
        }

        private void iptalToolStripButton_Click(object sender, EventArgs e)
        {
            this.btnCikis_Click(sender, e);

        }
    }
}
