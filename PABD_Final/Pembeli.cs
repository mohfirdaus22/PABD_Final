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
    public partial class Pembeli : Form
    {

        //connection sql
        private string stringConnection = "data source=Jorengezzz\\THEPASHTER;" + "database=Restaurant_K1;User ID=sa;password=Salahtompo22";
        private SqlConnection koneksi;


        //Button refreshform
        private void refreshform()
        {
            txtidpembeli.Text = "";
            txtnama.Text = "";
            txtnotelp.Text = "";
            txtemail.Text = "";
            txtalamat.Text = "";
           
            btnClear.Enabled = false;
            btnSave.Enabled = false;
            btnOpen.Enabled = false;

        }

        //bikin
        //buat datagrid
        private void dataGridView()
        {
            koneksi.Open();
            string query = "SELECT Id_pembeli, Nama, Alamat, No_telp, Email FROM dbo.Pembeli";
            SqlDataAdapter da = new SqlDataAdapter(query, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }


        public Pembeli()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void Pembeli_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
