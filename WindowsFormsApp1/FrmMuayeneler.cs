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
    public partial class FrmMuayeneler : Form
    {
        public FrmMuayeneler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-44T2TND;Initial Catalog=Hospital_Automation;Integrated Security=True");
        private void FrmMuayeneler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hospital_AutomationDataSet1.Randevular' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.randevularTableAdapter.Fill(this.hospital_AutomationDataSet1.Randevular);

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
                
              //Datareader ile okunan verileri form kontrollerine aktardık.
            }
            else
                MessageBox.Show("Kayıt Bulunamadı");
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komutkaydet = new SqlCommand("insert into Muayeneler (DoktorId,TcNo,HastaAdi,HastaSoyadi,IlacAdi,IlacKod,Aciklama) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                komutkaydet.Parameters.AddWithValue("@p1", CmbDoktorId.Text);
                komutkaydet.Parameters.AddWithValue("@p2", TxtTc.Text);
                komutkaydet.Parameters.AddWithValue("@p3", TxtHstAd.Text);
                komutkaydet.Parameters.AddWithValue("@p4", TxtHstSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p5", TxtIlacAdi.Text);
                komutkaydet.Parameters.AddWithValue("@p6", TxtIlacKod.Text);
                komutkaydet.Parameters.AddWithValue("@p7", richTextBox1.Text);
               
                komutkaydet.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show(" Muayene Kaydı Yapıldı");
            }
            catch (Exception)
            {

                MessageBox.Show("Muayene Kaydı Yapılırken Hata Oluştu");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit3 = "SELECT * from Ilaclar where IlacKod=@IlacKod";
            // parametresine bağlı olarak kullanıcı bilgilerini çeken sql kodu
            SqlCommand komut4 = new SqlCommand(kayit3, baglanti);
            komut4.Parameters.AddWithValue("IlacKod", TxtIlacKod.Text);
            // parametremize textbox'dan girilen değeri aktarıyoruz
            SqlDataAdapter da = new SqlDataAdapter(komut4);
            SqlDataReader dr = komut4.ExecuteReader();
            if (dr.Read()) //Sadece tek bir kayıt döndürüleceği için while kullanmadım.
            {
                TxtIlacKod.Text = dr["IlacKod"].ToString();
                TxtIlacAdi.Text = dr["IlacAdi"].ToString();
              

                //Datareader ile okunan verileri form kontrollerine aktardık.
            }
            else
                MessageBox.Show("Kayıt Bulunamadı");
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit4 = "SELECT * from Ilaclar where IlacAdi=@IlacAdi";
            // parametresine bağlı olarak kullanıcı bilgilerini çeken sql kodu
            SqlCommand komut5 = new SqlCommand(kayit4, baglanti);
            komut5.Parameters.AddWithValue("IlacAdi", TxtIlacAdi.Text);
            // parametremize textbox'dan girilen değeri aktarıyoruz
            SqlDataAdapter da = new SqlDataAdapter(komut5);
            SqlDataReader dr = komut5.ExecuteReader();
            if (dr.Read()) //Sadece tek bir kayıt döndürüleceği için while kullanmadım.
            {
                TxtIlacKod.Text = dr["IlacKod"].ToString();
                TxtIlacAdi.Text = dr["IlacAdi"].ToString();


                //Datareader ile okunan verileri form kontrollerine aktardık.
            }
            else
                MessageBox.Show("Kayıt Bulunamadı");
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
