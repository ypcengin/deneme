
namespace ticariTakipSistemi
{
    partial class frmAyarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAyarlar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtEposta = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbKullanimDurum = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnKullaniciGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.lblKullaniciId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEposta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKullanimDurum.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(832, 200);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-Posta:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(54, 310);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifre.Properties.Appearance.Options.UseFont = true;
            this.txtSifre.Size = new System.Drawing.Size(244, 22);
            this.txtSifre.TabIndex = 4;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(54, 247);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(244, 22);
            this.txtKullaniciAdi.TabIndex = 5;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(54, 373);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEposta.Properties.Appearance.Options.UseFont = true;
            this.txtEposta.Size = new System.Drawing.Size(244, 22);
            this.txtEposta.TabIndex = 6;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(54, 212);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton2.Size = new System.Drawing.Size(39, 29);
            this.simpleButton2.TabIndex = 8;
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(54, 338);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton3.Size = new System.Drawing.Size(39, 29);
            this.simpleButton3.TabIndex = 9;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton4.ImageOptions.SvgImage")));
            this.simpleButton4.Location = new System.Drawing.Point(54, 275);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton4.Size = new System.Drawing.Size(39, 29);
            this.simpleButton4.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(471, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(179, 485);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(119, 57);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(54, 410);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(39, 29);
            this.simpleButton1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kullanım Durumu:";
            // 
            // cmbKullanimDurum
            // 
            this.cmbKullanimDurum.Location = new System.Drawing.Point(54, 445);
            this.cmbKullanimDurum.Name = "cmbKullanimDurum";
            this.cmbKullanimDurum.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKullanimDurum.Properties.Appearance.Options.UseFont = true;
            this.cmbKullanimDurum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbKullanimDurum.Properties.Items.AddRange(new object[] {
            "Aktif Olarak Kullanılıyor",
            "!! Kullanılmıyor (Ayrıldı)",
            "!! Kullanılmıyor (Cezalı)",
            "!! Kullanılmıyor (Diğer)"});
            this.cmbKullanimDurum.Size = new System.Drawing.Size(244, 22);
            this.cmbKullanimDurum.TabIndex = 15;
            // 
            // btnKullaniciGuncelle
            // 
            this.btnKullaniciGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKullaniciGuncelle.Appearance.Options.UseFont = true;
            this.btnKullaniciGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton5.ImageOptions.SvgImage")));
            this.btnKullaniciGuncelle.Location = new System.Drawing.Point(54, 485);
            this.btnKullaniciGuncelle.Name = "btnKullaniciGuncelle";
            this.btnKullaniciGuncelle.Size = new System.Drawing.Size(119, 57);
            this.btnKullaniciGuncelle.TabIndex = 16;
            this.btnKullaniciGuncelle.Text = "Güncelle";
            this.btnKullaniciGuncelle.Click += new System.EventHandler(this.btnKullaniciGuncelle_Click);
            // 
            // lblKullaniciId
            // 
            this.lblKullaniciId.AutoSize = true;
            this.lblKullaniciId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullaniciId.ForeColor = System.Drawing.Color.White;
            this.lblKullaniciId.Location = new System.Drawing.Point(304, 250);
            this.lblKullaniciId.Name = "lblKullaniciId";
            this.lblKullaniciId.Size = new System.Drawing.Size(0, 16);
            this.lblKullaniciId.TabIndex = 17;
            // 
            // frmAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 630);
            this.Controls.Add(this.lblKullaniciId);
            this.Controls.Add(this.btnKullaniciGuncelle);
            this.Controls.Add(this.cmbKullanimDurum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAyarlar";
            this.Text = "AYARLAR";
            this.Load += new System.EventHandler(this.frmAyarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEposta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKullanimDurum.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit txtEposta;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.ComboBoxEdit cmbKullanimDurum;
        private DevExpress.XtraEditors.SimpleButton btnKullaniciGuncelle;
        private System.Windows.Forms.Label lblKullaniciId;
    }
}