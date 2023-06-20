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
    public partial class MusteriListForm : Form
    {
        public MusteriListForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MONSTER-HUMA;Initial Catalog=MusteriTakipSistemi_DB;Integrated Security=True");
        

     

        private void MusteriListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musteriTakipSistemi_DBDataSet.TBL_MusteriList' table. You can move, or remove it, as needed.
            this.tBL_MusteriListTableAdapter.Fill(this.musteriTakipSistemi_DBDataSet.TBL_MusteriList);
        }
    }
}
