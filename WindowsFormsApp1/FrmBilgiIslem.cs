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
    public partial class FrmBilgiIslem : Form
    {
        public FrmBilgiIslem()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-44T2TND;Initial Catalog=Hospital_Automation;Integrated Security=True");
        

        private void button3_Click(object sender, EventArgs e)
        {
            FrmRandevuAlma frmRandevuAlma = new FrmRandevuAlma();
            frmRandevuAlma.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hospital_AutomationDataSet6.Kullanicilar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullanicilarTableAdapter.Fill(this.hospital_AutomationDataSet6.Kullanicilar);
            // TODO: Bu kod satırı 'hospital_AutomationDataSet5.Randevular' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.randevularTableAdapter.Fill(this.hospital_AutomationDataSet5.Randevular);
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmPoliklinikEkle frmPoliklinikEkle = new FrmPoliklinikEkle();
            frmPoliklinikEkle.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmBilgiIslemKayit frmBilgiIslemKayit = new FrmBilgiIslemKayit();
            frmBilgiIslemKayit.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmHastaKayit frmHastaKayit = new FrmHastaKayit();
            frmHastaKayit.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoktorKayit frmDoktorKayit = new FrmDoktorKayit();
            frmDoktorKayit.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from Kullanicilar where Adi like '%" + TxtHstAd.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            TxtHstAd.Clear();
            baglanti.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select *from Kullanicilar where TcNo like '%" + TxtTcNo.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut2);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            TxtTcNo.Clear();
            
            baglanti.Close();
        }
    }
}
//Data Source=DESKTOP-44T2TND;Initial Catalog=Hospital_Automation;Integrated Security=True