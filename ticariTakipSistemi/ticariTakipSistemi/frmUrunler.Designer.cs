
namespace ticariTakipSistemi
{
    partial class frmUrunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnUrunGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnUrunSil = new DevExpress.XtraEditors.SimpleButton();
            this.txtSatisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtAlisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.btnUrunKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtDetay = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.txtYil = new System.Windows.Forms.MaskedTextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtModel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtMarka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1402, 908);
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.btnUrunGuncelle);
            this.groupControl1.Controls.Add(this.btnUrunSil);
            this.groupControl1.Controls.Add(this.txtSatisFiyat);
            this.groupControl1.Controls.Add(this.txtAlisFiyat);
            this.groupControl1.Controls.Add(this.btnUrunKaydet);
            this.groupControl1.Controls.Add(this.txtDetay);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.nudAdet);
            this.groupControl1.Controls.Add(this.txtYil);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtModel);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtMarka);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtAd);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1408, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(504, 908);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTemizle.ImageOptions.SvgImage")));
            this.btnTemizle.Location = new System.Drawing.Point(117, 492);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(258, 30);
            this.btnTemizle.TabIndex = 13;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUrunGuncelle.ImageOptions.SvgImage")));
            this.btnUrunGuncelle.Location = new System.Drawing.Point(117, 456);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(258, 30);
            this.btnUrunGuncelle.TabIndex = 12;
            this.btnUrunGuncelle.Text = "Güncelle";
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUrunSil.ImageOptions.SvgImage")));
            this.btnUrunSil.Location = new System.Drawing.Point(117, 420);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(258, 30);
            this.btnUrunSil.TabIndex = 11;
            this.btnUrunSil.Text = "Sil";
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Location = new System.Drawing.Point(117, 241);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Size = new System.Drawing.Size(258, 20);
            this.txtSatisFiyat.TabIndex = 8;
            // 
            // txtAlisFiyat
            // 
            this.txtAlisFiyat.Location = new System.Drawing.Point(117, 214);
            this.txtAlisFiyat.Name = "txtAlisFiyat";
            this.txtAlisFiyat.Size = new System.Drawing.Size(258, 20);
            this.txtAlisFiyat.TabIndex = 7;
            // 
            // btnUrunKaydet
            // 
            this.btnUrunKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUrunKaydet.ImageOptions.SvgImage")));
            this.btnUrunKaydet.Location = new System.Drawing.Point(117, 384);
            this.btnUrunKaydet.Name = "btnUrunKaydet";
            this.btnUrunKaydet.Size = new System.Drawing.Size(258, 30);
            this.btnUrunKaydet.TabIndex = 10;
            this.btnUrunKaydet.Text = "Kaydet";
            this.btnUrunKaydet.Click += new System.EventHandler(this.btnUrunKaydet_Click);
            // 
            // txtDetay
            // 
            this.txtDetay.Location = new System.Drawing.Point(117, 268);
            this.txtDetay.Name = "txtDetay";
            this.txtDetay.Size = new System.Drawing.Size(258, 110);
            this.txtDetay.TabIndex = 9;
            this.txtDetay.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(74, 269);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(37, 16);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Detay:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(44, 242);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(67, 16);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Satış Fiyatı:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(52, 215);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(59, 16);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Alış Fiyatı:";
            this.labelControl7.Click += new System.EventHandler(this.labelControl7_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(80, 187);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(31, 16);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Adet:";
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(117, 187);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(258, 21);
            this.nudAdet.TabIndex = 6;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(117, 160);
            this.txtYil.Mask = "0000";
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(258, 21);
            this.txtYil.TabIndex = 5;
            this.txtYil.ValidatingType = typeof(int);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(93, 161);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(18, 16);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Yıl:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(117, 134);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(258, 20);
            this.txtModel.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(72, 135);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 16);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Model:";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(117, 108);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(258, 20);
            this.txtMarka.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(71, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Marka:";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(117, 82);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(258, 20);
            this.txtAd.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(91, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ad:";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(117, 56);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(258, 20);
            this.txtId.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(94, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // frmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmUrunler";
            this.Text = "ÜRÜNLER";
            this.Load += new System.EventHandler(this.frmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtModel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtMarka;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.MaskedTextBox txtYil;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private DevExpress.XtraEditors.SimpleButton btnUrunKaydet;
        private System.Windows.Forms.RichTextBox txtDetay;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtSatisFiyat;
        private DevExpress.XtraEditors.TextEdit txtAlisFiyat;
        private DevExpress.XtraEditors.SimpleButton btnUrunGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnUrunSil;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
    }
}