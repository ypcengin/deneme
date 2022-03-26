
namespace ticariTakipSistemi
{
    partial class frmNotlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotlar));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.txtSaat = new System.Windows.Forms.MaskedTextBox();
            this.txtTarih = new System.Windows.Forms.MaskedTextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.txtIcerik = new System.Windows.Forms.RichTextBox();
            this.btnNotGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnNotSil = new DevExpress.XtraEditors.SimpleButton();
            this.txtOlusturan = new DevExpress.XtraEditors.TextEdit();
            this.btnNotKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtKime = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtBaslik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOlusturan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslik.Properties)).BeginInit();
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
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-1, -1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1399, 519);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // txtSaat
            // 
            this.txtSaat.Location = new System.Drawing.Point(136, 99);
            this.txtSaat.Mask = "00:00";
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Size = new System.Drawing.Size(240, 21);
            this.txtSaat.TabIndex = 30;
            this.txtSaat.ValidatingType = typeof(System.DateTime);
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(136, 72);
            this.txtTarih.Mask = "00/00/0000";
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(240, 21);
            this.txtTarih.TabIndex = 29;
            this.txtTarih.ValidatingType = typeof(System.DateTime);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.txtIcerik);
            this.groupControl1.Controls.Add(this.txtSaat);
            this.groupControl1.Controls.Add(this.txtTarih);
            this.groupControl1.Controls.Add(this.btnNotGuncelle);
            this.groupControl1.Controls.Add(this.btnNotSil);
            this.groupControl1.Controls.Add(this.txtOlusturan);
            this.groupControl1.Controls.Add(this.btnNotKaydet);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtKime);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtBaslik);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1410, -1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(501, 519);
            this.groupControl1.TabIndex = 5;
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTemizle.ImageOptions.SvgImage")));
            this.btnTemizle.Location = new System.Drawing.Point(136, 456);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(240, 30);
            this.btnTemizle.TabIndex = 32;
            this.btnTemizle.Text = "Temizle";
            // 
            // txtIcerik
            // 
            this.txtIcerik.Location = new System.Drawing.Point(136, 204);
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(240, 125);
            this.txtIcerik.TabIndex = 31;
            this.txtIcerik.Text = "";
            // 
            // btnNotGuncelle
            // 
            this.btnNotGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNotGuncelle.ImageOptions.SvgImage")));
            this.btnNotGuncelle.Location = new System.Drawing.Point(136, 420);
            this.btnNotGuncelle.Name = "btnNotGuncelle";
            this.btnNotGuncelle.Size = new System.Drawing.Size(240, 30);
            this.btnNotGuncelle.TabIndex = 24;
            this.btnNotGuncelle.Text = "Güncelle";
            this.btnNotGuncelle.Click += new System.EventHandler(this.btnNotGuncelle_Click);
            // 
            // btnNotSil
            // 
            this.btnNotSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNotSil.ImageOptions.SvgImage")));
            this.btnNotSil.Location = new System.Drawing.Point(136, 384);
            this.btnNotSil.Name = "btnNotSil";
            this.btnNotSil.Size = new System.Drawing.Size(240, 30);
            this.btnNotSil.TabIndex = 23;
            this.btnNotSil.Text = "Sil";
            this.btnNotSil.Click += new System.EventHandler(this.btnNotSil_Click);
            // 
            // txtOlusturan
            // 
            this.txtOlusturan.Location = new System.Drawing.Point(136, 152);
            this.txtOlusturan.Name = "txtOlusturan";
            this.txtOlusturan.Size = new System.Drawing.Size(240, 20);
            this.txtOlusturan.TabIndex = 21;
            // 
            // btnNotKaydet
            // 
            this.btnNotKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNotKaydet.ImageOptions.SvgImage")));
            this.btnNotKaydet.Location = new System.Drawing.Point(136, 348);
            this.btnNotKaydet.Name = "btnNotKaydet";
            this.btnNotKaydet.Size = new System.Drawing.Size(240, 30);
            this.btnNotKaydet.TabIndex = 20;
            this.btnNotKaydet.Text = "Kaydet";
            this.btnNotKaydet.Click += new System.EventHandler(this.btnNotKaydet_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(70, 153);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(60, 16);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Oluşturan:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(97, 179);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(33, 16);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Kime:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(94, 205);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 16);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "İçerik:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(93, 127);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 16);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Başlık:";
            // 
            // txtKime
            // 
            this.txtKime.Location = new System.Drawing.Point(136, 178);
            this.txtKime.Name = "txtKime";
            this.txtKime.Size = new System.Drawing.Size(240, 20);
            this.txtKime.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(99, 100);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Saat:";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(136, 126);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(240, 20);
            this.txtBaslik.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(95, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tarih:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(136, 46);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(240, 20);
            this.txtId.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(113, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // frmNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmNotlar";
            this.Text = "NOTLAR";
            this.Load += new System.EventHandler(this.frmNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOlusturan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.MaskedTextBox txtSaat;
        private System.Windows.Forms.MaskedTextBox txtTarih;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private System.Windows.Forms.RichTextBox txtIcerik;
        private DevExpress.XtraEditors.SimpleButton btnNotGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnNotSil;
        private DevExpress.XtraEditors.TextEdit txtOlusturan;
        private DevExpress.XtraEditors.SimpleButton btnNotKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtKime;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtBaslik;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}