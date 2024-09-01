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
    public partial class Muhasebe : Form
    {
        public Muhasebe()
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

            SqlCommand komut = new SqlCommand("select Lastik_Ebati as [Lastik Ebatı],Lastik_Markasi as [Lastik Markası],Lastik_Yili as [Lastik Yılı],Giris_Fiyati as [Giriş Fiyatı],Stok as [Stok] from Lastik ", bag);

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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (bag.State == ConnectionState.Broken || bag.State == ConnectionState.Closed)
            {
                bag.Open();

            }

            SqlCommand komut = new SqlCommand("select Sum (Giris_Fiyati) from Lastik ", bag);
            object result = komut.ExecuteScalar(); // Sorgunun sonucunu al

            if (result != null)
            {
               
                label1.Text = $"Toplam Ürün Fiyatı: {result.ToString()}";
            }


        }
    }
}
