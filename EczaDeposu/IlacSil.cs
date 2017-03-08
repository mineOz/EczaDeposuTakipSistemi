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
    public partial class IlacSil : Form
    {
        string connStr = EczaDeposu.ConnectionString.GetConnectionString();
        int barkod_no = 0;
        string ilac_adi = null;
        RadioButton selectedRadio;

        public IlacSil()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            txtBoxID.Clear();
            rtbSilinenListele.Clear();
            barkod_no = 0;
            ilac_adi = null;


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);

            if(selectedRadio == rbIlacAdi)
            {
                string sql = "select * from ilaclar where ilac_adi = @ilac_adi";
                SqlCommand cmdBulBarkod = new SqlCommand(sql, conn);
                cmdBulBarkod.Parameters.Add(new SqlParameter("@ilac_adi", SqlDbType.NVarChar,50));
                cmdBulBarkod.Parameters["@ilac_adi"].Value = txtBoxID.Text;
                ilac_adi = txtBoxID.Text;

                try
                {
                    conn.Open();

                    SqlDataReader rdrBarkod = cmdBulBarkod.ExecuteReader();

                    while (rdrBarkod.Read())
                    {
                        rtbSilinenListele.Text = rdrBarkod["BARKOD_NO"].ToString() + " Barkod No'lu " + rdrBarkod["ILAC_ADI"].ToString() + " Adli ilac Stoklardan Kalici Olarak Silinecek Emin misiniz ?";
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
            else if(selectedRadio == rbBarkodNo)
            {
                

                string sql = "select * from ilaclar where barkod_no = @barkod_no";

                SqlCommand cmdBulBarkod = new SqlCommand(sql, conn);
                cmdBulBarkod.Parameters.Add(new SqlParameter("@barkod_no", SqlDbType.Int));
                cmdBulBarkod.Parameters["@barkod_no"].Value = Int32.Parse(txtBoxID.Text);
                barkod_no = Int32.Parse(txtBoxID.Text);

                try
                {
                    conn.Open();

                    SqlDataReader rdrBarkod = cmdBulBarkod.ExecuteReader();

                    while (rdrBarkod.Read())
                    {
                        rtbSilinenListele.Text = rdrBarkod["BARKOD_NO"].ToString() + " Barkod No'lu " + rdrBarkod["ILAC_ADI"].ToString() + " Adli ilac Stoklardan Kalici Olarak Silinecek Emin misiniz ?";
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

            

        }
        private void aramaType_CheckedChanged(object sender, EventArgs e)
        {           

            if (sender == rbIlacAdi)
            {
                selectedRadio = rbIlacAdi;
                
            }
            else if (sender == rbBarkodNo)
            {
                selectedRadio = rbBarkodNo;
              
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);

            /* SqlCommand("DELETE FROM " + table + " WHERE " + columnName + " = '" + IDNumber+"'", con)) */
            if (barkod_no != 0)
            {
                string sql = "DELETE FROM ILACLAR WHERE BARKOD_NO = '" + barkod_no + "'";

                SqlCommand cmdDelete = new SqlCommand(sql, conn);

                try
                {
                    conn.Open();
                    cmdDelete.ExecuteNonQuery();
                    basariDurumu.Text = "Silme Islemi Gerceklesti..";
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
            }else if (ilac_adi != null)
            {
                string sql = "DELETE FROM ILACLAR WHERE ILAC_ADI = '" + ilac_adi + "'";

                SqlCommand cmdDelete = new SqlCommand(sql, conn);

                try
                {
                    conn.Open();
                    cmdDelete.ExecuteNonQuery();
                    basariDurumu.Text = "Silme Islemi Gerceklesti..";
                    ilac_adi = null;

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

        private void silToolStripButton_Click(object sender, EventArgs e)
        {
            btnSil_Click(sender, e);
        }

        private void temizleToolStripButton_Click(object sender, EventArgs e)
        {
            btnTemizle_Click(sender, e);
        }

        private void iptalToolStripButton_Click(object sender, EventArgs e)
        {
            btnIptal_Click(sender, e);
        }

        private void IlacSil_Load(object sender, EventArgs e)
        {

        }
    }
}
