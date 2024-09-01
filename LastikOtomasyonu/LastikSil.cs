using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LastikOtomasyonu
{
    public partial class LastikSil : Form
    {
        public LastikSil()
        {
            InitializeComponent();
        }
        public SqlConnection bag = new SqlConnection("Data source =DESKTOP-MIV518C; initial catalog=Lastikci; integrated security=true");
        void GridDoldur()
        {

            if (bag.State == ConnectionState.Broken || bag.State == ConnectionState.Closed)
            {
                bag.Open();

            }

            SqlCommand komut = new SqlCommand("select Stok_Kod as [Stok Kodu], Lastik_Ebati as [Lastik Ebatı],Lastik_Markasi as [Lastik Markası],Lastik_Yili as [Lastik Yılı],Giris_Fiyati as [Giriş Fiyatı],Mevsim as [Mevsim],Arac_Tipi as [Araç Tipi],Stok as [Stok] from Lastik ", bag);

            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa GitAna = new Anasayfa();
            GitAna.Show();
            this.Hide();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (bag.State == ConnectionState.Broken || bag.State == ConnectionState.Closed)
            {

                bag.Open();

            }
            SqlCommand komut = new SqlCommand("delete from Lastik where Lastik_Ebati= '" + textEbat.Text + "'and Stok_Kod ='"+textStokKodu+"' ", bag);
            DialogResult sonuc;
            sonuc = MessageBox.Show(textEbat.Text + "Numaralı Üyeyi Silmek İstiyormusunuz ? ", "Silme İşlemi uyar", MessageBoxButtons.YesNo);

            if (sonuc == DialogResult.Yes)
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Silme İşleminiz Başarılı", "Uyarı");
                GridDoldur();
                textEbat.Clear();

            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "Uyarı");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (bag.State == ConnectionState.Broken || bag.State == ConnectionState.Closed)
            {

                bag.Open();

            }
            SqlCommand komut = new SqlCommand("delete from Lastik where Lastik_Ebati = '" + textEbat.Text + "'or Stok_Kod= '" + textStokKodu.Text + "'", bag);
            DialogResult sonuc;
            sonuc = MessageBox.Show(textEbat.Text + "Numaralı Üyeyi Silmek İstiyormusunuz ? ", "Silme İşlemi uyar", MessageBoxButtons.YesNo);

            if (sonuc == DialogResult.Yes)
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Silme İşleminiz Başarılı", "Uyarı");
                GridDoldur();
                textEbat.Clear();
                textStokKodu.Clear();

            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "Uyarı");
            }

        }
    }
}
