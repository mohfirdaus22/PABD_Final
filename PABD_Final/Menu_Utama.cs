using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABD_Final
{
    public partial class Menu_Utama : Form
    {
        public Menu_Utama()
        {
            InitializeComponent();
        }


        //button koki
        private void btnKoki_Click(object sender, EventArgs e)
        {
            Koki fk = new Koki();
            fk.Show();
            this.Hide();
        }

        private void btnKasir_Click(object sender, EventArgs e)
        {
            Kasir fkas = new Kasir();   
            fkas.Show();
            this.Hide();
        }

        private void btnPembeli_Click(object sender, EventArgs e)
        {
            Pembeli fp = new Pembeli();
            fp.Show();
            this.Hide();
        }

        private void btnSuplier_Click(object sender, EventArgs e)
        {
            Suplier fs = new Suplier();
            fs.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MenuResto fmr = new MenuResto();
            fmr.Show();
            this.Hide();
        }
    }
}
