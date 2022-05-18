using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınavOtomasyon
{
    public partial class Yönetici_ekranı : Form
    {
        public Yönetici_ekranı()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrtmnEkle ek = new ogrtmnEkle();
            ek.Ekle(ogrıd,ogrprl);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminGiris adm = new adminGiris();
            adm.Show();
            this.Hide();
        }
    }
}
