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
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From KULLANICI", bgl.baglan());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            txtEposta.Text = "";
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            cmbKullanimDurum.Text = "";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into KULLANICI (KULLANICI_ADI,SIFRE,E_POSTA, KULLANIM) values (@p1, @p2, @p3, @p4)", bgl.baglan());
            ekle.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            ekle.Parameters.AddWithValue("@p2", txtSifre.Text);
            ekle.Parameters.AddWithValue("@p3", txtEposta.Text);
            ekle.Parameters.AddWithValue("@p4", cmbKullanimDurum.Text);
            ekle.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Kullanıcı Tanımlandı", "Ekleme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void btnKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update KULLANICI set KULLANICI_ADI=@p1,SIFRE=@p2,E_POSTA=@p3, KULLANIM=@p4 where ID=@p5", bgl.baglan());
            guncelle.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            guncelle.Parameters.AddWithValue("@p2", txtSifre.Text);
            guncelle.Parameters.AddWithValue("@p3", txtEposta.Text);
            guncelle.Parameters.AddWithValue("@p4", cmbKullanimDurum.Text);
            guncelle.Parameters.AddWithValue("@p5", lblKullaniciId.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglan().Close();
            MessageBox.Show("Bilgiler Güncelledi", "Güncelleme İşlemi Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                lblKullaniciId.Text = dr["ID"].ToString();
                txtKullaniciAdi.Text = dr["KULLANICI_ADI"].ToString();
                txtSifre.Text = dr["SIFRE"].ToString();
                txtEposta.Text = dr["E_POSTA"].ToString();
                cmbKullanimDurum.Text = dr["KULLANIM"].ToString();
            }
        }
    }
}
