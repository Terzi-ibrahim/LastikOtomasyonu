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
    public partial class LastikEkle : Form
    {
        public SqlConnection bag = new SqlConnection("Data source =DESKTOP-MIV518C; initial catalog=Lastikci; integrated security=true");
        public LastikEkle()
        {
            InitializeComponent();
        }
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
        void Temizle()
        {

            textEbat.Clear();
           
            textYıl.Clear();
           
            textFiyat.Clear();
            textStok.Clear();

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
            try
           {
                if (textEbat.Text == "" || comboMarka.SelectedItem == null || textYıl.Text == "" || textFiyat.Text == "" || textStok.Text=="")
                {

                    MessageBox.Show("Hiçbir değer boş geçilemez ! ");


                }
                else
                {
                    SqlCommand kmt = new SqlCommand();
                    kmt.CommandText = "insert into Lastik (Lastik_Ebati,Lastik_Markasi,Lastik_Yili,Giris_Fiyati,Mevsim,Arac_Tipi,Stok) values (@Lastik_Ebati,@Lastik_Markasi,@Lastik_Yili,@Giris_Fiyati,@Mevsim,@Arac_Tipi,@Stok)";
                    kmt.Connection = bag;
                    kmt.CommandType = CommandType.Text;
                    kmt.Parameters.Add("@Lastik_Ebati", SqlDbType.NVarChar).Value = textEbat.Text;
                    kmt.Parameters.Add("@Lastik_Markasi", SqlDbType.NVarChar).Value = comboMarka.SelectedItem;
                    kmt.Parameters.Add("@Lastik_Yili", SqlDbType.NVarChar).Value = textYıl.Text;
                    kmt.Parameters.Add("@Mevsim", SqlDbType.NVarChar).Value = comboMevsim.SelectedItem;
                    kmt.Parameters.Add("@Arac_Tipi", SqlDbType.NVarChar).Value = comboTip.SelectedItem;
                    kmt.Parameters.Add("@Giris_Fiyati", SqlDbType.Int).Value = textFiyat.Text;  
                    kmt.Parameters.Add("@Stok", SqlDbType.NVarChar).Value = textStok.Text;



                    kmt.ExecuteNonQuery();
                    MessageBox.Show("Ürün Kaydı başarılı");
                    Temizle();
                    bag.Close();
                }
            }
            catch
            {

                MessageBox.Show("Bu Ürün Kayıtlı");

            }
        }
    }
}
