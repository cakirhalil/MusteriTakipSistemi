using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriTakipSistemi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        MusteriListForm fr1;
        private void btnMusteriListesi_Click(object sender, EventArgs e)
        {

            if (fr1 == null)
            {
                fr1 = new MusteriListForm();                
                fr1.Show();
                
            }
        }

        EkleForm fr2;
        private void btnEkleme_Click(object sender, EventArgs e)
        {
            if (fr2 == null)
            {
                fr2 = new EkleForm();
                fr2.Show();

            }
        }

        SilForm fr4;
        private void btnSilme_Click(object sender, EventArgs e)
        {
            if (fr4 == null)
            {
                fr4 = new SilForm();
                fr4.Show();

            }
        }

        GuncelleForm fr5;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (fr5 == null)
            {
                fr5 = new GuncelleForm();
                fr5.Show();
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }
    }
}

