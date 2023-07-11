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
    public partial class Kasir : Form
    {
        //connection to database
        private string stringConnection = "data source=Jorengezzz\\THEPASHTER;" + "database=Restaurant_K1;User ID=sa;password=Salahtompo22";
        private SqlConnection koneksi;

        //membuat sndiri refresh form
        private void refreshform()
        {
            txtidkasir.Text = "";
            txtnama.Text = "";
            txtnotelp.Text = "";
            txtemail.Text = "";

            btnClear.Enabled = false;
            btnSave.Enabled = false;
            btnOpen.Enabled = false;

        }

        //buat datagrid
        private void dataGridView()
        {
            koneksi.Open();
            string query = "SELECT Id_kasir, Nama, Email, No_telp FROM dbo.Kasir";
            SqlDataAdapter da = new SqlDataAdapter(query, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        public Kasir()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void Kasir_Load(object sender, EventArgs e)
        {

        }

        //button open
        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }

        //button Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtidkasir.Enabled = true;
            txtnama.Enabled = true;
            txtnotelp.Enabled = true;
            txtemail.Enabled = true;
            btnSave.Enabled = true;
            btnOpen.Enabled = true;
            btnClear.Enabled = true;

        }
    }
}
