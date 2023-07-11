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
    public partial class MenuResto : Form
    {
        //connection to database
        private string stringConnection = "data source=Jorengezzz\\THEPASHTER;" + "database=Restaurant_K1;User ID=sa;password=Salahtompo22";
        private SqlConnection koneksi;

        //membuat sndiri refresh form
        private void refreshform()
        {
            txtkodemenu.Text = "";
            txtnama.Text = "";
            txtstok.Text = "";
            txtharga.Text = "";

            btnClear.Enabled = false;
            btnSave.Enabled = false;
            btnOpen.Enabled = false;

        }

        //buat datagrid
        private void dataGridView()
        {
            koneksi.Open();
            string query = "SELECT Kode_menu, Nama, Stok, Harga FROM dbo.Menu";
            SqlDataAdapter da = new SqlDataAdapter(query, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        public MenuResto()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void MenuResto_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtkodemenu.Enabled = true;
            txtnama.Enabled = true;
            txtstok.Enabled = true;
            txtharga.Enabled = true;
            btnSave.Enabled = true;
            btnOpen.Enabled = true;
            btnClear.Enabled = true;

        }
    }
}
