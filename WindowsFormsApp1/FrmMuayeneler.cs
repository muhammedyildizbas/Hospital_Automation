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
    public partial class FrmMuayeneler : Form
    {
        public FrmMuayeneler()
        {
            InitializeComponent();
        }

        private void FrmMuayeneler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hospital_AutomationDataSet1.Randevular' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.randevularTableAdapter.Fill(this.hospital_AutomationDataSet1.Randevular);

        }
    }
}
