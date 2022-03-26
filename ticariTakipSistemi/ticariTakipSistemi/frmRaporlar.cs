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
    public partial class frmRaporlar : Form
    {
        public frmRaporlar()
        {
            InitializeComponent();
        }

        private void frmRaporlar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'TICARI_DBODataSet.FIRMALAR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.FIRMALARTableAdapter.Fill(this.TICARI_DBODataSet.FIRMALAR);

            this.reportViewer1.RefreshReport();
        }
    }
}
