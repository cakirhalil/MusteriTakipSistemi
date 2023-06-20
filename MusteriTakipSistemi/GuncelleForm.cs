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
    public partial class GuncelleForm : Form
    {
        public GuncelleForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MONSTER-HUMA;Initial Catalog=MusteriTakipSistemi_DB;Integrated Security=True");
        
        private void GuncelleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musteriTakipSistemi_DBDataSet.TBL_MusteriList' table. You can move, or remove it, as needed.
            this.tBL_MusteriListTableAdapter.Fill(this.musteriTakipSistemi_DBDataSet.TBL_MusteriList);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            txtNo.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            txtTel.Text = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            txtMail.Text = dataGridView1.Rows[sec].Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e) //güncelleme
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("update TBL_MusteriList set " +
                "AD=@P1,SOYAD=@P2,TEL=@P3,MAIL=@P4 where MUSTERINO=@P5",baglanti);
            komutguncelle.Parameters.AddWithValue("@p1", txtAd.Text);
            komutguncelle.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@p3", txtTel.Text);
            komutguncelle.Parameters.AddWithValue("@p4", txtMail.Text);
            komutguncelle.Parameters.AddWithValue("@p5", txtNo.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri sistemde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.tBL_MusteriListTableAdapter.Fill(this.musteriTakipSistemi_DBDataSet.TBL_MusteriList);
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
