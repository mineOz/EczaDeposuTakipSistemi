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
    public partial class SiparisOnayla : Form
    {

        string connStr = EczaDeposu.ConnectionString.GetConnectionString();
        private int orderedAmount;
        private string orderedDate;

        public SiparisOnayla()
        {
            InitializeComponent();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {   

              this.ClearForm();

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearForm()
        {

            rtbFatura.Clear();

        }

        private void getOrdersFromDB()
        {

            cbSiparisler.Items.Clear();

            SqlConnection conn = new SqlConnection(connStr);

            string sql = "SELECT ECZANE_NO,ILAC_BARKOD FROM ILAC_SIPARIS";

            SqlCommand cmdNoListele = new SqlCommand(sql, conn);

            try
            {
                conn.Open();

                SqlDataReader rdrOrder = cmdNoListele.ExecuteReader();

                while (rdrOrder.Read())
                {
                    cbSiparisler.Items.Add(rdrOrder["ECZANE_NO"].ToString() + " " + rdrOrder["ILAC_BARKOD"].ToString());

                }


                rdrOrder.Close();


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

        private void iptalToolStripButton_Click(object sender, EventArgs e)
        {
            this.btnIptal_Click(sender, e);
        }

        private void temizleToolStripButton_Click(object sender, EventArgs e)
        {
            this.btnTemizle_Click(sender, e);
        }

        private void SiparisOnayla_Load(object sender, EventArgs e)
        {
            this.getOrdersFromDB();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (getBarkod() != 0 && getEczaneNo() != 0 && orderedAmount <= Adet())
            {
                String sql = "UPDATE ILACLAR SET ADET = @adet WHERE BARKOD_NO = @barkod_no ";

                SqlConnection conn = new SqlConnection(connStr);

                SqlCommand cmdGuncelleIlac = new SqlCommand(sql, conn);

                cmdGuncelleIlac.Parameters.Add(new SqlParameter("@barkod_no", SqlDbType.Int));
                cmdGuncelleIlac.Parameters.Add(new SqlParameter("@adet", SqlDbType.Int));
                cmdGuncelleIlac.Parameters["@barkod_no"].Value = getBarkod();
                cmdGuncelleIlac.Parameters["@adet"].Value = Adet() - this.orderedAmount;

                try
                {
                    conn.Open();
                    cmdGuncelleIlac.ExecuteNonQuery();
                    this.deleteApprovedOrder();
                    this.createInvoice();
                    this.getOrdersFromDB();
                    basariDurumu.Text = "Siparis basariyla onaylandi!";


                }
                catch
                {
                    MessageBox.Show("Veritabanina baglanamadi!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            else
            {

                MessageBox.Show("Stoklarda yeterli miktarda ilac bulunmamaktadir!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private int getBarkod()
        {
            String selectedOrder = cbSiparisler.SelectedItem.ToString();
            return Int32.Parse(selectedOrder.Substring(selectedOrder.Length - 4));

        }
        private int getEczaneNo()
        {
            String selectedOrder = cbSiparisler.SelectedItem.ToString();
            return Int32.Parse(selectedOrder.Substring(0,4));

        }
        private void cbSiparisler_SelectedIndexChanged(object sender, EventArgs e)
        {


           SqlConnection conn = new SqlConnection(connStr);

            String sql = "SELECT * FROM ILAC_SIPARIS WHERE ILAC_BARKOD = @ilac_barkod AND ECZANE_NO = @eczane_no";

            SqlCommand cmdFindOrder = new SqlCommand(sql, conn);

            cmdFindOrder.Parameters.Add(new SqlParameter("@ilac_barkod", SqlDbType.Int));           
            cmdFindOrder.Parameters.Add(new SqlParameter("@eczane_no", SqlDbType.Int));
            cmdFindOrder.Parameters["@eczane_no"].Value = getEczaneNo();
            cmdFindOrder.Parameters["@ilac_barkod"].Value = getBarkod();

            try
            {
                conn.Open();
                SqlDataReader rdrOrder = cmdFindOrder.ExecuteReader();


                while (rdrOrder.Read())
                {
                    rtbFatura.Text = getBarkod() + " No'lu eczane " + getEczaneNo() + " barkod no'lu ilactan " + rdrOrder["ILAC_ADETI"].ToString() +
                       " kadar sipariste bulunmustur.Toplam fiyat .... TL dir.Stok durumunu kontrol edip onaylayabilirsiniz";
                    this.orderedAmount = Int32.Parse(rdrOrder["ILAC_ADETI"].ToString());
                    this.orderedDate = ((DateTime)rdrOrder["SIPARIS_TARIHI"]).ToString("d"); ;

                   
                }




            }
            catch
            {
                MessageBox.Show("Veritabanina baglanamadi!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

         private int Adet()
          {

            int adet = 0;

              SqlConnection conn = new SqlConnection(connStr);

              string sql = "SELECT ADET FROM ILACLAR WHERE BARKOD_NO = '" + getBarkod() + "' ";

              SqlCommand cmdIlacAdet = new SqlCommand(sql, conn);

              try
              {
                  conn.Open();

                  SqlDataReader rdrBarkod = cmdIlacAdet.ExecuteReader();

                  while (rdrBarkod.Read())
                  {
                      adet = Int32.Parse(rdrBarkod["ADET"].ToString());

                  }
                  
                  rdrBarkod.Close();
                  return adet;

              }
              catch
              {
                  MessageBox.Show("Veritabanına bağlanmada hata oluştu!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
              finally
              {
                  conn.Close();
              }
              return adet;

          }
        private void deleteApprovedOrder()
        {

            SqlConnection conn = new SqlConnection(connStr);
            String sql = "DELETE FROM ILAC_SIPARIS WHERE ILAC_BARKOD = @ilac_barkod AND ECZANE_NO = @eczane_no";

            SqlCommand cmdDeleteOrder = new SqlCommand(sql, conn);

            cmdDeleteOrder.Parameters.Add(new SqlParameter("@ilac_barkod", SqlDbType.Int));
            cmdDeleteOrder.Parameters.Add(new SqlParameter("@eczane_no", SqlDbType.Int));
            cmdDeleteOrder.Parameters["@ilac_barkod"].Value = getBarkod();
            cmdDeleteOrder.Parameters["@eczane_no"].Value = getEczaneNo();

            try
            {
                conn.Open();
                cmdDeleteOrder.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Silme isleminde hata oluştu!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
        private void createInvoice()
        {

            SqlConnection conn = new SqlConnection(connStr);

            string sql = "SELECT ILAC_ADI,BIRIM_FIYAT FROM ILACLAR WHERE BARKOD_NO = @barkod_no";

            SqlCommand cmdCreateInvoice = new SqlCommand(sql, conn);

            cmdCreateInvoice.Parameters.Add(new SqlParameter("@barkod_no", SqlDbType.Int));
            cmdCreateInvoice.Parameters["@barkod_no"].Value = getBarkod();

            try
            {
                conn.Open();
                SqlDataReader rdrInvoice = cmdCreateInvoice.ExecuteReader();

                while (rdrInvoice.Read())
                {

                    labelIlacAdi.Text = rdrInvoice["ILAC_ADI"].ToString();
                    labelBirimFiyat.Text = float.Parse(rdrInvoice["BIRIM_FIYAT"].ToString()).ToString();
                    labelSiparisAdet.Text = this.orderedAmount.ToString();
                    labelSiparisTarih.Text = this.orderedDate;
                    labelTutar.Text = (this.orderedAmount * float.Parse(rdrInvoice["BIRIM_FIYAT"].ToString())).ToString();

               }
            
            }
            catch
            {
                MessageBox.Show("Fatura olusturma isleminde hata oluştu!", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void onaylaToolStripButton_Click(object sender, EventArgs e)
        {
            this.btnOnayla_Click(sender, e);
        }
    }
}
