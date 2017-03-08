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
    public partial class TureGoreListele : Form
    {
        string connStr = ConnectionString.GetConnectionString();
        string ılac_turu;
        public TureGoreListele()
        {
            InitializeComponent();
        }

    private void TureGoreListele_Load(object sender, EventArgs e)
     {
     
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter adap = new SqlDataAdapter("select distinct ILAC_TURU from ILACLAR", conn) ;
            DataTable dt = new DataTable();
            adap.Fill(dt);
            int index = -1;

            try
            {
                conn.Open();


                foreach (DataRow p in dt.Rows)
                {


                    SqlDataAdapter adapInner = new SqlDataAdapter("select ILAC_ADI,ILAC_TURU from ILACLAR", conn);
                    DataTable dtInner = new DataTable();
                    adapInner.Fill(dtInner);
                    index++;

                    TreeNode parent = new TreeNode(p["ILAC_TURU"].ToString());
                    ListeletreeView.Nodes.Add(parent);

                    foreach (DataRow c in dtInner.Rows)
                    {

                        if (Equals(p["ILAC_TURU"].ToString(), c["ILAC_TURU"].ToString()))
                        {
                            TreeNode child = new TreeNode(c["ILAC_ADI"].ToString());
                            ListeletreeView.Nodes[index].Nodes.Add(child);
                        }
                    }

                }
            }

            catch
            {
                MessageBox.Show("Ilaclar Veritabanindan Cekilemedi!", "Uyari Mesaji", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conn.Close();
            }

        }
    }
}
