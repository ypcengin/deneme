using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticariTakipSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        frmUrunler fr;
        private void btnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null)
            {
                fr = new frmUrunler();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        frmMusteriler fr2;
        private void btnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null)
            {
                fr2 = new frmMusteriler();
                fr2.MdiParent = this;
                fr2.Show();
            }
        }
        frmFirmalar fr3;
        private void btnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null)
            {
                fr3 = new frmFirmalar();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }
        frmPersonel fr4;
        private void btnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null)
            {
                fr4 = new frmPersonel();
                fr4.MdiParent = this;
                fr4.Show();
            }
        }
        frmRehber fr5;
        private void btnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null)
            {
                fr5 = new frmRehber();
                fr5.MdiParent = this;
                fr5.Show();
            }
        }
        frmGiderler fr6;
        private void btnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr6 == null)
            {
                fr6 = new frmGiderler();
                fr6.MdiParent = this;
                fr6.Show();
            }
        }
        frmBanka fr7;
        private void btnBankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr7 == null)
            {
                fr7 = new frmBanka();
                fr7.MdiParent = this;
                fr7.Show();
            }
        }

        frmFatura fr8;
        private void btnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr8 == null)
            {
                fr8 = new frmFatura();
                fr8.MdiParent = this;
                fr8.Show();
            }
        }
        frmNotlar fr9;
        private void btnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr9 == null)
            {
                fr9 = new frmNotlar();
                fr9.MdiParent = this;
                fr9.Show();
            }
        }
        frmHareketler fr10;
        private void btnHareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr10 == null)
            {
                fr10 = new frmHareketler();
                fr10.MdiParent = this;
                fr10.Show();
            }
        }

        frmRaporlar fr11;
        private void btnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr11 == null)
            {
                fr11 = new frmRaporlar();
                fr11.MdiParent = this;
                fr11.Show();
            }
        }

        frmStoklar fr12;
        private void btnStoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr12 == null)
            {
                fr12 = new frmStoklar();
                fr12.MdiParent = this;
                fr12.Show();
            }
        }

        frmAyarlar fr13;
        private void btnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr13 == null)
            {
                fr13 = new frmAyarlar();
                fr13.MdiParent = this;
                fr13.Show();
            }
        }

        frmKasa fr14;
        private void btnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr14 == null)
            {
                fr14 = new frmKasa();
                fr14.ad = kullaniciAdi;
                fr14.MdiParent = this;
                fr14.Show();
            }
        }

        public string kullaniciAdi;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (fr15 == null)
            {
                fr15 = new frmAnaSayfa();
                fr15.MdiParent = this;
                fr15.Show();
            }
        }
        frmAnaSayfa fr15;
        private void btnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr15 == null)
            {
                fr15 = new frmAnaSayfa();
                fr15.MdiParent = this;
                fr15.Show();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
