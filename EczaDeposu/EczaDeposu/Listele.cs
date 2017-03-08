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
    public partial class Listele : Form
    {
        string connStr = ConnectionString.GetConnectionString();

        public Listele()
        {
            InitializeComponent();
           
        }

        private void Listele_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);

            string query = "select * from ILACLAR";

            SqlCommand cmmAllIlaclar = new SqlCommand(query, conn);

            try
            {
                conn.Open();

                SqlDataReader rdr = cmmAllIlaclar.ExecuteReader();

                DataTable ilacTable = new DataTable();

                ilacTable.Load(rdr);

                this.dgvIlacListele.DataSource = ilacTable;

                rdr.Close();


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
    }
}
