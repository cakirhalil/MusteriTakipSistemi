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
    public partial class SilForm : Form
    {
        public SilForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MONSTER-HUMA;Initial Catalog=MusteriTakipSistemi_DB;Integrated Security=True");

        private void SilForm_Load(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e) //silme
        {
            DialogResult result1 = MessageBox.Show("Müşteriyi silmek istiyormusunuz.", "Silme İşlemi", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komutsil = new SqlCommand("DELETE FROM TBL_MusteriList WHERE MUSTERINO=@p1",baglanti);
                komutsil.Parameters.AddWithValue("@p1", txtNo.Text);
                komutsil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri sistemden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tBL_MusteriListTableAdapter.Fill(this.musteriTakipSistemi_DBDataSet.TBL_MusteriList);
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
