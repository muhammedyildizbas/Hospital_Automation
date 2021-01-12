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
    public partial class FrmPoliklinikEkle : Form
    {
        public FrmPoliklinikEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-44T2TND;Initial Catalog=Hospital_Automation;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                baglanti.Open();
                SqlCommand komutKaydet = new SqlCommand("insert into Poliklinikler (PoliklinikAdi) values (@p1)", baglanti);
                komutKaydet.Parameters.AddWithValue("@p1", TxtPoliklinik.Text);
                komutKaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Yapıldı");
            }
            catch (Exception)
            {

                MessageBox.Show("Poliklinik Kaydı Yapılırken Hata Oluştu");
            }
        }

        private void FrmPoliklinikEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
