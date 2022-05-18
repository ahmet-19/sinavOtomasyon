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
    public partial class ogrenciKayıtEkranı : Form
    {
        public ogrenciKayıtEkranı()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ogrencikayıtgrs frm = new ogrencikayıtgrs();
            frm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gizleGoster gzl = new gizleGoster();
            gzl.gstr(textBox4);
        }

     }
}
