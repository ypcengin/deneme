
namespace ticariTakipSistemi
{
    partial class frmBanka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanka));
            this.btnBankaTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.txtYetkili = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtTel1 = new System.Windows.Forms.MaskedTextBox();
            this.cmbIlce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbIl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btnBankaGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnBankaSil = new DevExpress.XtraEditors.SimpleButton();
            this.txtSube = new DevExpress.XtraEditors.TextEdit();
            this.btnBankaKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtIban = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.txtHesapNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapTuru = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtTarih = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapTuru.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBankaTemizle
            // 
            this.btnBankaTemizle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBankaTemizle.ImageOptions.SvgImage")));
            this.btnBankaTemizle.Location = new System.Drawing.Point(128, 490);
            this.btnBankaTemizle.Name = "btnBankaTemizle";
            this.btnBankaTemizle.Size = new System.Drawing.Size(240, 30);
            this.btnBankaTemizle.TabIndex = 15;
            this.btnBankaTemizle.Text = "Temizle";
            this.btnBankaTemizle.Click += new System.EventHandler(this.btnBankaTemizle_Click);
            // 
            // txtYetkili
            // 
            this.txtYetkili.Location = new System.Drawing.Point(128, 233);
            this.txtYetkili.Name = "txtYetkili";
            this.txtYetkili.Size = new System.Drawing.Size(240, 20);
            this.txtYetkili.TabIndex = 7;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(87, 287);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(35, 16);
            this.labelControl11.TabIndex = 31;
            this.labelControl11.Text = "Tarih:";
            this.labelControl11.Click += new System.EventHandler(this.labelControl11_Click);
            // 
            // txtTel1
            // 
            this.txtTel1.Location = new System.Drawing.Point(128, 259);
            this.txtTel1.Mask = "(999) 000-0000";
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(240, 21);
            this.txtTel1.TabIndex = 8;
            // 
            // cmbIlce
            // 
            this.cmbIlce.Location = new System.Drawing.Point(128, 128);
            this.cmbIlce.Name = "cmbIlce";
            this.cmbIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIlce.Size = new System.Drawing.Size(240, 20);
            this.cmbIlce.TabIndex = 3;
            // 
            // cmbIl
            // 
            this.cmbIl.Location = new System.Drawing.Point(128, 101);
            this.cmbIl.Name = "cmbIl";
            this.cmbIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIl.Size = new System.Drawing.Size(240, 20);
            this.cmbIl.TabIndex = 2;
            this.cmbIl.SelectedIndexChanged += new System.EventHandler(this.cmbIl_SelectedIndexChanged);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(99, 129);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(25, 16);
            this.labelControl10.TabIndex = 26;
            this.labelControl10.Text = "İlçe:";
            // 
            // btnBankaGuncelle
            // 
            this.btnBankaGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBankaGuncelle.ImageOptions.SvgImage")));
            this.btnBankaGuncelle.Location = new System.Drawing.Point(128, 454);
            this.btnBankaGuncelle.Name = "btnBankaGuncelle";
            this.btnBankaGuncelle.Size = new System.Drawing.Size(240, 30);
            this.btnBankaGuncelle.TabIndex = 14;
            this.btnBankaGuncelle.Text = "Güncelle";
            this.btnBankaGuncelle.Click += new System.EventHandler(this.btnBankaGuncelle_Click);
            // 
            // btnBankaSil
            // 
            this.btnBankaSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBankaSil.ImageOptions.SvgImage")));
            this.btnBankaSil.Location = new System.Drawing.Point(128, 418);
            this.btnBankaSil.Name = "btnBankaSil";
            this.btnBankaSil.Size = new System.Drawing.Size(240, 30);
            this.btnBankaSil.TabIndex = 13;
            this.btnBankaSil.Text = "Sil";
            this.btnBankaSil.Click += new System.EventHandler(this.btnBankaSil_Click);
            // 
            // txtSube
            // 
            this.txtSube.Location = new System.Drawing.Point(128, 154);
            this.txtSube.Name = "txtSube";
            this.txtSube.Size = new System.Drawing.Size(240, 20);
            this.txtSube.TabIndex = 4;
            // 
            // btnBankaKaydet
            // 
            this.btnBankaKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBankaKaydet.ImageOptions.SvgImage")));
            this.btnBankaKaydet.Location = new System.Drawing.Point(128, 382);
            this.btnBankaKaydet.Name = "btnBankaKaydet";
            this.btnBankaKaydet.Size = new System.Drawing.Size(240, 30);
            this.btnBankaKaydet.TabIndex = 12;
            this.btnBankaKaydet.Text = "Kaydet";
            this.btnBankaKaydet.Click += new System.EventHandler(this.btnBankaKaydet_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(84, 234);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(38, 16);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Yetkili:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(110, 102);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(12, 16);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "İl:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(90, 155);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(34, 16);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Şube:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(65, 207);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 16);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Hesap No:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(65, 260);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 16);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Telefon 1:";
            // 
            // txtIban
            // 
            this.txtIban.Location = new System.Drawing.Point(128, 180);
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(240, 20);
            this.txtIban.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(90, 181);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "IBAN:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(128, 75);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(240, 20);
            this.txtAd.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(63, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Banka Adı:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(128, 49);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(240, 20);
            this.txtId.TabIndex = 99;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(105, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, -2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1399, 533);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.txtHesapNo);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtHesapTuru);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.txtTarih);
            this.groupControl1.Controls.Add(this.btnBankaTemizle);
            this.groupControl1.Controls.Add(this.txtYetkili);
            this.groupControl1.Controls.Add(this.txtTel1);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.cmbIlce);
            this.groupControl1.Controls.Add(this.txtIban);
            this.groupControl1.Controls.Add(this.cmbIl);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.btnBankaGuncelle);
            this.groupControl1.Controls.Add(this.btnBankaSil);
            this.groupControl1.Controls.Add(this.txtSube);
            this.groupControl1.Controls.Add(this.btnBankaKaydet);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtAd);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1423, -2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(501, 533);
            this.groupControl1.TabIndex = 7;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(128, 339);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(240, 20);
            this.lookUpEdit1.TabIndex = 11;
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(128, 206);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(240, 20);
            this.txtHesapNo.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(84, 340);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 16);
            this.labelControl5.TabIndex = 35;
            this.labelControl5.Text = "Firma:";
            // 
            // txtHesapTuru
            // 
            this.txtHesapTuru.Location = new System.Drawing.Point(128, 313);
            this.txtHesapTuru.Name = "txtHesapTuru";
            this.txtHesapTuru.Size = new System.Drawing.Size(240, 20);
            this.txtHesapTuru.TabIndex = 10;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(53, 314);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(71, 16);
            this.labelControl12.TabIndex = 37;
            this.labelControl12.Text = "Hesap Türü:";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(128, 286);
            this.txtTarih.Mask = "00/00/0000";
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(240, 21);
            this.txtTarih.TabIndex = 9;
            this.txtTarih.ValidatingType = typeof(System.DateTime);
            // 
            // frmBanka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmBanka";
            this.Text = "Banka";
            this.Load += new System.EventHandler(this.frmBanka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapTuru.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBankaTemizle;
        private DevExpress.XtraEditors.TextEdit txtYetkili;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.MaskedTextBox txtTel1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbIlce;
        private DevExpress.XtraEditors.ComboBoxEdit cmbIl;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnBankaGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnBankaSil;
        private DevExpress.XtraEditors.TextEdit txtSube;
        private DevExpress.XtraEditors.SimpleButton btnBankaKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtIban;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtHesapTuru;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.MaskedTextBox txtTarih;
        private DevExpress.XtraEditors.TextEdit txtHesapNo;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
    }
}