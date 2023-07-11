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
        public MenuResto()
        {
            InitializeComponent();
        }

        private void MenuResto_Load(object sender, EventArgs e)
        {

        }
    }
}
