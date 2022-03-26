
namespace ticariTakipSistemi
{
    partial class frmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonel));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.txtGorev = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtTel1 = new System.Windows.Forms.MaskedTextBox();
            this.cmbIlce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbIl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtTcNo = new System.Windows.Forms.MaskedTextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnPersonelTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnPersonelGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnPersonelSil = new DevExpress.XtraEditors.SimpleButton();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.btnPersonelKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGorev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.gridControl1.Location = new System.Drawing.Point(0, -1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1399, 533);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // txtGorev
            // 
            this.txtGorev.Location = new System.Drawing.Point(128, 240);
            this.txtGorev.Name = "txtGorev";
            this.txtGorev.Size = new System.Drawing.Size(240, 20);
            this.txtGorev.TabIndex = 8;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(82, 267);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(38, 16);
            this.labelControl11.TabIndex = 31;
            this.labelControl11.Text = "Adres:";
            // 
            // txtTel1
            // 
            this.txtTel1.Location = new System.Drawing.Point(128, 108);
            this.txtTel1.Mask = "(999) 000-0000";
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(240, 21);
            this.txtTel1.TabIndex = 3;
            // 
            // cmbIlce
            // 
            this.cmbIlce.Location = new System.Drawing.Point(128, 214);
            this.cmbIlce.Name = "cmbIlce";
            this.cmbIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIlce.Size = new System.Drawing.Size(240, 20);
            this.cmbIlce.TabIndex = 7;
            // 
            // cmbIl
            // 
            this.cmbIl.Location = new System.Drawing.Point(128, 188);
            this.cmbIl.Name = "cmbIl";
            this.cmbIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIl.Size = new System.Drawing.Size(240, 20);
            this.cmbIl.TabIndex = 6;
            this.cmbIl.SelectedIndexChanged += new System.EventHandler(this.cmbIl_SelectedIndexChanged);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(99, 215);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(25, 16);
            this.labelControl10.TabIndex = 26;
            this.labelControl10.Text = "İlçe:";
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(128, 135);
            this.txtTcNo.Mask = "00000000000";
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(240, 21);
            this.txtTcNo.TabIndex = 4;
            this.txtTcNo.ValidatingType = typeof(int);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnPersonelTemizle);
            this.groupControl1.Controls.Add(this.txtGorev);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.txtTel1);
            this.groupControl1.Controls.Add(this.cmbIlce);
            this.groupControl1.Controls.Add(this.cmbIl);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.txtTcNo);
            this.groupControl1.Controls.Add(this.btnPersonelGuncelle);
            this.groupControl1.Controls.Add(this.btnPersonelSil);
            this.groupControl1.Controls.Add(this.txtEmail);
            this.groupControl1.Controls.Add(this.btnPersonelKaydet);
            this.groupControl1.Controls.Add(this.txtAdres);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtSoyad);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtAd);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1411, -1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(501, 533);
            this.groupControl1.TabIndex = 5;
            // 
            // btnPersonelTemizle
            // 
            this.btnPersonelTemizle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPersonelTemizle.ImageOptions.SvgImage")));
            this.btnPersonelTemizle.Location = new System.Drawing.Point(126, 490);
            this.btnPersonelTemizle.Name = "btnPersonelTemizle";
            this.btnPersonelTemizle.Size = new System.Drawing.Size(240, 30);
            this.btnPersonelTemizle.TabIndex = 13;
            this.btnPersonelTemizle.Text = "Temizle";
            this.btnPersonelTemizle.Click += new System.EventHandler(this.btnPersonelTemizle_Click);
            // 
            // btnPersonelGuncelle
            // 
            this.btnPersonelGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPersonelGuncelle.ImageOptions.SvgImage")));
            this.btnPersonelGuncelle.Location = new System.Drawing.Point(126, 454);
            this.btnPersonelGuncelle.Name = "btnPersonelGuncelle";
            this.btnPersonelGuncelle.Size = new System.Drawing.Size(240, 30);
            this.btnPersonelGuncelle.TabIndex = 12;
            this.btnPersonelGuncelle.Text = "Güncelle";
            this.btnPersonelGuncelle.Click += new System.EventHandler(this.btnPersonelGuncelle_Click);
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPersonelSil.ImageOptions.SvgImage")));
            this.btnPersonelSil.Location = new System.Drawing.Point(126, 418);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(240, 30);
            this.btnPersonelSil.TabIndex = 11;
            this.btnPersonelSil.Text = "Sil";
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(128, 162);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // btnPersonelKaydet
            // 
            this.btnPersonelKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPersonelKaydet.ImageOptions.SvgImage")));
            this.btnPersonelKaydet.Location = new System.Drawing.Point(126, 382);
            this.btnPersonelKaydet.Name = "btnPersonelKaydet";
            this.btnPersonelKaydet.Size = new System.Drawing.Size(240, 30);
            this.btnPersonelKaydet.TabIndex = 10;
            this.btnPersonelKaydet.Text = "Kaydet";
            this.btnPersonelKaydet.Click += new System.EventHandler(this.btnPersonelKaydet_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(126, 266);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(240, 110);
            this.txtAdres.TabIndex = 9;
            this.txtAdres.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(84, 241);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(38, 16);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Görev:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(110, 189);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(12, 16);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "İl:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(41, 163);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(81, 16);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "e-mail Adresi:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(37, 136);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(85, 16);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "T.C. Kimlik No:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(63, 109);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 16);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Telefon 1:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(128, 82);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(240, 20);
            this.txtSoyad.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(82, 83);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(128, 56);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(240, 20);
            this.txtAd.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(102, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ad:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(128, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(240, 20);
            this.txtId.TabIndex = 990;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(105, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmPersonel";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.frmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGorev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.TextEdit txtGorev;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.MaskedTextBox txtTel1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbIlce;
        private DevExpress.XtraEditors.ComboBoxEdit cmbIl;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.MaskedTextBox txtTcNo;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnPersonelTemizle;
        private DevExpress.XtraEditors.SimpleButton btnPersonelGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnPersonelSil;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.SimpleButton btnPersonelKaydet;
        private System.Windows.Forms.RichTextBox txtAdres;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}