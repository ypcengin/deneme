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
    public partial class frmRehber : Form
    {
        public frmRehber()
        {
            InitializeComponent();
        }

        baglanti sql = new baglanti();

        void musteriListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select AD, SOYAD, TC_NO, TELEFON, MAIL, ADRES from MUSTERILER", sql.baglan());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void firmaListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select AD, YETKILI_AD_SOYAD, YETKILI_TC_NO, TELEFON1, MAIL, ADRES from FIRMALAR", sql.baglan());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }

        private void frmRehber_Load(object sender, EventArgs e)
        {
            musteriListele();
            firmaListele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void xtraTabControl1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmMail fr_mail = new frmMail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                fr_mail.mail = dr["MAIL"].ToString();
            }
            fr_mail.Show();

        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            frmMail fr_mail = new frmMail();
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);

            if (dr != null)
            {
                fr_mail.mail = dr["MAIL"].ToString();
            }
            fr_mail.Show();
        }
    }
}
