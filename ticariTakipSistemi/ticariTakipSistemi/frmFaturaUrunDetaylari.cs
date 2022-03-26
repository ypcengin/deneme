using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ticariTakipSistemi
{
    public partial class frmFaturaUrunDetaylari : Form
    {
        public frmFaturaUrunDetaylari()
        {
            InitializeComponent();
        }
        public string id;
        baglanti sql = new baglanti();

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from FATURA_DETAY where FATURA_ID='" + id + "'", sql.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void frmFaturaUrunDetaylari_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmFaturaUrunDuzenleme fr_duzenle = new frmFaturaUrunDuzenleme();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                fr_duzenle.urunid = dr["FATURA_URUN_ID"].ToString();
            }
            fr_duzenle.Show();
        }
    }
}
