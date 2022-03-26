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
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }

        baglanti bgl = new baglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From MUSTERILER", bgl.baglan());
            da.Fill(dt);
            gridControl1.DataSource = dt;
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

        void temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTel1.Text = "";
            txtTel2.Text = "";
            txtTcNo.Text = "";
            txtEmail.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            txtAdres.Text = "";
            txtVergiDaire.Text = "";
            txtId.Text = "";
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            listele();
            sehirListesi();
            
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceListesi();
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete from MUSTERILER where ID=@p1", bgl.baglan());
            sil.Parameters.AddWithValue("@p1", txtId.Text);
            sil.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Müşteri Silindi", "Silme İşlemi Tamamlandı", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            listele();
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update MUSTERILER set AD=@p1,SOYAD=@p2,TELEFON=@p3,TELEFON2=@p4,TC_NO=@p5,MAIL=@p6,IL=@p7,ILCE=@p8,ADRES=@p9,VERGI_DAIRE=@p10 where ID=@p11",bgl.baglan());
            guncelle.Parameters.AddWithValue("@p1", txtAd.Text);
            guncelle.Parameters.AddWithValue("@p2", txtSoyad.Text);
            guncelle.Parameters.AddWithValue("@p3", txtTel1.Text);
            guncelle.Parameters.AddWithValue("@p4", txtTel2.Text);
            guncelle.Parameters.AddWithValue("@p5", txtTcNo.Text);
            guncelle.Parameters.AddWithValue("@p6", txtEmail.Text);
            guncelle.Parameters.AddWithValue("@p7", cmbIl.Text);
            guncelle.Parameters.AddWithValue("@p8", cmbIlce.Text);
            guncelle.Parameters.AddWithValue("@p9", txtAdres.Text);
            guncelle.Parameters.AddWithValue("@p10", txtVergiDaire.Text);
            guncelle.Parameters.AddWithValue("@p11", txtId.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Bilgiler Güncelledi", "Güncelleme İşlemi Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnMusteriKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into MUSTERILER (AD,SOYAD,TELEFON,TELEFON2,TC_NO,MAIL,IL,ILCE,ADRES,VERGI_DAIRE) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10)", bgl.baglan());
            ekle.Parameters.AddWithValue("@p1", txtAd.Text);
            ekle.Parameters.AddWithValue("@p2", txtSoyad.Text);
            ekle.Parameters.AddWithValue("@p3", txtTel1.Text);
            ekle.Parameters.AddWithValue("@p4", txtTel2.Text);
            ekle.Parameters.AddWithValue("@p5", txtTcNo.Text);
            ekle.Parameters.AddWithValue("@p6", txtEmail.Text);
            ekle.Parameters.AddWithValue("@p7", cmbIl.Text);
            ekle.Parameters.AddWithValue("@p8", cmbIlce.Text);
            ekle.Parameters.AddWithValue("@p9", txtAdres.Text);
            ekle.Parameters.AddWithValue("@p10", txtVergiDaire.Text);
            ekle.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Müşteri Tanımlandı", "Ekleme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["ID"].ToString();
                txtAd.Text = dr["AD"].ToString();
                txtSoyad.Text = dr["SOYAD"].ToString();

                txtTel1.Text = dr["TELEFON"].ToString();
                txtTel2.Text = dr["TELEFON2"].ToString();
                txtTcNo.Text = dr["TC_NO"].ToString();

                txtEmail.Text = dr["MAIL"].ToString();
                cmbIl.Text = dr["IL"].ToString();
                cmbIlce.Text = dr["ILCE"].ToString();

                txtAdres.Text=dr["ADRES"].ToString();
                txtVergiDaire.Text = dr["VERGI_DAIRE"].ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
