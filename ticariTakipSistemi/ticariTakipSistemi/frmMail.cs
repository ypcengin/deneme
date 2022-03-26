using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace ticariTakipSistemi
{
    public partial class frmMail : Form
    {
        public frmMail()
        {
            InitializeComponent();
        }
        public string mail;
        private void frmMail_Load(object sender, EventArgs e)
        {
            txtMailAdres.Text = mail;
        }

        private void btnMailGonder_Click(object sender, EventArgs e)
        {
            MailMessage msg = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("ornek mail adresi", "ornek mail adresi şifresi");
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;
            msg.To.Add(txtMailAdres.Text);
            msg.From = new MailAddress("gonderim mail adresi");
            msg.Subject = txtMailKonu.Text;
            msg.Body = txtMailDetay.Text;
            istemci.Send(msg);
        }
    }
}
