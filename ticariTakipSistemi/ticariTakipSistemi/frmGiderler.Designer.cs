
namespace ticariTakipSistemi
{
    partial class frmGiderler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiderler));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbAy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbYil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtMaaslar = new DevExpress.XtraEditors.TextEdit();
            this.txtEkstra = new DevExpress.XtraEditors.TextEdit();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.txtDogalgaz = new DevExpress.XtraEditors.TextEdit();
            this.txtSu = new DevExpress.XtraEditors.TextEdit();
            this.txtElektrik = new DevExpress.XtraEditors.TextEdit();
            this.btnGiderGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnGiderSil = new DevExpress.XtraEditors.SimpleButton();
            this.txtInternet = new DevExpress.XtraEditors.TextEdit();
            this.btnGiderKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtNotlar = new System.Windows.Forms.RichTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaaslar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEkstra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDogalgaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtElektrik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInternet.Properties)).BeginInit();
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
            this.gridControl1.Location = new System.Drawing.Point(1, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1399, 526);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(83, 269);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(39, 16);
            this.labelControl11.TabIndex = 31;
            this.labelControl11.Text = "Notlar:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(82, 242);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(40, 16);
            this.labelControl10.TabIndex = 26;
            this.labelControl10.Text = "Ekstra:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbAy);
            this.groupControl1.Controls.Add(this.cmbYil);
            this.groupControl1.Controls.Add(this.txtMaaslar);
            this.groupControl1.Controls.Add(this.txtEkstra);
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.txtDogalgaz);
            this.groupControl1.Controls.Add(this.txtSu);
            this.groupControl1.Controls.Add(this.txtElektrik);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.btnGiderGuncelle);
            this.groupControl1.Controls.Add(this.btnGiderSil);
            this.groupControl1.Controls.Add(this.txtInternet);
            this.groupControl1.Controls.Add(this.btnGiderKaydet);
            this.groupControl1.Controls.Add(this.txtNotlar);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1412, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(501, 526);
            this.groupControl1.TabIndex = 5;
            // 
            // cmbAy
            // 
            this.cmbAy.Location = new System.Drawing.Point(128, 82);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAy.Properties.Items.AddRange(new object[] {
            "OCAK",
            "ŞUBAT",
            "MART",
            "NİSAN",
            "MAYIS",
            "HAZİRAN",
            "TEMMUZ",
            "AĞUSTOS",
            "EYLÜL",
            "EKİM",
            "KASIM",
            "ARALIK"});
            this.cmbAy.Size = new System.Drawing.Size(240, 20);
            this.cmbAy.TabIndex = 2;
            // 
            // cmbYil
            // 
            this.cmbYil.Location = new System.Drawing.Point(128, 56);
            this.cmbYil.Name = "cmbYil";
            this.cmbYil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbYil.Properties.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.cmbYil.Size = new System.Drawing.Size(240, 20);
            this.cmbYil.TabIndex = 1;
            // 
            // txtMaaslar
            // 
            this.txtMaaslar.Location = new System.Drawing.Point(128, 214);
            this.txtMaaslar.Name = "txtMaaslar";
            this.txtMaaslar.Size = new System.Drawing.Size(240, 20);
            this.txtMaaslar.TabIndex = 7;
            // 
            // txtEkstra
            // 
            this.txtEkstra.Location = new System.Drawing.Point(128, 242);
            this.txtEkstra.Name = "txtEkstra";
            this.txtEkstra.Size = new System.Drawing.Size(240, 20);
            this.txtEkstra.TabIndex = 8;
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTemizle.ImageOptions.SvgImage")));
            this.btnTemizle.Location = new System.Drawing.Point(128, 487);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(240, 30);
            this.btnTemizle.TabIndex = 13;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtDogalgaz
            // 
            this.txtDogalgaz.Location = new System.Drawing.Point(128, 160);
            this.txtDogalgaz.Name = "txtDogalgaz";
            this.txtDogalgaz.Size = new System.Drawing.Size(240, 20);
            this.txtDogalgaz.TabIndex = 5;
            // 
            // txtSu
            // 
            this.txtSu.Location = new System.Drawing.Point(128, 134);
            this.txtSu.Name = "txtSu";
            this.txtSu.Size = new System.Drawing.Size(240, 20);
            this.txtSu.TabIndex = 4;
            // 
            // txtElektrik
            // 
            this.txtElektrik.Location = new System.Drawing.Point(128, 108);
            this.txtElektrik.Name = "txtElektrik";
            this.txtElektrik.Size = new System.Drawing.Size(240, 20);
            this.txtElektrik.TabIndex = 3;
            // 
            // btnGiderGuncelle
            // 
            this.btnGiderGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGiderGuncelle.ImageOptions.SvgImage")));
            this.btnGiderGuncelle.Location = new System.Drawing.Point(128, 451);
            this.btnGiderGuncelle.Name = "btnGiderGuncelle";
            this.btnGiderGuncelle.Size = new System.Drawing.Size(240, 30);
            this.btnGiderGuncelle.TabIndex = 12;
            this.btnGiderGuncelle.Text = "Güncelle";
            this.btnGiderGuncelle.Click += new System.EventHandler(this.btnGiderGuncelle_Click);
            // 
            // btnGiderSil
            // 
            this.btnGiderSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGiderSil.ImageOptions.SvgImage")));
            this.btnGiderSil.Location = new System.Drawing.Point(128, 415);
            this.btnGiderSil.Name = "btnGiderSil";
            this.btnGiderSil.Size = new System.Drawing.Size(240, 30);
            this.btnGiderSil.TabIndex = 11;
            this.btnGiderSil.Text = "Sil";
            this.btnGiderSil.Click += new System.EventHandler(this.btnGiderSil_Click);
            // 
            // txtInternet
            // 
            this.txtInternet.Location = new System.Drawing.Point(128, 188);
            this.txtInternet.Name = "txtInternet";
            this.txtInternet.Size = new System.Drawing.Size(240, 20);
            this.txtInternet.TabIndex = 6;
            // 
            // btnGiderKaydet
            // 
            this.btnGiderKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGiderKaydet.ImageOptions.SvgImage")));
            this.btnGiderKaydet.Location = new System.Drawing.Point(128, 379);
            this.btnGiderKaydet.Name = "btnGiderKaydet";
            this.btnGiderKaydet.Size = new System.Drawing.Size(240, 30);
            this.btnGiderKaydet.TabIndex = 10;
            this.btnGiderKaydet.Text = "Kaydet";
            this.btnGiderKaydet.Click += new System.EventHandler(this.btnGiderKaydet_Click);
            // 
            // txtNotlar
            // 
            this.txtNotlar.Location = new System.Drawing.Point(128, 268);
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(240, 105);
            this.txtNotlar.TabIndex = 9;
            this.txtNotlar.Text = "";
            this.txtNotlar.TextChanged += new System.EventHandler(this.txtNotlar_TextChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(72, 215);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(50, 16);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Maaşlar:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(70, 189);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 16);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "İnternet:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(65, 162);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(57, 16);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Doğalgaz:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(99, 136);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(20, 16);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Su:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(74, 109);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 16);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Elektrik:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(103, 83);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(19, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Ay:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(102, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(18, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Yıl:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(128, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(240, 20);
            this.txtId.TabIndex = 100;
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
            // frmGiderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmGiderler";
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.frmGiderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaaslar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEkstra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDogalgaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtElektrik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInternet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtMaaslar;
        private DevExpress.XtraEditors.TextEdit txtEkstra;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.TextEdit txtDogalgaz;
        private DevExpress.XtraEditors.TextEdit txtSu;
        private DevExpress.XtraEditors.TextEdit txtElektrik;
        private DevExpress.XtraEditors.SimpleButton btnGiderGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnGiderSil;
        private DevExpress.XtraEditors.TextEdit txtInternet;
        private DevExpress.XtraEditors.SimpleButton btnGiderKaydet;
        private System.Windows.Forms.RichTextBox txtNotlar;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAy;
        private DevExpress.XtraEditors.ComboBoxEdit cmbYil;
    }
}