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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idkasir = txtidkasir.Text;
            string nama = txtnama.Text;
            string email = txtemail.Text;
            string notelp = txtnotelp.Text;

            if (idkasir == "")
            {
                MessageBox.Show("Masukkan Id Kasir", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (nama == "")
            {
                MessageBox.Show("Masukkan Nama", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (notelp == "")
            {
                MessageBox.Show("Masukkan No Telp", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (email == "")
            {
                MessageBox.Show("Masukkan Email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "INSERT INTO Kasir (Id_kasir, Nama, Email,No_telp) VALUES (@id_kasir, @nama, @email, @No_telp)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@Id_koki", idkasir));
                cmd.Parameters.Add(new SqlParameter("@Alamat", email));
                cmd.Parameters.Add(new SqlParameter("@No_telp", notelp));
                cmd.Parameters.Add(new SqlParameter("@Nama", nama));

                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }
    }
}
