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
    public partial class frmGiderler : Form
    {
        public frmGiderler()
        {
            InitializeComponent();
        }

        baglanti sql = new baglanti();

        void giderListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from GIDERLER_YENI order by GIDER_ID asc", sql.baglan());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            txtId.Text = "";
            txtElektrik.Text = "";
            txtSu.Text = "";
            txtDogalgaz.Text = "";
            txtInternet.Text = "";
            txtMaaslar.Text = "";
            txtEkstra.Text = "";
            txtNotlar.Text = "";
            cmbAy.Text = "";
            cmbYil.Text = "";
        }
        private void frmGiderler_Load(object sender, EventArgs e)
        {
            giderListesi();
            temizle();
        }

        private void btnGiderKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into GIDERLER_YENI (ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EKSTRA,NOTLAR,AY,YIL) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)", sql.baglan());
            ekle.Parameters.AddWithValue("@p1", decimal.Parse(txtElektrik.Text));
            ekle.Parameters.AddWithValue("@p2", decimal.Parse(txtSu.Text));
            ekle.Parameters.AddWithValue("@p3", decimal.Parse(txtDogalgaz.Text));
            ekle.Parameters.AddWithValue("@p4", decimal.Parse(txtInternet.Text));
            ekle.Parameters.AddWithValue("@p5", decimal.Parse(txtMaaslar.Text));
            ekle.Parameters.AddWithValue("@p6", decimal.Parse(txtEkstra.Text));
            ekle.Parameters.AddWithValue("@p7", txtNotlar.Text);
            ekle.Parameters.AddWithValue("@p8", cmbAy.Text);
            ekle.Parameters.AddWithValue("@p9", cmbYil.Text);
            ekle.ExecuteNonQuery();
            sql.baglan().Close();
            MessageBox.Show("Gider Tanımlandı", "Ekleme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderListesi();
            temizle();
        }

        private void btnGiderSil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete from GIDERLER_YENI where GIDER_ID=@p1", sql.baglan());
            sil.Parameters.AddWithValue("@p1", txtId.Text);
            sil.ExecuteNonQuery();
            sql.baglan().Close();
            MessageBox.Show("Gider Silindi", "Silme İşlemi Tamamlandı", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            giderListesi();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["GIDER_ID"].ToString();
                txtElektrik.Text = dr["ELEKTRIK"].ToString();
                txtSu.Text = dr["SU"].ToString();
                txtDogalgaz.Text = dr["DOGALGAZ"].ToString();
                txtInternet.Text = dr["INTERNET"].ToString();
                txtMaaslar.Text = dr["MAASLAR"].ToString();
                txtEkstra.Text = dr["EKSTRA"].ToString();
                txtNotlar.Text = dr["NOTLAR"].ToString();
                cmbAy.Text = dr["AY"].ToString();
                cmbYil.Text = dr["YIL"].ToString();

            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnGiderGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update GIDERLER_YENI set ELEKTRIK=@p1,SU=@p2,DOGALGAZ=@p3,INTERNET=@p4,MAASLAR=@p5,EKSTRA=@p6,NOTLAR=@p7,AY=@p8,YIL=@p9 where GIDER_ID=@p10", sql.baglan());
            guncelle.Parameters.AddWithValue("@p1", decimal.Parse(txtElektrik.Text));
            guncelle.Parameters.AddWithValue("@p2", decimal.Parse(txtSu.Text));
            guncelle.Parameters.AddWithValue("@p3", decimal.Parse(txtDogalgaz.Text));
            guncelle.Parameters.AddWithValue("@p4", decimal.Parse(txtInternet.Text));
            guncelle.Parameters.AddWithValue("@p5", decimal.Parse(txtMaaslar.Text));
            guncelle.Parameters.AddWithValue("@p6", decimal.Parse(txtEkstra.Text));
            guncelle.Parameters.AddWithValue("@p7", txtNotlar.Text);
            guncelle.Parameters.AddWithValue("@p8", cmbAy.Text);
            guncelle.Parameters.AddWithValue("@p9", cmbYil.Text);
            guncelle.Parameters.AddWithValue("@p10", txtId.Text);
            guncelle.ExecuteNonQuery();
            sql.baglan().Close();
            MessageBox.Show("Bilgiler Güncelledi", "Güncelleme İşlemi Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderListesi();
            temizle();
        }

        private void txtNotlar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
