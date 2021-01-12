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
    }
}
