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
    public partial class doğrulamaEkranı : Form
    {
        onayKodu kod = new onayKodu();
        public doğrulamaEkranı()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ogrenciGiris form = new ogrenciGiris();
            form.Show();
            this.Hide();    
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            kod.onay(textBox1,textBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kod.onayKoduKontrol(textBox2);
        }
    }
}
