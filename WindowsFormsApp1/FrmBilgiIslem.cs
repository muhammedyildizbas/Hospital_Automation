using System;
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
    public partial class FrmBilgiIslem : Form
    {
        public FrmBilgiIslem()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmRandevuAlma frmRandevuAlma = new FrmRandevuAlma();
            frmRandevuAlma.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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
    }
}
