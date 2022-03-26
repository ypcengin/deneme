
namespace ticariTakipSistemi
{
    partial class frmMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMail));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMailAdres = new DevExpress.XtraEditors.TextEdit();
            this.txtMailKonu = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMailDetay = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMailGonder = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMailAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMailKonu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Adresi:";
            // 
            // txtMailAdres
            // 
            this.txtMailAdres.Location = new System.Drawing.Point(181, 12);
            this.txtMailAdres.Name = "txtMailAdres";
            this.txtMailAdres.Size = new System.Drawing.Size(273, 20);
            this.txtMailAdres.TabIndex = 1;
            // 
            // txtMailKonu
            // 
            this.txtMailKonu.Location = new System.Drawing.Point(181, 38);
            this.txtMailKonu.Name = "txtMailKonu";
            this.txtMailKonu.Size = new System.Drawing.Size(273, 20);
            this.txtMailKonu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Konu:";
            // 
            // txtMailDetay
            // 
            this.txtMailDetay.Location = new System.Drawing.Point(181, 64);
            this.txtMailDetay.Name = "txtMailDetay";
            this.txtMailDetay.Size = new System.Drawing.Size(273, 271);
            this.txtMailDetay.TabIndex = 4;
            this.txtMailDetay.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mail İçeriği:";
            // 
            // btnMailGonder
            // 
            this.btnMailGonder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnMailGonder.Location = new System.Drawing.Point(3, 12);
            this.btnMailGonder.Name = "btnMailGonder";
            this.btnMailGonder.Size = new System.Drawing.Size(105, 44);
            this.btnMailGonder.TabIndex = 6;
            this.btnMailGonder.Text = "Gönder";
            this.btnMailGonder.Click += new System.EventHandler(this.btnMailGonder_Click);
            // 
            // frmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 378);
            this.Controls.Add(this.btnMailGonder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMailDetay);
            this.Controls.Add(this.txtMailKonu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMailAdres);
            this.Controls.Add(this.label1);
            this.Name = "frmMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Gönderme Platformu";
            this.Load += new System.EventHandler(this.frmMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMailAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMailKonu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtMailAdres;
        private DevExpress.XtraEditors.TextEdit txtMailKonu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtMailDetay;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnMailGonder;
    }
}