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
    public partial class TopluSil : Form
    {

        string connStr = EczaDeposu.ConnectionString.GetConnectionString();

        public TopluSil()
        {
            InitializeComponent();
        }

        private void TopluSil_Load(object sender, EventArgs e)
        {
            this.getIlaclerFromDb();
        }
        private void getIlaclerFromDb()
        {
            clbGoruntulenenler.Items.Clear();
            
            SqlConnection conn = new SqlConnection(connStr);

            string sql = "SELECT BARKOD_NO,ILAC_ADI,ADET FROM ILACLAR";

            SqlCommand cmdNoListele = new SqlCommand(sql, conn);

            try
            {
                conn.Open();

                SqlDataReader rdrBarkod = cmdNoListele.ExecuteReader();

                while (rdrBarkod.Read())
                {
                    clbGoruntulenenler.Items.Add(rdrBarkod["BARKOD_NO"].ToString() + "\t\t" + rdrBarkod["ILAC_ADI"].ToString());
                    
                }


                rdrBarkod.Close();


            }
            catch
            {
                MessageBox.Show("İlaçlar Veritabanından Çekilemedi!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void clbGoruntulenenler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clbGoruntulenenler_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string ilac = clbGoruntulenenler.SelectedItem.ToString();

            if(e.NewValue == CheckState.Checked)
            {
                lbSilinecekler.Items.Add(ilac);
            }
            else
            {
                lbSilinecekler.Items.Remove(ilac);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);

            int barkod_no = 0;
           
            while(lbSilinecekler.Items.Count != 0)
            {
               barkod_no = Int32.Parse(lbSilinecekler.Items[0].ToString().Substring(0, 4));

               string sql = "DELETE FROM ILACLAR WHERE BARKOD_NO = '" + barkod_no + "' ";

                SqlCommand cmdDelete = new SqlCommand(sql, conn);

                try
                {
                    conn.Open();
                    cmdDelete.ExecuteNonQuery();
                    this.getIlaclerFromDb();
                    lbSilinecekler.Items.RemoveAt(0);
                    basariDurumu.Text = "Toplu Silme Islemi Basari Ile Gerceklestirildi...";

                }
                catch
                {
                    MessageBox.Show("Veritabanına bağlanılamadı!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }

        }
    }
}
