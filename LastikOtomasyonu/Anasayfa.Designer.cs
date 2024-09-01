
namespace LastikOtomasyonu
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.btnlastikekle = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxMarka = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textEbat = new DevExpress.XtraEditors.TextEdit();
            this.dataGridListele = new System.Windows.Forms.DataGridView();
            this.panelListele = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnMuhasebe = new DevExpress.XtraEditors.SimpleButton();
            this.btnLastiksil = new DevExpress.XtraEditors.SimpleButton();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.btnFiyatGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEbat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelListele)).BeginInit();
            this.panelListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnlastikekle
            // 
            this.btnlastikekle.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnlastikekle.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlastikekle.Appearance.Options.UseBackColor = true;
            this.btnlastikekle.Appearance.Options.UseFont = true;
            this.btnlastikekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnlastikekle.ImageOptions.Image")));
            this.btnlastikekle.Location = new System.Drawing.Point(12, 6);
            this.btnlastikekle.Name = "btnlastikekle";
            this.btnlastikekle.Size = new System.Drawing.Size(129, 37);
            this.btnlastikekle.TabIndex = 7;
            this.btnlastikekle.Text = "LastikEkle";
            this.btnlastikekle.Click += new System.EventHandler(this.btnlastikekle_Click);
            // 
            // comboBoxMarka
            // 
            this.comboBoxMarka.Location = new System.Drawing.Point(358, 22);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxMarka.Properties.Items.AddRange(new object[] {
            "Apollo",
            "Bridgestone",
            "Continental",
            "Dunlop",
            "Evergreen",
            "Falken",
            "Goodyear",
            "Hankook",
            "Ironman",
            "Jinyu",
            "Kumho",
            "Linglong",
            "Laufenn",
            "Lassa",
            "Michelin",
            "Nexen",
            "Starmax",
            "Petlas",
            "Pirelli",
            "Roadstone"});
            this.comboBoxMarka.Size = new System.Drawing.Size(140, 20);
            this.comboBoxMarka.TabIndex = 6;
            // 
            // btnAra
            // 
            this.btnAra.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Appearance.Options.UseFont = true;
            this.btnAra.Location = new System.Drawing.Point(504, 17);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(122, 29);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ebat";
            // 
            // textEbat
            // 
            this.textEbat.Location = new System.Drawing.Point(67, 12);
            this.textEbat.Name = "textEbat";
            this.textEbat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.textEbat.Properties.Appearance.Options.UseFont = true;
            this.textEbat.Size = new System.Drawing.Size(135, 32);
            this.textEbat.TabIndex = 2;
            this.textEbat.EditValueChanged += new System.EventHandler(this.textEbat_EditValueChanged);
            // 
            // dataGridListele
            // 
            this.dataGridListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListele.Location = new System.Drawing.Point(5, 68);
            this.dataGridListele.Name = "dataGridListele";
            this.dataGridListele.Size = new System.Drawing.Size(743, 311);
            this.dataGridListele.TabIndex = 1;
            this.dataGridListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridListele_CellContentClick);
            // 
            // panelListele
            // 
            this.panelListele.Controls.Add(this.label2);
            this.panelListele.Controls.Add(this.comboBoxMarka);
            this.panelListele.Controls.Add(this.btnAra);
            this.panelListele.Controls.Add(this.label1);
            this.panelListele.Controls.Add(this.textEbat);
            this.panelListele.Controls.Add(this.dataGridListele);
            this.panelListele.Controls.Add(this.btnListele);
            this.panelListele.Location = new System.Drawing.Point(0, 102);
            this.panelListele.Name = "panelListele";
            this.panelListele.Size = new System.Drawing.Size(880, 415);
            this.panelListele.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(208, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lastik Markası";
            // 
            // btnListele
            // 
            this.btnListele.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Appearance.Options.UseFont = true;
            this.btnListele.Location = new System.Drawing.Point(632, 19);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(122, 29);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Listele";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnlastikekle);
            this.panelControl2.Controls.Add(this.btnMuhasebe);
            this.panelControl2.Controls.Add(this.btnLastiksil);
            this.panelControl2.Controls.Add(this.btnCikis);
            this.panelControl2.Controls.Add(this.btnFiyatGuncelle);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 51);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(766, 57);
            this.panelControl2.TabIndex = 18;
            // 
            // btnMuhasebe
            // 
            this.btnMuhasebe.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMuhasebe.Appearance.Options.UseFont = true;
            this.btnMuhasebe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMuhasebe.ImageOptions.Image")));
            this.btnMuhasebe.Location = new System.Drawing.Point(454, 8);
            this.btnMuhasebe.Name = "btnMuhasebe";
            this.btnMuhasebe.Size = new System.Drawing.Size(142, 37);
            this.btnMuhasebe.TabIndex = 6;
            this.btnMuhasebe.Text = "Muhasebe";
            this.btnMuhasebe.Click += new System.EventHandler(this.btnMuhasebe_Click);
            // 
            // btnLastiksil
            // 
            this.btnLastiksil.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLastiksil.Appearance.Options.UseFont = true;
            this.btnLastiksil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLastiksil.ImageOptions.Image")));
            this.btnLastiksil.Location = new System.Drawing.Point(147, 6);
            this.btnLastiksil.Name = "btnLastiksil";
            this.btnLastiksil.Size = new System.Drawing.Size(129, 37);
            this.btnLastiksil.TabIndex = 3;
            this.btnLastiksil.Text = "LastikSil";
            this.btnLastiksil.Click += new System.EventHandler(this.btnLastiksil_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.Appearance.Options.UseFont = true;
            this.btnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.Image")));
            this.btnCikis.Location = new System.Drawing.Point(602, 8);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(129, 37);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnFiyatGuncelle
            // 
            this.btnFiyatGuncelle.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiyatGuncelle.Appearance.Options.UseFont = true;
            this.btnFiyatGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFiyatGuncelle.ImageOptions.Image")));
            this.btnFiyatGuncelle.Location = new System.Drawing.Point(282, 7);
            this.btnFiyatGuncelle.Name = "btnFiyatGuncelle";
            this.btnFiyatGuncelle.Size = new System.Drawing.Size(166, 37);
            this.btnFiyatGuncelle.TabIndex = 1;
            this.btnFiyatGuncelle.Text = "LastikGüncelleme";
            this.btnFiyatGuncelle.Click += new System.EventHandler(this.btnFiyatGuncelle_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(33, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 24);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "C# ";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(86, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(154, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "İBRAHİM TERZİ ";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Blue;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(766, 51);
            this.panelControl1.TabIndex = 17;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(306, 14);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(117, 23);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "OTO LASTİK";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 493);
            this.Controls.Add(this.panelListele);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEbat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelListele)).EndInit();
            this.panelListele.ResumeLayout(false);
            this.panelListele.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnlastikekle;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxMarka;
        private DevExpress.XtraEditors.PanelControl panelListele;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEbat;
        private System.Windows.Forms.DataGridView dataGridListele;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnMuhasebe;
        private DevExpress.XtraEditors.SimpleButton btnLastiksil;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private DevExpress.XtraEditors.SimpleButton btnFiyatGuncelle;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}