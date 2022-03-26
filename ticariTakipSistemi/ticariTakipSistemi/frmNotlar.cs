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
    public partial class frmNotlar : Form
    {
        public frmNotlar()
        {
            InitializeComponent();
        }

        baglanti sql = new baglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From NOT_KAYIT", sql.baglan());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            txtId.Text = "";
            txtTarih.Text = "";
            txtSaat.Text = "";
            txtBaslik.Text = "";
            txtIcerik.Text = "";
            txtOlusturan.Text = "";
            txtKime.Text = "";
        }
        private void frmNotlar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void btnNotKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into NOT_KAYIT (NOT_TARIH, NOT_SAAT, NOT_BASLIK, NOT_DETAY, NOT_OLUSTURAN, NOT_HANGI_PROFIL) values (@p1, @p2, @p3, @p4, @p5, @p6)", sql.baglan());
            ekle.Parameters.AddWithValue("@p1", txtTarih.Text);
            ekle.Parameters.AddWithValue("@p2", txtSaat.Text);
            ekle.Parameters.AddWithValue("@p3", txtBaslik.Text);
            ekle.Parameters.AddWithValue("@p4", txtIcerik.Text);
            ekle.Parameters.AddWithValue("@p5", txtOlusturan.Text);
            ekle.Parameters.AddWithValue("@p6", txtKime.Text);
            ekle.ExecuteNonQuery();
            sql.baglan().Close();
            MessageBox.Show("Yeni Bir Not Tanımlandı", "Ekleme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            
            if (dr != null)
            {
                txtId.Text = dr["NOT_ID"].ToString();
                txtTarih.Text = dr["NOT_TARIH"].ToString();
                txtSaat.Text = dr["NOT_SAAT"].ToString();
                txtBaslik.Text = dr["NOT_BASLIK"].ToString();
                txtIcerik.Text = dr["NOT_DETAY"].ToString();
                txtOlusturan.Text = dr["NOT_OLUSTURAN"].ToString();
                txtKime.Text = dr["NOT_HANGI_PROFIL"].ToString();
            }
        }

        private void btnNotSil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete from NOT_KAYIT where NOT_ID=@p1", sql.baglan());
            sil.Parameters.AddWithValue("@p1", txtId.Text);
            sil.ExecuteNonQuery();
            sql.baglan().Close();
            MessageBox.Show("Not Silindi", "Silme İşlemi Tamamlandı", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            listele();
        }
        
        private void btnNotGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update NOT_KAYIT set NOT_TARIH=@p1, NOT_SAAT=@p2, NOT_BASLIK=@p3, NOT_DETAY=@p4, NOT_OLUSTURAN=@p5, NOT_HANGI_PROFIL=@p6 where NOT_ID=@p7", sql.baglan());
            guncelle.Parameters.AddWithValue("@p1", txtTarih.Text);
            guncelle.Parameters.AddWithValue("@p2", txtSaat.Text);
            guncelle.Parameters.AddWithValue("@p3", txtBaslik.Text);
            guncelle.Parameters.AddWithValue("@p4", txtIcerik.Text);
            guncelle.Parameters.AddWithValue("@p5", txtOlusturan.Text);
            guncelle.Parameters.AddWithValue("@p6", txtKime.Text);
            guncelle.Parameters.AddWithValue("@p7", txtId.Text);
            guncelle.ExecuteNonQuery();
            sql.baglan().Close();
            MessageBox.Show("Bilgiler Güncelledi", "Güncelleme İşlemi Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmNotDetay fr = new frmNotDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                fr.metin = dr["NOT_DETAY"].ToString();
            }
            fr.Show();

        }
    }
}
