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
    public partial class FrmDoktorKayit : Form
    {
        public FrmDoktorKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-44T2TND;Initial Catalog=Hospital_Automation;Integrated Security=True");

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komutKaydet = new SqlCommand("insert into Doktorlar (TcNo,Adi,Soyadi,DogumYeri,Cinsiyet,DogumTarihi,BabaAdi,AnneAdi,Telefon,PoliklinikAdi,EPosta) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", baglanti);
                komutKaydet.Parameters.AddWithValue("@p1", TxtTc.Text);
                komutKaydet.Parameters.AddWithValue("@p2", TxtDktrAd.Text);
                komutKaydet.Parameters.AddWithValue("@p3", TxtDktrSoyad.Text);
                komutKaydet.Parameters.AddWithValue("@p4", TxtDgmYeri.Text);
                komutKaydet.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);
                komutKaydet.Parameters.AddWithValue("@p6", dateTimePicker1.Text);
                komutKaydet.Parameters.AddWithValue("@p7", TxtDktrBabaAd.Text);
                komutKaydet.Parameters.AddWithValue("@p8", TxtDktrAnneAd.Text);
                komutKaydet.Parameters.AddWithValue("@p9", TxtDktrTel.Text);
                komutKaydet.Parameters.AddWithValue("@p10", CmbPoliklinikAdi.Text);
                komutKaydet.Parameters.AddWithValue("@p11", TxtDktrEPosta.Text);
                komutKaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Yapıldı");

            }
            catch (Exception)
            {

                MessageBox.Show("Doktor Kaydı Yapılırken Hata");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand guncelle = new SqlCommand("update Doktorlar set Adi=@p2,Soyadi=@p3,DogumYeri=@p4,Cinsiyet=@p5,DogumTarihi=@p6,BabaAdi=@p7,AnneAdi=@p8,Telefon=@p9,PoliklinikAdi=@p10,EPosta=@p11 where TcNo=@p1", baglanti);
                guncelle.Parameters.AddWithValue("@p1", TxtTc.Text);
                guncelle.Parameters.AddWithValue("@p2", TxtDktrAd.Text);
                guncelle.Parameters.AddWithValue("@p3", TxtDktrSoyad.Text);
                guncelle.Parameters.AddWithValue("@p4", TxtDgmYeri.Text);
                guncelle.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);
                guncelle.Parameters.AddWithValue("@p6", dateTimePicker1.Text);
                guncelle.Parameters.AddWithValue("@p7", TxtDktrBabaAd.Text);
                guncelle.Parameters.AddWithValue("@p8", TxtDktrAnneAd.Text);
                guncelle.Parameters.AddWithValue("@p9", TxtDktrTel.Text);
                guncelle.Parameters.AddWithValue("@p10", CmbPoliklinikAdi.Text);
                guncelle.Parameters.AddWithValue("@p11", TxtDktrEPosta.Text);
                guncelle.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Güncelleme Yapıldı");
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme Yapılırken Hata Oluştu");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from Doktorlar where TcNo=@TcNo";
            //tcno parametresine bağlı olarak kullanıcı bilgilerini çeken sql kodu
            SqlCommand komut2 = new SqlCommand(kayit, baglanti);
            komut2.Parameters.AddWithValue("TcNo", TxtTc.Text);
            //tcno parametremize textbox'dan girilen değeri aktarıyoruz
            SqlDataAdapter da = new SqlDataAdapter(komut2);
            SqlDataReader dr = komut2.ExecuteReader();
            if (dr.Read()) //Sadece tek bir kayıt döndürüleceği için while kullanmadım.
            {
                TxtTc.Text = dr["TcNo"].ToString();
                TxtDktrAd.Text = dr["Adi"].ToString();
                TxtDktrSoyad.Text = dr["Soyadi"].ToString();
                TxtDgmYeri.Text = dr["DogumYeri"].ToString();
                CmbCinsiyet.Text = dr["Cinsiyet"].ToString();
                dateTimePicker1.Text = dr["DogumTarihi"].ToString();
                TxtDktrBabaAd.Text = dr["BabaAdi"].ToString();
                TxtDktrAnneAd.Text = dr["AnneAdi"].ToString();
                TxtDktrTel.Text = dr["Telefon"].ToString();
                CmbPoliklinikAdi.Text = dr["PoliklinikAdi"].ToString();
                TxtDktrEPosta.Text = dr["EPosta"].ToString();

                //Datareader ile okunan verileri form kontrollerine aktardık.
            }
            else
                MessageBox.Show("Kayıt Bulunamadı");
            baglanti.Close();
        }
    }
}
