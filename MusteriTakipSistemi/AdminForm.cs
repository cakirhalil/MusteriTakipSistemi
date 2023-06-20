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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=MONSTER-HUMA;Initial Catalog=MusteriTakipSistemi_DB;Integrated Security=True");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBL_Admin WHERE KULLANICI=@p1 AND SIFRE=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1", txtKullanici.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                AnaForm fr = new AnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ya da şifre", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            baglanti.Close();
        }
    }
}
