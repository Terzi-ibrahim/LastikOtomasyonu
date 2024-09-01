
namespace LastikOtomasyonu
{
    partial class LastikSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LastikSil));
            this.labelEbat = new DevExpress.XtraEditors.LabelControl();
            this.textEbat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textStokKodu = new DevExpress.XtraEditors.TextEdit();
            this.btnAnasayfa = new DevExpress.XtraEditors.SimpleButton();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEbat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEbat
            // 
            this.labelEbat.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEbat.Appearance.Options.UseFont = true;
            this.labelEbat.Location = new System.Drawing.Point(12, 25);
            this.labelEbat.Name = "labelEbat";
            this.labelEbat.Size = new System.Drawing.Size(49, 23);
            this.labelEbat.TabIndex = 20;
            this.labelEbat.Text = "Ebat :";
            // 
            // textEbat
            // 
            this.textEbat.Location = new System.Drawing.Point(76, 29);
            this.textEbat.Name = "textEbat";
            this.textEbat.Size = new System.Drawing.Size(127, 20);
            this.textEbat.TabIndex = 19;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 81);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(106, 23);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "Stok Kodu  :";
            // 
            // textStokKodu
            // 
            this.textStokKodu.Location = new System.Drawing.Point(124, 85);
            this.textStokKodu.Name = "textStokKodu";
            this.textStokKodu.Size = new System.Drawing.Size(89, 20);
            this.textStokKodu.TabIndex = 24;
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnasayfa.ImageOptions.Image")));
            this.btnAnasayfa.Location = new System.Drawing.Point(240, 74);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(269, 52);
            this.btnAnasayfa.TabIndex = 27;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // btnListele
            // 
            this.btnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListele.ImageOptions.Image")));
            this.btnListele.Location = new System.Drawing.Point(12, 138);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(497, 43);
            this.btnListele.TabIndex = 26;
            this.btnListele.Text = "Listele";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(497, 187);
            this.dataGridView1.TabIndex = 28;
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(240, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(269, 48);
            this.btnSil.TabIndex = 29;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // LastikSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 386);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.textStokKodu);
            this.Controls.Add(this.labelEbat);
            this.Controls.Add(this.textEbat);
            this.Name = "LastikSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LastikSil";
            ((System.ComponentModel.ISupportInitialize)(this.textEbat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textStokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelEbat;
        private DevExpress.XtraEditors.TextEdit textEbat;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textStokKodu;
        private DevExpress.XtraEditors.SimpleButton btnAnasayfa;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btnSil;
    }
}