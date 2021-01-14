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
    public partial class FrmRandevuSilme : Form
    {
        public FrmRandevuSilme()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hospital_AutomationDataSet7.Randevular' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.randevularTableAdapter.Fill(this.hospital_AutomationDataSet7.Randevular);

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-44T2TND;Initial Catalog=Hospital_Automation;Integrated Security=True");

        private void button8_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from Randevular where TcNo like '%" + TxtTcNo.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand silme = new SqlCommand("delete from Randevular where RandevuId=@p1", baglanti);
            silme.Parameters.AddWithValue("@p1", TxtRandevuId.Text);
            silme.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Randevu Silindi");
        }
    }
}
