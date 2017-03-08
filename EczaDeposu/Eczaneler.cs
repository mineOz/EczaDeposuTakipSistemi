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
    public partial class Eczaneler : Form
    {

        string connStr = ConnectionString.GetConnectionString();
        int eczane_no = 0;

        public Eczaneler()
        {
            InitializeComponent();
        }

        private void Eczaneler_Load(object sender, EventArgs e)
        {
            this.getEczanelerFromDb();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int hata = 0;

            SqlConnection conn = new SqlConnection(connStr);

            string sql = "INSERT INTO ECZANE (ECZANE_ADI,ECZANE_ADRES,TEL_NO) VALUES (@eczane_adi,@eczane_adres,@eczane_tel)";

            SqlCommand cmdEkle = new SqlCommand(sql, conn);

            cmdEkle.Parameters.Add(new SqlParameter("@eczane_adi", SqlDbType.NVarChar, 50));
            

            cmdEkle.Parameters.Add(new SqlParameter("@eczane_adres", SqlDbType.NVarChar, 100));
            

            cmdEkle.Parameters.Add(new SqlParameter("@eczane_tel", SqlDbType.NVarChar, 10));
           


            if (txtEczaneAdi.Text == string.Empty)

                hata = 1;

            if (rtbEczaneAdresi.Text == string.Empty)

                hata = 1;

            if (txtEczaneTel.Text == string.Empty)

                hata = 1;

            if (hata == 1)

            {

                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                cmdEkle.Parameters["@eczane_adi"].Value = txtEczaneAdi.Text;
                cmdEkle.Parameters["@eczane_adres"].Value = rtbEczaneAdresi.Text;
                cmdEkle.Parameters["@eczane_tel"].Value = txtEczaneTel.Text;

                try
                {
                    conn.Open();
                    cmdEkle.ExecuteNonQuery();
                    this.getEczanelerFromDb();
                    basariDurumu.Text = "Ekleme Islemi Basariyla Gerceklestirildi...";
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

        private void ekleToolStripButton_Click(object sender, EventArgs e)
        {
            btnEkle_Click(sender, e);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int hata = 0;
            SqlConnection conn = new SqlConnection(connStr);

            if (eczane_no != 0)
            {
                string sql = "UPDATE ECZANE SET ECZANE_ADI=@eczane_adi,ECZANE_ADRES=@eczane_adres,TEL_NO = @tel_no WHERE ECZANE_NO=@eczane_no";

                SqlCommand cmdGuncelle = new SqlCommand(sql, conn);

                cmdGuncelle.Parameters.Add(new SqlParameter("@eczane_no", SqlDbType.Int));
              

                cmdGuncelle.Parameters.Add(new SqlParameter("@eczane_adi", SqlDbType.NVarChar, 50));
               


                cmdGuncelle.Parameters.Add(new SqlParameter("@eczane_adres", SqlDbType.NVarChar, 100));
                

                cmdGuncelle.Parameters.Add(new SqlParameter("@tel_no", SqlDbType.NVarChar, 10));
                


                if (txtGuncelleAd.Text == string.Empty)

                    hata = 1;

                if (rtbGuncelleAdres.Text == string.Empty)

                    hata = 1;

                if (txtGuncelleTel.Text == string.Empty)

                    hata = 1;

                if (hata == 1)

                {

                    MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                else
                {
                    cmdGuncelle.Parameters["@eczane_no"].Value = eczane_no;
                    cmdGuncelle.Parameters["@eczane_adi"].Value = txtGuncelleAd.Text;
                    cmdGuncelle.Parameters["@eczane_adres"].Value = rtbGuncelleAdres.Text;
                    cmdGuncelle.Parameters["@tel_no"].Value = txtGuncelleTel.Text;

                    try
                    {
                        conn.Open();
                        cmdGuncelle.ExecuteNonQuery();
                        basariDurumu.Text = "Guncelleme Islemi Basari Ile Gerceklestirildi...";
                        eczane_no = 0;


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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }
        private void ClearForm()
        {
            txtEczaneAdi.Clear();
            txtEczaneTel.Clear();
            txtGuncelleAd.Clear();
            txtGuncelleTel.Clear();
            rtbGuncelleAdres.Clear();
            rtbEczaneAdresi.Clear();
        }

        private void cbEczaneNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);

            string sql = "SELECT ECZANE_ADI,ECZANE_ADRES,TEL_NO FROM ECZANE WHERE ECZANE_NO = @eczane_no";

            SqlCommand cmdBul = new SqlCommand(sql, conn);
            cmdBul.Parameters.Add(new SqlParameter("@eczane_no", SqlDbType.Int));
            eczane_no = Int32.Parse(cbEczaneNo.SelectedItem.ToString());
            cmdBul.Parameters["@eczane_no"].Value = eczane_no;

            try
            {
                conn.Open();

                SqlDataReader rdrBarkod = cmdBul.ExecuteReader();

                while (rdrBarkod.Read())
                {
                    txtGuncelleAd.Text = rdrBarkod["ECZANE_ADI"].ToString();
                    txtGuncelleTel.Text = rdrBarkod["TEL_NO"].ToString();
                    rtbGuncelleAdres.Text = rdrBarkod["ECZANE_ADRES"].ToString();

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

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);
                        
            eczane_no = Int32.Parse(cbSil.SelectedItem.ToString());

            string sql = "DELETE FROM ECZANE WHERE ECZANE_NO = '" + eczane_no + "' ";

            SqlCommand cmdDelete = new SqlCommand(sql, conn);

                try
                {
                    conn.Open();
                    cmdDelete.ExecuteNonQuery();
                    this.getEczanelerFromDb();
                   
                    basariDurumu.Text = "Silme Islemi Basari Ile Gerceklestirildi...";
                   
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

        private void cbSil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void getEczanelerFromDb()
        {
            cbEczaneNo.Items.Clear();
            cbSil.Items.Clear();

          SqlConnection conn = new SqlConnection(connStr);

            string sql = "SELECT ECZANE_NO,ECZANE_ADI FROM ECZANE";

            SqlCommand cmdNoListele = new SqlCommand(sql, conn);

            try
            {
                conn.Open();

                SqlDataReader rdrBarkod = cmdNoListele.ExecuteReader();

                while (rdrBarkod.Read())
                {
                    cbEczaneNo.Items.Add(rdrBarkod["ECZANE_NO"].ToString());
                    cbSil.Items.Add(rdrBarkod["ECZANE_NO"].ToString());
                }


                rdrBarkod.Close();


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

        private void txtEczaneAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEczaneAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
         }

        private void rtbEczaneAdresi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
     }

        private void txtEczaneTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtGuncelleAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }

        private void rtbGuncelleAdres_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }

        private void txtGuncelleTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
