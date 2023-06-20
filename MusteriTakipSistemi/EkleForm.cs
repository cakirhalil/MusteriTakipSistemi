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

namespace MusteriTakipSistemi
{
    public partial class EkleForm : Form
    {
        public EkleForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MONSTER-HUMA;Initial Catalog=MusteriTakipSistemi_DB;Integrated Security=True");
       
        private void EkleForm_Load(object sender, EventArgs e)
        {
            

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBL_MusteriList" +
                "(MUSTERINO,AD,SOYAD,TEL,MAIL) values " +
                "(@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtNo.Text);
            komut.Parameters.AddWithValue("@p2", txtAd.Text);
            komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p4", txtTel.Text);
            komut.Parameters.AddWithValue("@p5", txtMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        MusteriListForm fr3;
        private void btnListe_Click(object sender, EventArgs e)
        {
            if (fr3 == null)
            {
                fr3 = new MusteriListForm();
                fr3.Show();

            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtNo.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTel.Text = "";
            txtMail.Text = "";
        }
    }
}
