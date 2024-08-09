using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace market
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.FormClosed += new FormClosedEventHandler(frm1_FormClosed);
            frm1.Show();
            this.Hide();
        }

        private void btnDepo_Click(object sender, EventArgs e)
        {
            FormDepo depo = new FormDepo();
            depo.FormClosed += new FormClosedEventHandler(depo_FormClosed);
            depo.Show();
            this.Hide();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            FormAyarlar ayarlar = new FormAyarlar();
            ayarlar.FormClosed += new FormClosedEventHandler(ayarlar_FormClosed);
            ayarlar.Show();
            this.Hide();
        }

        private void frm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void depo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void ayarlar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

    }
}
