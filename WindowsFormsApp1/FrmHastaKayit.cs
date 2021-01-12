﻿using System;
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

        }
    }
}
