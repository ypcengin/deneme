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
    public partial class frmHareketler : Form
    {
        public frmHareketler()
        {
            InitializeComponent();
        }
        baglanti sql = new baglanti();

        void firmaHareketListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Exec firmaHareketGetir", sql.baglan());
            da.Fill(dt);
            gridControl2.DataSource = dt;

        }

        void musteriHareketListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Exec musteriHareketGetir", sql.baglan());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        private void frmHareketler_Load(object sender, EventArgs e)
        {
            firmaHareketListele();
            musteriHareketListele();
        }
    }
}
