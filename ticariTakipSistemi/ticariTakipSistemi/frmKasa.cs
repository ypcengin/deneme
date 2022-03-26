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
using DevExpress.Charts;

namespace ticariTakipSistemi
{
    public partial class frmKasa : Form
    {
        public frmKasa()
        {
            InitializeComponent();
        }

        baglanti sql = new baglanti();
        void musteriListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute firmaHareketGetir", sql.baglan());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void firmaListele()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute musteriHareketGetir", sql.baglan());
            da.Fill(dt2);
            gridControl3.DataSource = dt2;
        }
        public string ad;
        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmKasa_Load(object sender, EventArgs e)
        {
            musteriListele();
            firmaListele();

            //Toplam tutar
            SqlCommand toplamtutar = new SqlCommand("Select Sum(Tutar) from FATURA_DETAY", sql.baglan());
            SqlDataReader dr1 = toplamtutar.ExecuteReader();
            while (dr1.Read())
            {
                lblToplamTutar.Text = dr1[0].ToString() + " TL";
            }
            sql.baglan().Close();

            //son ayın faturaları
            SqlCommand sonAyFatura = new SqlCommand("Select (ELEKTRIK+SU+DOGALGAZ+INTERNET+INTERNET+EKSTRA) from GIDERLER_YENI order by GIDER_ID asc ", sql.baglan());
            SqlDataReader dr2 = sonAyFatura.ExecuteReader();
            while (dr2.Read())
            {
                lblOdemeler.Text = dr2[0].ToString() + " TL";            
            }
            sql.baglan().Close();

            //son ayın personel maaşları
            SqlCommand sonAyMaas = new SqlCommand("Select MAASLAR from GIDERLER_YENI order by GIDER_ID asc ", sql.baglan());
            SqlDataReader dr3 = sonAyMaas.ExecuteReader();
            while (dr3.Read())
            {
                lblPersonelMaas.Text = dr3[0].ToString() + " TL";
            }
            sql.baglan().Close();

            //toplam müşteri sayısı
            SqlCommand toplamMusteri = new SqlCommand("Select COUNT(*) from MUSTERILER ", sql.baglan());
            SqlDataReader dr4 = toplamMusteri.ExecuteReader();
            while (dr4.Read())
            {
                lblMusteriSayisi.Text = dr4[0].ToString();
            }
            sql.baglan().Close();

            //firma toplam sayısı
            SqlCommand toplamFirma = new SqlCommand("Select COUNT(*) from FIRMALAR ", sql.baglan());
            SqlDataReader dr5 = toplamFirma.ExecuteReader();
            while (dr5.Read())
            {
                lblFirmaSayisi.Text = dr5[0].ToString();
            }
            sql.baglan().Close();

            //firma toplam şehir sayısı
            SqlCommand toplamFirmaSehir = new SqlCommand("Select COUNT(distinct(IL)) from FIRMALAR ", sql.baglan());
            SqlDataReader dr6 = toplamFirmaSehir.ExecuteReader();
            while (dr6.Read())
            {
                lblCalisilanSehirSayisi.Text = dr6[0].ToString();
            }
            sql.baglan().Close();

            //müşteri toplam şehir sayısı
            SqlCommand toplamMusteriSehir = new SqlCommand("Select COUNT(distinct(IL)) from MUSTERILER ", sql.baglan());
            SqlDataReader dr7 = toplamMusteriSehir.ExecuteReader();
            while (dr7.Read())
            {
                lblMusteriSehirSayisi.Text = dr7[0].ToString();
            }
            sql.baglan().Close();

            //toplam personel sayısı
            SqlCommand toplamPersonel = new SqlCommand("Select COUNT(*) from PERSONELLER ", sql.baglan());
            SqlDataReader dr8 = toplamPersonel.ExecuteReader();
            while (dr8.Read())
            {
                lblPersonelSayisi.Text = dr8[0].ToString();
            }
            sql.baglan().Close();

            //toplam stok sayısı
            SqlCommand toplamStok = new SqlCommand("Select sum(ALINAN_ADET) from URUNLER ", sql.baglan());
            SqlDataReader dr9 = toplamStok.ExecuteReader();
            while (dr9.Read())
            {
                lblStokSayisi.Text = dr9[0].ToString();
            }
            sql.baglan().Close();

            //giriş yapmış kullanıcı
            lblAktifKullanici.Text = ad; //giriş, anasayfa ekranlarına birer değişken tanıttıktan sonra buraya geldik ve son işlemi yaptık.

            //1.charts da son dört ayın elektrik faturası mevcut
            SqlCommand sonDortAyElektrikGetir = new SqlCommand("Select top 4 AY, ELEKTRIK from GIDERLER_YENI order by GIDER_ID desc",sql.baglan());
            SqlDataReader dr10 = sonDortAyElektrikGetir.ExecuteReader();
            while (dr10.Read())
            {
                chartControl1.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
            }
            sql.baglan().Close();

            //2.charts da son dört ayın su faturası mevcut
            SqlCommand sonDortAySuGetir = new SqlCommand("Select top 4 AY, SU from GIDERLER_YENI order by GIDER_ID desc", sql.baglan());
            SqlDataReader dr11 = sonDortAySuGetir.ExecuteReader();
            while (dr11.Read())
            {
                chartControl2.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
            }
            sql.baglan().Close();

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
