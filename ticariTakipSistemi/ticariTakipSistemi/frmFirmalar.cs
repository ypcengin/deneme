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
    public partial class frmFirmalar : Form
    {
        public frmFirmalar()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();

        void firmaListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From FIRMALAR", bgl.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void gridTemizle()
        {
            txtAd.Text = "";
            txtSektor.Text = "";
            txtYetkiliGorev.Text = "";
            txtYetkiliAdSoyad.Text = "";
            txtYetkiliTcNo.Text = "";
            txtTel1.Text = "";
            txtTel2.Text = "";
            txtTel3.Text = "";
            txtFax.Text = "";
            txtEmail.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            txtVergiDaire.Text = "";
            txtAdres.Text = "";
            txtOzelKod1.Text = "";
            txtOzelKod2.Text = "";
            txtOzelKod3.Text = "";
        }

        void cariKodAciklamalar()
        {
            SqlCommand getir = new SqlCommand("Select FIRMA_KOD_1 from KODLAR", bgl.baglan());
            SqlDataReader dr = getir.ExecuteReader();
            while (dr.Read())
            {
                txtOzelKod1Aciklama.Text = dr[0].ToString();
            }
            bgl.baglan().Close();

        }

        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select Sehir From iller", bgl.baglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIl.Properties.Items.Add(dr[0]);
            }
            bgl.baglan().Close();
        }

        void ilceListesi()
        {
            cmbIlce.Text = " ";
            cmbIlce.Properties.Items.Clear(); // her il seçildiğinde, önceki seçilen illerle ilişkili ilçeler gelmemesi için siliniyor.
            SqlCommand komut = new SqlCommand("Select ILCE from ilceler where SEHIR=@p1", bgl.baglan());
            komut.Parameters.AddWithValue("@p1", cmbIl.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIlce.Properties.Items.Add(dr[0]);
            }
            bgl.baglan().Close();
        }
        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmFirmalar_Load(object sender, EventArgs e)
        {
            firmaListesi();
            gridTemizle();
            sehirListesi();
            cariKodAciklamalar();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["ID"].ToString();
                txtAd.Text = dr["AD"].ToString();
                txtSektor.Text = dr["SEKTOR"].ToString();

                txtYetkiliGorev.Text = dr["YETKILI_STATU"].ToString();
                txtYetkiliAdSoyad.Text = dr["YETKILI_AD_SOYAD"].ToString();
                txtYetkiliTcNo.Text = dr["YETKILI_TC_NO"].ToString();

                txtTel1.Text = dr["TELEFON1"].ToString();
                txtTel2.Text = dr["TELEFON2"].ToString();
                txtTel3.Text = dr["TELEFON3"].ToString();
                txtFax.Text = dr["FAX"].ToString();
                txtEmail.Text = dr["MAIL"].ToString();

                cmbIl.Text= dr["IL"].ToString();
                cmbIlce.Text = dr["ILCE"].ToString();
                txtVergiDaire.Text = dr["VERGI_DAIRE"].ToString();
                txtAdres.Text = dr["ADRES"].ToString();

            } 
        }

        private void btnFirmaKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into FIRMALAR (AD, SEKTOR, YETKILI_STATU, YETKILI_AD_SOYAD, YETKILI_TC_NO, TELEFON1, TELEFON2, TELEFON3, FAX, MAIL, IL, ILCE, VERGI_DAIRE, ADRES, OZEL_KOD1, OZEL_KOD2, OZEL_KOD3) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11,@P12,@P13,@P14,@P15,@P16,@P17)", bgl.baglan());
            ekle.Parameters.AddWithValue("@P1", txtAd.Text);
            ekle.Parameters.AddWithValue("@P2", txtSektor.Text);
            ekle.Parameters.AddWithValue("@P3", txtYetkiliGorev.Text);
            ekle.Parameters.AddWithValue("@P4", txtYetkiliAdSoyad.Text);
            ekle.Parameters.AddWithValue("@P5", txtYetkiliTcNo.Text);
            ekle.Parameters.AddWithValue("@P6", txtTel1.Text);
            ekle.Parameters.AddWithValue("@P7", txtTel2.Text);
            ekle.Parameters.AddWithValue("@P8", txtTel3.Text);
            ekle.Parameters.AddWithValue("@P9", txtFax.Text);
            ekle.Parameters.AddWithValue("@P10", txtEmail.Text);
            ekle.Parameters.AddWithValue("@P11", cmbIl.Text);
            ekle.Parameters.AddWithValue("@P12", cmbIlce.Text);
            ekle.Parameters.AddWithValue("@P13", txtVergiDaire.Text);
            ekle.Parameters.AddWithValue("@P14", txtAdres.Text);
            ekle.Parameters.AddWithValue("@P15", txtOzelKod1.Text);
            ekle.Parameters.AddWithValue("@P16", txtOzelKod2.Text);
            ekle.Parameters.AddWithValue("@P17", txtOzelKod3.Text);
            ekle.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Firma Kaydedildi", "Ekleme İşlemi Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmaListesi();
            gridTemizle();
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceListesi();
        }

        private void btnFirmaSil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete from FIRMALAR where ID=@p1", bgl.baglan());
            sil.Parameters.AddWithValue("@p1", txtId.Text);
            sil.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Firma Silindi", "Silme İşlemi Tamamlandı", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            firmaListesi();
            gridTemizle();
        }

        private void btnFirmaGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update FIRMALAR set AD=@p1, SEKTOR=@p2, YETKILI_STATU=@p3, YETKILI_AD_SOYAD=@p4, YETKILI_TC_NO=@p5, TELEFON1=@p6, TELEFON2=@p7, TELEFON3=@p8, FAX=@p9, MAIL=@p10, IL=@p11, ILCE=@p12, VERGI_DAIRE=@p13, ADRES=@p14, OZEL_KOD1=@p15, OZEL_KOD2=@p16, OZEL_KOD3=@p17 where ID=@p18", bgl.baglan());
            guncelle.Parameters.AddWithValue("@p1", txtAd.Text);
            guncelle.Parameters.AddWithValue("@p2", txtSektor.Text);
            guncelle.Parameters.AddWithValue("@p3", txtYetkiliGorev.Text);
            guncelle.Parameters.AddWithValue("@p4", txtYetkiliAdSoyad.Text);
            guncelle.Parameters.AddWithValue("@p5", txtYetkiliTcNo.Text);
            guncelle.Parameters.AddWithValue("@p6", txtTel1.Text);
            guncelle.Parameters.AddWithValue("@p7", txtTel2.Text);
            guncelle.Parameters.AddWithValue("@p8", txtTel3.Text);
            guncelle.Parameters.AddWithValue("@p9", txtFax.Text);
            guncelle.Parameters.AddWithValue("@p10", txtEmail.Text);
            guncelle.Parameters.AddWithValue("@p11", cmbIl.Text);
            guncelle.Parameters.AddWithValue("@p12", cmbIlce.Text);
            guncelle.Parameters.AddWithValue("@p13", txtVergiDaire.Text);
            guncelle.Parameters.AddWithValue("@p14", txtAdres.Text);
            guncelle.Parameters.AddWithValue("@p15", txtOzelKod1.Text);
            guncelle.Parameters.AddWithValue("@p16", txtOzelKod2.Text);
            guncelle.Parameters.AddWithValue("@p17", txtOzelKod3.Text);
            guncelle.Parameters.AddWithValue("@p18", txtId.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Firma Bilgileri Güncellendi", "Güncelleme İşlemi Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmaListesi();
            gridTemizle();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridTemizle();
        }
    } 
}

        
    
    

