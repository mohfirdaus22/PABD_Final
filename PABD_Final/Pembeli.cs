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
            cbxidkasir.Text = "";
            btnClear.Enabled = false;
            btnSave.Enabled = false;
            btnOpen.Enabled = false;

        }

        //bikin
        private void Kasircbx()
        {
            koneksi.Open();
            string str = "select Id_kasir  from dbo.Kasir";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxidkasir.ValueMember = "Id_kasir";
            cbxidkasir.DataSource = ds.Tables[0];
        }


        public Pembeli()
        {
            InitializeComponent();
        }

        private void Pembeli_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
