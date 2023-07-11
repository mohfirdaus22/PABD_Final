using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABD_Final
{
    public partial class Suplier : Form
    {

        //connection sql
        private string stringConnection = "data source=Jorengezzz\\THEPASHTER;" + "database=Restaurant_K1;User ID=sa;password=Salahtompo22";
        private SqlConnection koneksi;

        //Fungtion Refresh
        private void refreshform()
        {
            txtidsupl.Text = "";
            txtnama.Text = "";
            txtnotelp.Text = "";
            txtkotaasal.Text = "";

            btnClear.Enabled = false;
            btnSave.Enabled = false;
            btnOpen.Enabled = false;

        }

        //buat datagrid
        private void dataGridView()
        {
            koneksi.Open();
            string query = "SELECT Id_supl, Nama, Kota_asal, No_telp FROM dbo.Suplier";
            SqlDataAdapter da = new SqlDataAdapter(query, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        public Suplier()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Suplier_Load(object sender, EventArgs e)
        {

        }
    }
}
