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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        baglanti sql = new baglanti();
        private void btnGirisYap_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from KULLANICI where KULLANICI_ADI=@P1 AND SIFRE=@P2", sql.baglan());
            komut.Parameters.AddWithValue("@P1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@P2", txtSifresi.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                Form1 fr = new Form1();
                fr.kullaniciAdi = txtKullaniciAdi.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                txtKullaniciAdi.Text = "";
                txtSifresi.Text = "";
            }
            sql.baglan().Close();
        }

    }
}

