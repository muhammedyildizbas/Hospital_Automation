using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class FrmRandevuAlma : Form
    {
        public FrmRandevuAlma()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-44T2TND;Initial Catalog=Hospital_Automation;Integrated Security=True");

        public int pol_id;
        public int dr_id;

        public void pol_oku()
        {
            baglanti.Open();
            comboBox1.Items.Clear();
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand komut = new SqlCommand("Select PoliklinikId,PoliklinikAdi from Poliklinikler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku.GetSqlString(1));
                pol_id = oku.GetInt32(0);
            }
            baglanti.Close();
        }
        public void bossaat_oku()
        {
            try
            {

                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlCommand veri = new SqlCommand("SELECT RandevuSaati FROM Randevular where DoktorId " + dr_id + "and RandevuTarihi='" + dateTimePicker1 .Text + "'", baglanti);
                SqlDataReader oku = null;
                oku = veri.ExecuteReader();
                liste .Items.Clear();
                while (oku.Read())
                {
                    liste .Items.Add(oku.GetString(0).ToString());
                }
                veri.ExecuteNonQuery();
                oku.Close();
                baglanti.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Bossati Oku da sorun çıktı");
            }
        }
        public string deger;
        //................
        public void listele()
        {
            try
            {
                button1.Enabled = true; button2.Enabled = true; button3.Enabled = true; button4.Enabled = true; button5.Enabled = true; button6.Enabled = true; button7.Enabled = true; button8.Enabled = true; button9.Enabled = true; button10.Enabled = true; button11.Enabled = true; button12.Enabled = true; button13.Enabled = true; button14.Enabled = true; button15.Enabled = true; button16.Enabled = true; button17.Enabled = true; button18.Enabled = true; button19.Enabled = true; button21.Enabled = true; button22.Enabled = true; button23.Enabled = true; button24.Enabled = true; button25.Enabled = true; button26.Enabled = true; button27.Enabled = true; button28.Enabled = true; button29.Enabled = true; button30.Enabled = true; button31.Enabled = true; button32.Enabled = true; button33.Enabled = true; button34.Enabled = true; button35.Enabled = true; button36.Enabled = true;

                button1.BackColor = Color.LimeGreen; button2.BackColor = Color.LimeGreen; button3.BackColor = Color.LimeGreen; button4.BackColor = Color.LimeGreen; button5.BackColor = Color.LimeGreen; button6.BackColor = Color.LimeGreen; button7.BackColor = Color.LimeGreen; button8.BackColor = Color.LimeGreen; button9.BackColor = Color.LimeGreen; button10.BackColor = Color.LimeGreen; button11.BackColor = Color.LimeGreen; button12.BackColor = Color.LimeGreen; button13.BackColor = Color.LimeGreen; button14.BackColor = Color.LimeGreen; button15.BackColor = Color.LimeGreen; button16.BackColor = Color.LimeGreen; button17.BackColor = Color.LimeGreen; button18.BackColor = Color.LimeGreen; button19.BackColor = Color.LimeGreen; button20.BackColor = Color.LimeGreen;
                button21.BackColor = Color.LimeGreen; button22.BackColor = Color.LimeGreen; button23.BackColor = Color.LimeGreen; button24.BackColor = Color.LimeGreen; button25.BackColor = Color.LimeGreen; button26.BackColor = Color.LimeGreen; button27.BackColor = Color.LimeGreen; button28.BackColor = Color.LimeGreen;
                button29.BackColor = Color.LimeGreen; button30.BackColor = Color.LimeGreen; button31.BackColor = Color.LimeGreen; button32.BackColor = Color.LimeGreen; button33.BackColor = Color.LimeGreen; button34.BackColor = Color.LimeGreen; button35.BackColor = Color.LimeGreen; button36.BackColor = Color.LimeGreen;


                liste.Items.Clear();
                bossaat_oku();
                int sayac = liste.Items.Count;
                string deger = null;
                for (int i = 0; i < sayac; i++)
                {

                    if (liste.Items[i].ToString() == button1.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button1.BackColor = Color.DimGray;
                        button1.Enabled = false;

                    }

                    else if (liste.Items[i].ToString() == button2.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button2.BackColor = Color.DimGray;
                        button2.Enabled = false;

                    }

                    else if (liste.Items[i].ToString() == button3.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button3.BackColor = Color.DimGray;
                        button3.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button4.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button4.BackColor = Color.DimGray;
                        button4.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button5.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button5.BackColor = Color.DimGray;
                        button5.Enabled = false;
                    }
                    else if (liste.Items[i].ToString() == button6.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button6.BackColor = Color.DimGray;
                        button6.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button7.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button7.BackColor = Color.DimGray;
                        button7.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button8.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button8.BackColor = Color.DimGray;
                        button8.Enabled = false;
                    }
                    else if (liste.Items[i].ToString() == button9.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button9.BackColor = Color.DimGray;
                        button9.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button10.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button10.BackColor = Color.DimGray;
                        button10.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button11.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button11.BackColor = Color.DimGray;
                        button11.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button12.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button12.BackColor = Color.DimGray;
                        button12.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button13.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button13.BackColor = Color.DimGray;
                        button13.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button14.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button14.BackColor = Color.DimGray;
                        button14.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button15.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button15.BackColor = Color.DimGray;
                        button15.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button16.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button16.BackColor = Color.DimGray;
                        button16.Enabled = false;


                    }
                    else if (liste.Items[i].ToString() == button17.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button17.BackColor = Color.DimGray;
                        button17.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button18.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button18.BackColor = Color.DimGray;
                        button18.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button19.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button19.BackColor = Color.DimGray;
                        button19.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button20.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button20.BackColor = Color.DimGray;
                        button20.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button21.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button21.BackColor = Color.DimGray;
                        button21.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button22.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button22.BackColor = Color.DimGray;
                        button22.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button23.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button23.BackColor = Color.DimGray;
                        button23.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button24.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button24.BackColor = Color.DimGray;
                        button24.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button25.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button25.BackColor = Color.DimGray;
                        button25.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button26.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button26.BackColor = Color.DimGray;
                        button26.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button27.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button27.BackColor = Color.DimGray;
                        button27.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button28.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button28.BackColor = Color.DimGray;
                        button28.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button29.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button29.BackColor = Color.DimGray;
                        button29.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button30.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button30.BackColor = Color.DimGray;
                        button30.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button31.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button31.BackColor = Color.DimGray;
                        button31.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button32.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button32.BackColor = Color.DimGray;
                        button32.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button33.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button33.BackColor = Color.DimGray;
                        button33.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button34.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button34.BackColor = Color.DimGray;
                        button34.Enabled = false;

                    }
                    else if (liste.Items[i].ToString() == button35.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button35.BackColor = Color.DimGray;
                        button35.Enabled = false;
                    }
                    else if (liste.Items[i].ToString() == button36.Text)
                    {
                        deger = liste.Items[i].ToString();
                        button36.BackColor = Color.DimGray;
                        button36.Enabled = false;

                    }
                }

                bossaat_oku();

            }
            catch (Exception)
            {

                MessageBox.Show("Listele Fonksiyonunda hata");
            }
        } 




       

        private void Form5_Load(object sender, EventArgs e)
        {
            pol_oku();
        }



        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand komut = new SqlCommand("Select PoliklinikId from Poliklinikler where PoliklinikAdi = '" + comboBox1.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                pol_id = oku.GetInt32(0);

            }
            baglanti.Close();
            //....................
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Adi,Soyadi,DoktorId from Doktorlar where PoliklinikId =" + pol_id + "", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            comboBox2.Items.Clear();

            while (oku2.Read())
            {
                comboBox2.Items.Add(oku2.GetString(0) + " " + oku2.GetString(1));

            }
            baglanti.Close();
        }


        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand komut = new SqlCommand("Select DoktorId from Doktorlar where Adi + ' ' + Soyadi = '" + comboBox2.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                dr_id = oku.GetInt32(0);
            }
            baglanti.Close();
            listele();
        }


        private void button38_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button1.Text;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button2.Text;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button3.Text;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button4.Text;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button5.Text;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button6.Text;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button12.Text;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button11.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = button9.Text;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button10.Text;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button8.Text;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button7.Text;
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button18.Text;
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button17.Text;
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button16.Text;
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button15.Text;
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button14.Text;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button13.Text;
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button24.Text;
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button23.Text;
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button22.Text;
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button21.Text;
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button20.Text;
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button19.Text;
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button30.Text;
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button29.Text;
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button28.Text;
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button27.Text;
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button26.Text;
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button25.Text;
        }

        private void button36_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button36.Text;
        }

        private void button35_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button35.Text;
        }

        private void button34_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button34.Text;
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button33.Text;
        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button32.Text;
        }

        private void button31_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = button31.Text;
        }


        private void button39_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Hiçbir Alanın Boş Olmadığından Emin Olduktan Sonra Tekrar Deneyiniz...", " ", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                DateTime geciciTarih = Convert.ToDateTime(dateTimePicker1.Text);
                string gun = string.Empty;

                gun = geciciTarih.ToString("dddd");
                if (gun != "Cumartesi" && gun != "Pazar")
                {
                    listele();
                    string hasta_tc;
                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                    SqlCommand veri = new SqlCommand("SELECT  TcNo FROM Kullanicilar WHERE TcNo = '" + textBox1.Text + "'", baglanti);
                    hasta_tc = veri.ExecuteScalar().ToString();
                    baglanti.Close();

                    if (hasta_tc != textBox1.Text)
                    {
                        MessageBox.Show("Böyle bir Hasta Kaydı Yoktur.Hasta Kaydı Yapıp Tekrar Deneyiniz...");
                    }
                    else
                    {
                        int pol;
                        if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                        SqlCommand veri2 = new SqlCommand("SELECT Pol_id FROM Randevular WHERE TcNo = '" + textBox1.Text + "'", baglanti);

                        SqlDataReader oku2 = null;
                        oku2 = veri2.ExecuteReader();

                        while (oku2.Read())
                        {
                            listBox1.Items.Add(oku2.GetInt32(0));
                        }
                        oku2.Close();
                        baglanti.Close();



                        bossaat_oku();
                        int sayac = listBox1.Items.Count;

                        for (int i = 0; i < sayac; i++)
                        {

                            if (listBox1.Items[i].ToString() == pol_id.ToString())
                            {
                                deger = listBox1.Items[i].ToString();

                            }

                        }
                        if (deger == pol_id.ToString())
                        {

                            MessageBox.Show("Bu Polikliniğe Zaten Hasta Kaydı Yapılmıştır...");
                            this.Close();

                            listBox1.Items.Clear();


                        }
                        else
                        {
                            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                            SqlCommand kaydet = new SqlCommand("insert into Randevular (DoktorId,RandevuTarihi,TcNo,RandevuSaati,Pol_id) values(" + dr_id + ",'" + dateTimePicker1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + pol_id + "')", baglanti);
                            kaydet.ExecuteNonQuery();
                            MessageBox.Show("Randevu Başarılı Bir Şekilde Eklendi...", "Hastane Randevu Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            baglanti.Close();
                            bossaat_oku();
                            listele();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Cumartesi veya Pazar Günü Randevu Alamazsınız...");
                }
                bossaat_oku();
            }
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            try
            {


                DateTime geciciTarih = Convert.ToDateTime(dateTimePicker1.Text);

                string gun = string.Empty;

                gun = geciciTarih.ToString("dddd");
                if (gun != "Cumartesi" && gun != "Pazar")
                {
                    listele();

                }
                else
                {
                    MessageBox.Show("Cumartesi veya Pazar Günü Randevu Alamazsınız...");


                }

            }
            catch
            {

                MessageBox.Show("Date Time Picker Value Changed hata");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
