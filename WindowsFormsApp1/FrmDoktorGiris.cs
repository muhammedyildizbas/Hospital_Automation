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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-44T2TND;Initial Catalog=Hospital_Automation;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Doktorlar where TcNo=@p1 and Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtTcNo.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                FrmDoktor frm = new FrmDoktor();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veye Şifre Hatalı");
                TxtTcNo.Clear();
                TxtSifre.Clear();
                TxtTcNo.Focus();
            }
            baglanti.Close();
        }
    }
}
