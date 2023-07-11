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
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Suplier_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idsupl = txtidsupl.Text;
            string nama = txtnama.Text;
            string notelp = txtnotelp.Text;
            string kotaasal = txtkotaasal.Text;

            if (idsupl == "")
            {
                MessageBox.Show("Masukkan Id Suplier", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (nama == "")
            {
                MessageBox.Show("Masukkan Nama", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (notelp == "")
            {
                MessageBox.Show("Masukkan No Telp", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            if (kotaasal == "")
            {
                MessageBox.Show("Masukkan Kota Asal", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "INSERT INTO Pembeli (Id_supl, Nama,No_telp, Kota_asal) VALUES (@id_supl, @nama, @No_telp, @kotaasal)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@Id_supl", idsupl));
                cmd.Parameters.Add(new SqlParameter("@No_telp", notelp));
                cmd.Parameters.Add(new SqlParameter("@Nama", nama));
                cmd.Parameters.Add(new SqlParameter("@Kota_asal", kotaasal));

                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }


        }

        //button add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtidsupl.Enabled = true;
            txtnama.Enabled = true;
            txtnotelp.Enabled = true;
            txtkotaasal.Enabled = true;
            btnSave.Enabled = true;
            btnOpen.Enabled = true;
            btnClear.Enabled = true;

        }
    }
}
