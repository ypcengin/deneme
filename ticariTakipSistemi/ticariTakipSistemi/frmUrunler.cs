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
    public partial class frmUrunler : Form
    {
        public frmUrunler()
        {
            InitializeComponent();
        }
        baglanti uygulama_baglantisi = new baglanti();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From URUNLER", uygulama_baglantisi.baglan());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        void temizle()
        {
            txtAd.Text = " ";
            txtMarka.Text = " ";
            txtModel.Text = " ";
            txtYil.Text = " ";
            nudAdet.Value.ToString("0");
            txtAlisFiyat.Text = " ";
            txtSatisFiyat.Text = " ";
            txtDetay.Text = " ";
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmUrunler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into URUNLER (URUN_AD, MARKA, MODEL, YIL, ALINAN_ADET, ALIS_FIYAT, SATIS_FIYAT, DETAY) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)", uygulama_baglantisi.baglan());
            ekle.Parameters.AddWithValue("@p1", txtAd.Text);
            ekle.Parameters.AddWithValue("@p2", txtMarka.Text);
            ekle.Parameters.AddWithValue("@p3", txtModel.Text);
            ekle.Parameters.AddWithValue("@p4", txtYil.Text);
            ekle.Parameters.AddWithValue("@p5", int.Parse((nudAdet.Value).ToString()));
            ekle.Parameters.AddWithValue("@p6", decimal.Parse(txtAlisFiyat.Text)); 
            ekle.Parameters.AddWithValue("@p7", decimal.Parse(txtSatisFiyat.Text));
            ekle.Parameters.AddWithValue("@p8", txtDetay.Text);
            ekle.ExecuteNonQuery();
            uygulama_baglantisi.baglan().Close();
            MessageBox.Show("Ürün Sisteme Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            txtAd.Text = " ";
            txtMarka.Text = " ";
            txtModel.Text = " ";
            txtYil.Text = " ";
            nudAdet.Value.ToString("0");
            txtAlisFiyat.Text = " ";
            txtSatisFiyat.Text = " ";
            txtDetay.Text = " ";
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete From URUNLER where ID=@p1", uygulama_baglantisi.baglan());
            sil.Parameters.AddWithValue("@p1", txtId.Text);
            sil.ExecuteNonQuery();
            uygulama_baglantisi.baglan().Close();
            MessageBox.Show("Ürün Silindi", "Silme İşlemi Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtId.Text = dr["ID"].ToString();
            txtAd.Text = dr["URUN_AD"].ToString();
            txtMarka.Text = dr["MARKA"].ToString();
            txtModel.Text = dr["MODEL"].ToString();
            txtYil.Text = dr["YIL"].ToString();
            nudAdet.Value = decimal.Parse(dr["ALINAN_ADET"].ToString());
            txtAlisFiyat.Text = dr["ALIS_FIYAT"].ToString();
            txtSatisFiyat.Text = dr["SATIS_FIYAT"].ToString();
            txtDetay.Text = dr["DETAY"].ToString();
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update URUNLER set URUN_AD=@p1, MARKA=@p2, MODEL=@p3, YIL=@p4, ALINAN_ADET=@p5, ALIS_FIYAT=@p6, SATIS_FIYAT=@p7, DETAY=@p8 where ID=@p9", uygulama_baglantisi.baglan());
            guncelle.Parameters.AddWithValue("@p1", txtAd.Text);
            guncelle.Parameters.AddWithValue("@p2", txtMarka.Text);
            guncelle.Parameters.AddWithValue("@p3", txtModel.Text);
            guncelle.Parameters.AddWithValue("@p4", txtYil.Text);
            guncelle.Parameters.AddWithValue("@p5", int.Parse((nudAdet.Value).ToString()));
            guncelle.Parameters.AddWithValue("@p6", decimal.Parse(txtAlisFiyat.Text));
            guncelle.Parameters.AddWithValue("@p7", decimal.Parse(txtSatisFiyat.Text));
            guncelle.Parameters.AddWithValue("@p8", txtDetay.Text);
            guncelle.Parameters.AddWithValue("@p9", txtId.Text);
            guncelle.ExecuteNonQuery();
            uygulama_baglantisi.baglan().Close();
            MessageBox.Show("Ürün Bilgileri Güncellendi", "Güncelleme İşlemi Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
