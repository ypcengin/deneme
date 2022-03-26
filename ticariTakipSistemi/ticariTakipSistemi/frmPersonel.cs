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
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }
        baglanti sql = new baglanti();
        void personelListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from PERSONELLER", sql.baglan());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTel1.Text = "";
            txtTcNo.Text = "";
            txtEmail.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            txtAdres.Text = "";
            txtGorev.Text = "";
        }
        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select Sehir From iller", sql.baglan());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIl.Properties.Items.Add(dr[0]);
            }
            sql.baglan().Close();
        }

        void ilceListesi()
        {
            cmbIlce.Properties.Items.Clear(); // her il seçildiğinde, önceki seçilen illerle ilişkili ilçeler gelmemesi için siliniyor.
            SqlCommand komut = new SqlCommand("Select ILCE from ilceler where SEHIR=@p1", sql.baglan());
            komut.Parameters.AddWithValue("@p1", cmbIl.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIlce.Properties.Items.Add(dr[0]);
            }
            sql.baglan().Close();
        }
        private void frmPersonel_Load(object sender, EventArgs e)
        {
            personelListele();
            sehirListesi();
            temizle();
        }

        private void btnPersonelKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into PERSONELLER (AD, SOYAD, TELEFON, TC_NO, MAIL, IL, ILCE, ADRES, GOREV) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", sql.baglan());
            ekle.Parameters.AddWithValue("@p1", txtAd.Text);
            ekle.Parameters.AddWithValue("@p2", txtSoyad.Text);
            ekle.Parameters.AddWithValue("@p3", txtTel1.Text);
            ekle.Parameters.AddWithValue("@p4", txtTcNo.Text);
            ekle.Parameters.AddWithValue("@p5", txtEmail.Text);
            ekle.Parameters.AddWithValue("@p6", cmbIl.Text);
            ekle.Parameters.AddWithValue("@p7", cmbIlce.Text);
            ekle.Parameters.AddWithValue("@p8", txtAdres.Text);
            ekle.Parameters.AddWithValue("@p9", txtGorev.Text);
            ekle.ExecuteNonQuery();
            sql.baglan().Close();
            MessageBox.Show("Bigliler Kaydedildi", "Ekleme İşlemi Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personelListele();
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceListesi();
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
                txtTcNo.Text = dr["TC_NO"].ToString();
                txtEmail.Text = dr["MAIL"].ToString();
                cmbIl.Text = dr["IL"].ToString();
                cmbIlce.Text = dr["ILCE"].ToString();
                txtAdres.Text = dr["ADRES"].ToString();
                txtGorev.Text = dr["GOREV"].ToString();
            }
        }

        private void btnPersonelTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete from PERSONELLER where ID=@p1", sql.baglan());
            sil.Parameters.AddWithValue("@p1", txtId.Text);
            sil.ExecuteNonQuery();
            sql.baglan().Close();
            MessageBox.Show("Personel Silindi", "Silme İşlemi Tamamlandı", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            personelListele();
            temizle();
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update PERSONELLER set AD=@p1, SOYAD=@p2, TELEFON=@p3, TC_NO=@p4, MAIL=@p5, IL=@p6, ILCE=@p7, ADRES=@p8, GOREV=@p9 where ID=@p10", sql.baglan());
            guncelle.Parameters.AddWithValue("@p1", txtAd.Text);
            guncelle.Parameters.AddWithValue("@p2", txtSoyad.Text);
            guncelle.Parameters.AddWithValue("@p3", txtTel1.Text);
            guncelle.Parameters.AddWithValue("@p4", txtTcNo.Text);
            guncelle.Parameters.AddWithValue("@p5", txtEmail.Text);
            guncelle.Parameters.AddWithValue("@p6", cmbIl.Text);
            guncelle.Parameters.AddWithValue("@p7", cmbIlce.Text);
            guncelle.Parameters.AddWithValue("@p8", txtAdres.Text);
            guncelle.Parameters.AddWithValue("@p9", txtGorev.Text);
            guncelle.Parameters.AddWithValue("@p10", txtId.Text);
            guncelle.ExecuteNonQuery();
            sql.baglan().Close();
            MessageBox.Show("Bigliler Kaydedildi", "Güncelleme İşlemi Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personelListele();
            temizle();
        }
    }
}
