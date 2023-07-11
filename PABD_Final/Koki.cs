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
    public partial class Koki : Form
    {
        //connection sql
        private string stringConnection = "data source=Jorengezzz\\THEPASHTER;" + "database=Restaurant_K1;User ID=sa;password=Salahtompo22";
        private SqlConnection koneksi;


        //membuat sndiri refresh form
        private void refreshform()
        {
            txtidkoki.Text = "";
            txtnama.Text = "";
            txtnotelp.Text = "";
            txtalamat.Text = "";

            btnClear.Enabled = false;
            btnSave.Enabled = false;
            btnOpen.Enabled = false;

        }
        public Koki()
        {
            InitializeComponent();
        }

        private void Koki_Load(object sender, EventArgs e)
        {

        }
    }
}
