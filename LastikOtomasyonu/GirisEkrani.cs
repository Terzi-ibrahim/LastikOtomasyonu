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
    public partial class GirisEkrani : Form
    {
        public SqlConnection giris = new SqlConnection("Data source =DESKTOP-MIV518C; initial catalog=Lastikci; integrated security=true");
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            giris.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select *from kullgiris where kulanici_adi ='" + txtkullaniciadi.Text + "'and sifre='" + txtsifre.Text + "'";
            komut.Connection = giris;
            komut.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = komut;
            DataTable dt = new DataTable();
            adap.Fill(dt);
            giris.Close();
            if (dt.Rows.Count > 0)
            {
                
                Anasayfa  git_AnaSayfa = new Anasayfa();
                git_AnaSayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı  Adınız ve Şifreniz yanlıştır.");
                txtkullaniciadi.Clear();
                txtsifre.Clear();
                txtkullaniciadi.Focus();
            }

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
