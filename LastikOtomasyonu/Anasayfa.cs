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
    public partial class Anasayfa : Form
    {
       

        public Anasayfa()
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
            dataGridListele.DataSource = dt;


        }

        private void btnlastikekle_Click(object sender, EventArgs e)
        {
            LastikEkle  git = new LastikEkle ();
            git.Show();
            this.Hide();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            GirisEkrani git = new GirisEkrani();
            git.Show();
            this.Hide();
            
        }

        private void btnLastiksil_Click(object sender, EventArgs e)
        {
            LastikSil  git = new LastikSil();
            git.Show();
            this.Hide();
        }

        private void btnFiyatGuncelle_Click(object sender, EventArgs e)
        {
            LastikGüncelle git = new LastikGüncelle();
            git.Show();
            this.Hide();
        }

        private void btnMuhasebe_Click(object sender, EventArgs e)
        {
            Muhasebe git = new Muhasebe();
            git.Show();
            this.Hide();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (bag.State == ConnectionState.Broken || bag.State == ConnectionState.Broken)
            {
                bag.Open();
            }
            SqlCommand kmut = new SqlCommand("select * from Lastik where Lastik_Ebati='" + textEbat.Text + "'or Lastik_Markasi ='"+comboBoxMarka.SelectedItem+"' ", bag);
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = kmut; //  yukarı sadece select komutu varsa komutta yazılır.
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridListele.DataSource = dt;
        }

        private void textEbat_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void dataGridListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
