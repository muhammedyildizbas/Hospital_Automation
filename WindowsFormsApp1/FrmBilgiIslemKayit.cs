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

namespace WindowsFormsApp1
{
    public partial class FrmBilgiIslemKayit : Form
    {
        public FrmBilgiIslemKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-44T2TND;Initial Catalog=Hospital_Automation;Integrated Security=True");

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FrmBilgiIslemKayit_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komutKaydet = new SqlCommand("insert into BilgiIslem (TcNo,Adi,Soyadi,Telefon,EPosta,Sifre,Cinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                komutKaydet.Parameters.AddWithValue("@p1", TxtTc.Text);
                komutKaydet.Parameters.AddWithValue("@p2", TxtBlgIslemAd.Text);
                komutKaydet.Parameters.AddWithValue("@p3", TxtBlgIslemSoyad.Text);
                komutKaydet.Parameters.AddWithValue("@p4", TxtBlgIslemTel.Text);
                komutKaydet.Parameters.AddWithValue("@p5", TxtBlgIslemEPosta.Text);
                komutKaydet.Parameters.AddWithValue("@p6", TxtBlgIslemSifre.Text);
                komutKaydet.Parameters.AddWithValue("@p7", CmbCinsiyet.Text);
                komutKaydet.ExecuteNonQuery();
                MessageBox.Show("Kayıt Yapıldı");
            }
            catch (Exception)
            {

                MessageBox.Show("Bilgi İşlem Kaydı Yapılırken Hata");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from BilgiIslem where TcNo=@TcNo";
            //tcno parametresine bağlı olarak kullanıcı bilgilerini çeken sql kodu
            SqlCommand komut2 = new SqlCommand(kayit, baglanti);
            komut2.Parameters.AddWithValue("TcNo", TxtTc.Text);
            //tcno parametremize textbox'dan girilen değeri aktarıyoruz
            SqlDataAdapter da = new SqlDataAdapter(komut2);
            SqlDataReader dr = komut2.ExecuteReader();
            if (dr.Read()) //Sadece tek bir kayıt döndürüleceği için while kullanmadım.
            {
               TxtTc.Text = dr["TcNo"].ToString();
               TxtBlgIslemAd.Text = dr["Adi"].ToString();
               TxtBlgIslemSoyad.Text = dr["Soyadi"].ToString();
               TxtBlgIslemTel.Text = dr["Telefon"].ToString();
                TxtBlgIslemEPosta.Text = dr["EPosta"].ToString();
                TxtBlgIslemSifre.Text = dr["Sifre"].ToString();
                CmbCinsiyet.Text = dr["Cinsiyet"].ToString();
                
                //Datareader ile okunan verileri form kontrollerine aktardık.
            }
            else
                MessageBox.Show("Kayıt Bulunamadı");
            baglanti.Close();
        }
    }
}
