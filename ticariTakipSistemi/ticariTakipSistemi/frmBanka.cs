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
    public partial class frmBanka : Form
    {
        public frmBanka()
        {
            InitializeComponent();
        }
        baglanti sql = new baglanti();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute BankaBilgileri", sql.baglan());
            da.Fill(dt);
            gridControl1.DataSource = dt;
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

        void firmaListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID, AD from FIRMALAR", sql.baglan());
            da.Fill(dt);
            lookUpEdit1.Properties.NullText = "Lütfen Firmayı Belirleyiniz.";
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.DataSource = dt;
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
        void temizle()
        {
            txtAd.Text = "";
            txtSube.Text = "";
            txtIban.Text = "";
            txtHesapNo.Text = "";
            txtTarih.Text = "";
            txtHesapTuru.Text = "";
            lookUpEdit1.EditValue = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            txtTel1.Text = "";
            txtYetkili.Text = "";
        }
        private void labelControl11_Click(object sender, EventArgs e)
        {

        }

        private void frmBanka_Load(object sender, EventArgs e)
        {
            listele();
            sehirListesi();
            firmaListesi();
        }

        private void btnBankaKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into BANKALAR (BANKA_ADI, SUBE, IBAN, HESAP_NO, TARIH, HESAP_TURU, FIRMA_ID, IL, ILCE, TELEFON, YETKILI) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", sql.baglan());
            ekle.Parameters.AddWithValue("@p1", txtAd.Text);
            ekle.Parameters.AddWithValue("@p2", txtSube.Text);
            ekle.Parameters.AddWithValue("@p3", txtIban.Text);
            ekle.Parameters.AddWithValue("@p4", txtHesapNo.Text);
            ekle.Parameters.AddWithValue("@p5", txtTarih.Text);
            ekle.Parameters.AddWithValue("@p6", txtHesapTuru.Text);
            ekle.Parameters.AddWithValue("@p7", lookUpEdit1.EditValue);
            ekle.Parameters.AddWithValue("@p8", cmbIl.Text);
            ekle.Parameters.AddWithValue("@p9", cmbIlce.Text);
            ekle.Parameters.AddWithValue("@p10", txtTel1.Text);
            ekle.Parameters.AddWithValue("@p11", txtYetkili.Text);
            ekle.ExecuteNonQuery();
            sql.baglan().Close();
            MessageBox.Show("Bigliler Kaydedildi", "Ekleme İşlemi Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
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
                txtId.Text = dr["BANKA ID"].ToString();
                txtAd.Text = dr["BANKA ADI"].ToString();
                txtSube.Text =  dr["ŞUBE"].ToString();
                txtIban.Text =  dr["IBAN BİLGİSİ"].ToString();
                txtHesapNo.Text = dr["HESAP NUMARASI"].ToString();
                txtTarih.Text = dr["İŞLEM TARİHİ"].ToString();
                txtHesapTuru.Text = dr["HESAP TÜRÜ"].ToString();
                //lookUpEdit1.Text =  dr["IL"].ToString();
                cmbIl.Text = dr["BANKA İL"].ToString();
                cmbIlce.Text = dr["BANKA İLÇE"].ToString();
                txtTel1.Text = dr["TELEFON"].ToString();
                txtYetkili.Text = dr["YETKİLİ"].ToString();
            }
            
        }

        private void btnBankaTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnBankaSil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete from BANKALAR where ID=@p1", sql.baglan());
            sil.Parameters.AddWithValue("@p1", txtId.Text);
            sil.ExecuteNonQuery();
            sql.baglan().Close();
            MessageBox.Show("Banka Silindi", "Silme İşlemi Tamamlandı", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            listele();
            temizle();
        }

        private void btnBankaGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update BANKALAR set BANKA_ADI=@p1, SUBE=@p2, IBAN=@p3, HESAP_NO=@p4, TARIH=@p5, HESAP_TURU=@p6, FIRMA_ID=@p7, IL=@p8, ILCE=@p9, TELEFON=@p10, YETKILI=@p11 where ID=@p12", sql.baglan());
            guncelle.Parameters.AddWithValue("@p1", txtAd.Text);
            guncelle.Parameters.AddWithValue("@p2", txtSube.Text);
            guncelle.Parameters.AddWithValue("@p3", txtIban.Text);
            guncelle.Parameters.AddWithValue("@p4", txtHesapNo.Text);
            guncelle.Parameters.AddWithValue("@p5", txtTarih.Text);
            guncelle.Parameters.AddWithValue("@p6", txtHesapTuru.Text);
            guncelle.Parameters.AddWithValue("@p7", lookUpEdit1.EditValue);
            guncelle.Parameters.AddWithValue("@p8", cmbIl.Text);
            guncelle.Parameters.AddWithValue("@p9", cmbIlce.Text);
            guncelle.Parameters.AddWithValue("@p10", txtTel1.Text);
            guncelle.Parameters.AddWithValue("@p11", txtYetkili.Text);
            guncelle.Parameters.AddWithValue("@p12", txtId.Text);
            guncelle.ExecuteNonQuery();
            sql.baglan().Close();
            sql.baglan().Close();
            MessageBox.Show("Bigliler Güncellendi", "Güncelleme İşlemi Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }
    }
}
