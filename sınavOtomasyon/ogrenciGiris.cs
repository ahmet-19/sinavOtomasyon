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
    public partial class ogrenciGiris : Form
    {
        public ogrenciGiris()
        {
            InitializeComponent();
        }
         
        girisSorgusu sorgu = new girisSorgusu();
       
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            OgrGirisKontrol kntrl = new OgrGirisKontrol();
            bool sonuc =  kntrl.ogrenciGirisKontrol(textBox1,textBox2);
            if(sonuc)
            {
                Form8 form = new Form8();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Parola yanlış! Parolanızı unuttuysanız aşağıdan doğrulama yapınız. ");
            }
            */
            
            
            sorgu.kullanıcı(txtmail,txtParola);
        }

        private void GERİ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ogrencikayıtgrs form = new ogrencikayıtgrs();
            form.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            doğrulamaEkranı frm = new doğrulamaEkranı();
            frm.Show();
            this.Hide();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gizleGoster gzl = new gizleGoster();
            gzl.gstr(txtParola);
        }
    }
}
