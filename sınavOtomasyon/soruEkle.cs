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
    public partial class soruEkle : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-0T2BHER9;Initial Catalog=sınavgiris;Integrated Security=True");
        public soruEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminGiris frm = new adminGiris();
            frm.Show();
            this.Hide();
        }

        private void path_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            pictureBox1.ImageLocation = ofd.FileName;
            textBox3.Text = ofd.FileName;    
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            conn.Open();
           
            SqlCommand komut = new SqlCommand("insert into questins(QuestionText,SectionId,PıcturePath,RightAnswer) values(@p1,@p2,@p3,@p4)" , conn);
        
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", int.Parse(textBox2.Text));
            komut.Parameters.AddWithValue("@p3", textBox3.Text);
            komut.Parameters.AddWithValue("@p4", textBox4.Text);
            komut.ExecuteNonQuery();
           
            conn.Close();
            MessageBox.Show("Kayıt Eklendi");
        }
    }
}
