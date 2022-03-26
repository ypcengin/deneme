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
    public partial class frmStoklar : Form
    {
        public frmStoklar()
        {
            InitializeComponent();
        }

        baglanti sql = new baglanti();
        private void frmStoklar_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select U.URUN_AD,SUM(U.ALINAN_ADET) 'TOPLAM ADET' from URUNLER U group by u.URUN_AD",sql.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            SqlCommand grafik = new SqlCommand("select U.URUN_AD,SUM(U.ALINAN_ADET) 'TOPLAM ADET' from URUNLER U group by u.URUN_AD", sql.baglan());
            SqlDataReader dr = grafik.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 2"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            sql.baglan().Close();

            SqlCommand grafik2 = new SqlCommand("select IL, COUNT(*) 'TOPLAM ADET' from FIRMALAR group by IL", sql.baglan());
            SqlDataReader dr2 = grafik2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 2"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            sql.baglan().Close();
        }
    }
}
