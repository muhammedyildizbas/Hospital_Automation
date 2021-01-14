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
    public partial class FrmDoktor : Form
    {
        public FrmDoktor()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-44T2TND;Initial Catalog=Hospital_Automation;Integrated Security=True");

        private void FrmDoktor_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hospital_AutomationDataSet2.Randevular' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.randevularTableAdapter.Fill(this.hospital_AutomationDataSet2.Randevular);

        }

        private void button38_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from Randevular where DoktorId like '%" + CmbDoktorNo.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            string kayit = "SELECT * from Doktorlar where DoktorId=@DoktorId";
            SqlCommand komut2 = new SqlCommand(kayit, baglanti);
            komut2.Parameters.AddWithValue("DoktorId", CmbDoktorNo.Text);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            SqlDataReader dr = komut2.ExecuteReader();
            if (dr.Read())
            {
                lblPolAd.Text = dr["PoliklinikAdi"].ToString();
                lblDoktorAd.Text = dr["Adi"].ToString() + " "+ dr["Soyadi"].ToString();
            }
            else
                MessageBox.Show("Kayıt Bulunamadı");
           
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMuayeneler frmMuayeneler = new FrmMuayeneler();
            frmMuayeneler.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmIlacVerme frmIlacVerme = new FrmIlacVerme();
            frmIlacVerme.Show();
        }
    }
}
