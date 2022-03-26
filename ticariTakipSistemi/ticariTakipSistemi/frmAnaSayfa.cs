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
using System.Xml;

namespace ticariTakipSistemi
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }
        baglanti sql = new baglanti();

        void azalanStokListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec azalanStokGetir", sql.baglan());
            da.Fill(dt);
            grdStoklar.DataSource = dt;
        }
        void ajanda()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec notSonBesGetir", sql.baglan());
            da.Fill(dt);
            grdAjanda.DataSource = dt;
        }
        void sonFirmaHareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec sonFirmaHareketIslemleri", sql.baglan());
            da.Fill(dt);
            grdFirmaHareket.DataSource = dt;
        }

        void firmaFihrist()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec firmaFihristGetir", sql.baglan());
            da.Fill(dt);
            grdFihrist.DataSource = dt;
        }

        void haberler()
        {
            XmlTextReader adres = new XmlTextReader("https://www.hurriyet.com.tr/rss/anasayfa");
            while (adres.Read())
            {
                if (adres.Name == "title")
                {
                    listBox1.Items.Add(adres.ReadString());
                }
            }
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            azalanStokListele();
            ajanda();
            sonFirmaHareket();
            firmaFihrist();

            webBrowser1.Navigate("https://www.altinkaynak.com/");
        }
    }
}
