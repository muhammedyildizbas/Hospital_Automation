﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmHastaneGiris : Form
    {
        public FrmHastaneGiris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmBilgiIslemGiris frmBilgiIslemGiris = new FrmBilgiIslemGiris();
            frmBilgiIslemGiris.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKullaniciGiris frmKullanici = new FrmKullaniciGiris();
            frmKullanici.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris frmDoktorGiris = new FrmDoktorGiris();
            frmDoktorGiris.Show();
        }
    }
}