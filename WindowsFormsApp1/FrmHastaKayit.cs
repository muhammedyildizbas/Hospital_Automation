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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-44T2TND;Initial Catalog=Hospital_Automation;Integrated Security=True");
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hospital_AutomationDataSet.Kullanicilar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullanicilarTableAdapter.Fill(this.hospital_AutomationDataSet.Kullanicilar);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();
                SqlCommand komutkaydet = new SqlCommand("insert into Kullanicilar (TcNo,Adi,Soyadi,DogumYeri,Cinsiyet,DogumTarihi,BabaAdi,AnneAdi,Telefon,EPosta) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglanti);
                komutkaydet.Parameters.AddWithValue("@p1", TxtTc.Text);
                komutkaydet.Parameters.AddWithValue("@p2", TxtHstAd.Text);
                komutkaydet.Parameters.AddWithValue("@p3", TxtHstSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p4", TxtHstDgmYer.Text);
                komutkaydet.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);
                komutkaydet.Parameters.AddWithValue("@p6", dateTimePicker1.Text);
                komutkaydet.Parameters.AddWithValue("@p7", TxtHstBabaAd.Text);
                komutkaydet.Parameters.AddWithValue("@p8", TxtHstAnneAd.Text);
                komutkaydet.Parameters.AddWithValue("@p9", TxtHstTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p10", TxtHstEPosta.Text);
                komutkaydet.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Kayıt Yapıldı");
            }
            catch (Exception)
            {

                MessageBox.Show("Hasta Kaydı Yapılırken Hata Oluştu");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand guncelle = new SqlCommand("update  Kullanicilar set Adi=@p2,Soyadi=@p3,DogumYeri=@p4,Cinsiyet=@p5,DogumTarihi=@p6,BabaAdi=@p7,AnneAdi=@p8,Telefon=@p9,EPosta=@p10 where TcNo=@p1", baglanti);
                guncelle.Parameters.AddWithValue("@p1", TxtTc.Text);
                guncelle.Parameters.AddWithValue("@p2", TxtHstAd.Text);
                guncelle.Parameters.AddWithValue("@p3", TxtHstSoyad.Text);
                guncelle.Parameters.AddWithValue("@p4", TxtHstDgmYer.Text);
                guncelle.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);
                guncelle.Parameters.AddWithValue("@p6", dateTimePicker1.Text);
                guncelle.Parameters.AddWithValue("@p7", TxtHstBabaAd.Text);
                guncelle.Parameters.AddWithValue("@p8", TxtHstAnneAd.Text);
                guncelle.Parameters.AddWithValue("@p9", TxtHstTelefon.Text);
                guncelle.Parameters.AddWithValue("@p10", TxtHstEPosta.Text);
                guncelle.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Kayıt Yapıldı");
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme Yapılırken Hata Oluştu");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from Kullanicilar where TcNo=@TcNo";
            //tcno parametresine bağlı olarak kullanıcı bilgilerini çeken sql kodu
            SqlCommand komut2 = new SqlCommand(kayit, baglanti);
            komut2.Parameters.AddWithValue("TcNo", TxtTc.Text);
            //tcno parametremize textbox'dan girilen değeri aktarıyoruz
            SqlDataAdapter da = new SqlDataAdapter(komut2);
            SqlDataReader dr = komut2.ExecuteReader();
            if (dr.Read()) //Sadece tek bir kayıt döndürüleceği için while kullanmadım.
            {
                TxtTc.Text = dr["TcNo"].ToString();
                TxtHstAd.Text = dr["Adi"].ToString();
                TxtHstSoyad.Text = dr["Soyadi"].ToString();
                TxtHstDgmYer.Text = dr["DogumYeri"].ToString();
                CmbCinsiyet.Text = dr["Cinsiyet"].ToString();
                dateTimePicker1.Text = dr["DogumTarihi"].ToString();
                TxtHstBabaAd.Text = dr["BabaAdi"].ToString();
                TxtHstAnneAd.Text = dr["AnneAdi"].ToString();
                TxtHstTelefon.Text = dr["Telefon"].ToString();
                TxtHstEPosta.Text = dr["EPosta"].ToString();
              
                //Datareader ile okunan verileri form kontrollerine aktardık.
            }
            else
                MessageBox.Show("Kayıt Bulunamadı");
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand silme = new SqlCommand("delete from Kullanicilar where TcNo=@p1", baglanti);
            silme.Parameters.AddWithValue("@p1", TxtTc.Text);
            silme.ExecuteNonQuery();
            baglanti.Close();
            
            MessageBox.Show("Kayit Silindi");
           
        }
    }
    }
