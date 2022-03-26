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
    public partial class frmFaturaUrunDuzenleme : Form
    {
        public frmFaturaUrunDuzenleme()
        {
            InitializeComponent();
        }
        baglanti sql = new baglanti();
        public string urunid;
        private void frmFaturaUrunDuzenleme_Load(object sender, EventArgs e)
        {
            txtUrunId.Text = urunid;
            SqlCommand listele = new SqlCommand("select * from FATURA_DETAY where FATURA_URUN_ID=@p1", sql.baglan());
            listele.Parameters.AddWithValue("@p1", urunid);
            SqlDataReader dr = listele.ExecuteReader();

            while (dr.Read())
            {
                txtFiyat.Text = dr[3].ToString();
                txtAdet.Text = dr[2].ToString();
                txtTutar.Text = dr[4].ToString();
                txtUrunAdi.Text = dr[1].ToString();

                sql.baglan().Close();
            }

        }

        private void btnFaturaGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update FATURA_DETAY set URUN_AD=@p1, MIKTAR=@p2, FIYAT=@p3, TUTAR=@p4 where FATURA_URUN_ID=@p5 ", sql.baglan());
            guncelle.Parameters.AddWithValue("@p1", txtUrunAdi.Text);
            guncelle.Parameters.AddWithValue("@p2", txtAdet.Text);
            guncelle.Parameters.AddWithValue("@p3", decimal.Parse(txtFiyat.Text));
            guncelle.Parameters.AddWithValue("@p4", decimal.Parse(txtTutar.Text));
            guncelle.Parameters.AddWithValue("@p5", txtUrunId.Text);
            guncelle.ExecuteNonQuery();
            sql.baglan().Close();
            MessageBox.Show("Değişiklikler Kaydedildi", "Faturaya Ait Ürün Bilgileri Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            
        }

        private void btnFaturaSil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete from FATURA_DETAY where ID=@p1", sql.baglan());
            sil.Parameters.AddWithValue("@p1", txtUrunAdi.Text);
            sil.ExecuteNonQuery();
            sql.baglan().Close();
            MessageBox.Show("Faturaya Ait Ürün Bilgi Bilgisi Silindi", "Silme İşlemi Tamamlandı", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
        }
    }
}
