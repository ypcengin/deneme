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
    public partial class frmFatura : Form
    {
        public frmFatura()
        {
            InitializeComponent();
        }
        baglanti sql = new baglanti();
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from FATURA_BILGI", sql.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void detay_listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from FATURA_DETAY", sql.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            txtId.Text = "";
            txtFaturaId.Text = "";
            txtSeri.Text = "";
            txtSiraNo.Text = "";
            txtTarih.Text = "";
            txtSaat.Text = "";
            txtVergiDairesi.Text = "";
            txtAlici.Text = "";
            txtTeslimEden.Text = "";
            txtTeslimAlan.Text = "";
        }

        private void btnFaturaKaydet_Click(object sender, EventArgs e)
        {
            if (txtFaturaId.Text == "")
            {
                SqlCommand ekle = new SqlCommand("insert into FATURA_BILGI (SERI, SIRA_NO, TARIH, SAAT, VERGI_DAIRE, ALICI, TESLIM_EDEN, TESLIM_ALAN) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8)", sql.baglan());
                ekle.Parameters.AddWithValue("@P1", txtSeri.Text);
                ekle.Parameters.AddWithValue("@P2", txtSiraNo.Text);
                ekle.Parameters.AddWithValue("@P3", txtTarih.Text);
                ekle.Parameters.AddWithValue("@P4", txtSaat.Text);
                ekle.Parameters.AddWithValue("@P5", txtVergiDairesi.Text);
                ekle.Parameters.AddWithValue("@P6", txtAlici.Text);
                ekle.Parameters.AddWithValue("@P7", txtTeslimEden.Text);
                ekle.Parameters.AddWithValue("@P8", txtTeslimAlan.Text);
                ekle.ExecuteNonQuery();
                sql.baglan().Close();
                MessageBox.Show("Firma Kaydedildi", "Ekleme İşlemi Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            if (txtFaturaId != null)
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(txtFiyat.Text);
                miktar = Convert.ToDouble(txtAdet.Text);
                tutar = fiyat * miktar;
                txtTutar.Text = tutar.ToString();
                SqlCommand detay_ekle = new SqlCommand("insert into FATURA_DETAY (URUN_AD, MIKTAR, FIYAT, TUTAR, FATURA_ID) values (@p1,@p2,@p3,@p4,@p5)", sql.baglan());
                detay_ekle.Parameters.AddWithValue("@P1", txtUrunAdi.Text);
                detay_ekle.Parameters.AddWithValue("@P2", txtAdet.Text);
                detay_ekle.Parameters.AddWithValue("@P3", decimal.Parse(txtFiyat.Text));
                detay_ekle.Parameters.AddWithValue("@P4", decimal.Parse(txtTutar.Text));
                detay_ekle.Parameters.AddWithValue("@P5", txtFaturaId.Text);
                detay_ekle.ExecuteNonQuery();
                sql.baglan().Close();

                //HAREKET TABLOSUNA VERİ EKLEME
                SqlCommand hareketeEkle = new SqlCommand("insert into FIRMA_HAREKET (URUN_ID, ADET, PERSONEL, FIRMA_ALICI, FIYAT, TOPLAM, FATURA_ID, TARIH) values (@h1, @h2, @h3, @h4, @h5, @h6, @h7, @h8)", sql.baglan());
                hareketeEkle.Parameters.AddWithValue("@h1", txtUrunId.Text);
                hareketeEkle.Parameters.AddWithValue("@h2", txtAdet.Text);
                hareketeEkle.Parameters.AddWithValue("@h3", txtPersonel.Text);
                hareketeEkle.Parameters.AddWithValue("@h4", txtFirma.Text);
                hareketeEkle.Parameters.AddWithValue("@h5", decimal.Parse(txtFiyat.Text));
                hareketeEkle.Parameters.AddWithValue("@h6", decimal.Parse(txtTutar.Text));
                hareketeEkle.Parameters.AddWithValue("@h7", txtFaturaId.Text);
                hareketeEkle.Parameters.AddWithValue("@h8", txtTarih.Text);
                hareketeEkle.ExecuteNonQuery();
                sql.baglan().Close();

                //SATIŞ SONRASI STOKTAN ÜRÜN SAYISI DÜŞÜRME
                SqlCommand stoktanDus = new SqlCommand("update URUNLER set ALINAN_ADET=ALINAN_ADET-@s1 where ID=@s2 ", sql.baglan());
                stoktanDus.Parameters.AddWithValue("@s1", txtAdet.Text);
                stoktanDus.Parameters.AddWithValue("@s2", txtUrunId.Text);
                stoktanDus.ExecuteNonQuery();
                sql.baglan().Close();

                MessageBox.Show("Faturaya Ait Detaylar Kaydedildi", "Ekleme İşlemi Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //detay_listele();
            }
        }

        private void frmFatura_Load(object sender, EventArgs e)
        {
            listele();
            temizle();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["ID"].ToString();
                txtSeri.Text=dr["SERI"].ToString();
                txtSiraNo.Text = dr["SIRA_NO"].ToString();

                txtTarih.Text = dr["TARIH"].ToString();
                txtSaat.Text = dr["SAAT"].ToString();
                txtVergiDairesi.Text = dr["VERGI_DAIRE"].ToString();

                txtAlici.Text = dr["ALICI"].ToString();
                txtTeslimEden.Text = dr["TESLIM_EDEN"].ToString();
                txtTeslimAlan.Text = dr["TESLIM_ALAN"].ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnFaturaSil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete from FATURA_BILGI where ID=@p1", sql.baglan());
            sil.Parameters.AddWithValue("@p1", txtId.Text);
            sil.ExecuteNonQuery();
            sql.baglan().Close();
            MessageBox.Show("Fatura Silindi Silindi", "Silme İşlemi Tamamlandı", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            listele();
            temizle();
        }

        private void btnFaturaGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update FATURA_BILGI set SERI=@p1, SIRA_NO=@p2, TARIH=@p3, SAAT=@p4, VERGI_DAIRE=@p5, ALICI=@p6, TESLIM_EDEN=@p7, TESLIM_ALAN=@p8 where ID=@p9", sql.baglan());
            guncelle.Parameters.AddWithValue("@p1", txtSeri.Text);
            guncelle.Parameters.AddWithValue("@p2", txtSiraNo.Text);
            guncelle.Parameters.AddWithValue("@p3", txtTarih.Text);
            guncelle.Parameters.AddWithValue("@p4", txtSaat.Text);
            guncelle.Parameters.AddWithValue("@p5", txtVergiDairesi.Text);
            guncelle.Parameters.AddWithValue("@p6", txtAlici.Text);
            guncelle.Parameters.AddWithValue("@p7", txtTeslimEden.Text);
            guncelle.Parameters.AddWithValue("@p8", txtTeslimAlan.Text);
            guncelle.Parameters.AddWithValue("@p9", txtId.Text);
            guncelle.ExecuteNonQuery();
            sql.baglan().Close();
            MessageBox.Show("Fatura Güncellendi", "Değiştirme İşlemi Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmFaturaUrunDetaylari fr_urun = new frmFaturaUrunDetaylari();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                fr_urun.id = dr["ID"].ToString();
            }
            fr_urun.Show();
        }

        private void btnUrunBilgileriGetir_Click(object sender, EventArgs e)
        {
            SqlCommand getir = new SqlCommand("select URUN_AD, SATIS_FIYAT from URUNLER where ID=@p1", sql.baglan());
            getir.Parameters.AddWithValue("@p1", txtUrunId.Text);
            SqlDataReader dr = getir.ExecuteReader();
            while (dr.Read())
            {
                txtUrunAdi.Text = dr[0].ToString();
                txtFiyat.Text = dr[1].ToString();            
            }
            sql.baglan().Close();
        }
    }
}
