using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace sınavOtomasyon
{
    public partial class adminGiris : Form
    {
        public adminGiris()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            merkez mrkz = new merkez();
            mrkz.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            gizleGoster gzl = new gizleGoster();
            gzl.gstr(txtParola);
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            admGirisSorgu sorgu = new admGirisSorgu();
            
            if(radioButton1.Checked == true)
            {
                
                sorgu.admSorgu(txtadm, txtParola);
            }
            else if(radioButton2.Checked == true)
            {
                sorgu.ogrtmnSorgu(txtadm , txtParola);
            }
            else
            {
                MessageBox.Show("Lütfen yönetici veya öğretmen olduğunuzu belirtiniz.");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
