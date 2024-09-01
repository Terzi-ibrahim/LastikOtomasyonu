
namespace LastikOtomasyonu
{
    partial class LastikGüncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LastikGüncelle));
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAnasayfa = new DevExpress.XtraEditors.SimpleButton();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelEbat = new DevExpress.XtraEditors.LabelControl();
            this.textEbat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textUrunİd = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEbat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUrunİd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(388, 9);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(117, 48);
            this.btnEkle.TabIndex = 37;
            this.btnEkle.Text = "Güncelle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(504, 187);
            this.dataGridView1.TabIndex = 36;
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnasayfa.ImageOptions.Image")));
            this.btnAnasayfa.Location = new System.Drawing.Point(372, 71);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(133, 52);
            this.btnAnasayfa.TabIndex = 35;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // btnListele
            // 
            this.btnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListele.ImageOptions.Image")));
            this.btnListele.Location = new System.Drawing.Point(17, 80);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(324, 43);
            this.btnListele.TabIndex = 34;
            this.btnListele.Text = "Listele";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(88, 50);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(98, 23);
            this.labelControl5.TabIndex = 33;
            this.labelControl5.Text = "Yeni Fiyat :";
            // 
            // textFiyat
            // 
            this.textFiyat.Location = new System.Drawing.Point(205, 54);
            this.textFiyat.Name = "textFiyat";
            this.textFiyat.Size = new System.Drawing.Size(89, 20);
            this.textFiyat.TabIndex = 32;
            // 
            // labelEbat
            // 
            this.labelEbat.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEbat.Appearance.Options.UseFont = true;
            this.labelEbat.Location = new System.Drawing.Point(17, 16);
            this.labelEbat.Name = "labelEbat";
            this.labelEbat.Size = new System.Drawing.Size(49, 23);
            this.labelEbat.TabIndex = 31;
            this.labelEbat.Text = "Ebat :";
            // 
            // textEbat
            // 
            this.textEbat.Location = new System.Drawing.Point(72, 19);
            this.textEbat.Name = "textEbat";
            this.textEbat.Size = new System.Drawing.Size(127, 20);
            this.textEbat.TabIndex = 30;
            this.textEbat.EditValueChanged += new System.EventHandler(this.textEbat_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(205, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 23);
            this.labelControl1.TabIndex = 39;
            this.labelControl1.Text = "Ürün İD :";
            // 
            // textUrunİd
            // 
            this.textUrunİd.Location = new System.Drawing.Point(291, 19);
            this.textUrunİd.Name = "textUrunİd";
            this.textUrunİd.Size = new System.Drawing.Size(77, 20);
            this.textUrunİd.TabIndex = 38;
            // 
            // LastikGüncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 331);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textUrunİd);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.textFiyat);
            this.Controls.Add(this.labelEbat);
            this.Controls.Add(this.textEbat);
            this.Name = "LastikGüncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LastikGüncelle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEbat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUrunİd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btnAnasayfa;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textFiyat;
        private DevExpress.XtraEditors.LabelControl labelEbat;
        private DevExpress.XtraEditors.TextEdit textEbat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textUrunİd;
    }
}