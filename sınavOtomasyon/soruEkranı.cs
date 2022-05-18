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
    public partial class soruEkranı : Form
    {   
        Random rand = new Random();
        SqlDataReader read;
        SqlCommand cmd;
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-0T2BHER9;Initial Catalog=sınavgiris;Integrated Security=True");
        public void rnd()
        {   
            List<int> list = new List<int>();
            
            for(int i=0; i<10; i++) 
            {
                list.Add(rand.Next(100));
            }
            for(int i=0; i<10; i++)
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                new SqlCommand("select PıcturePath from questins where QuestionsId='" + list[i]+ "' ");
                
               read = cmd.ExecuteReader();
                
            }
            

        }

        public soruEkranı()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
 
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciAnasayfa ogr = new ogrenciAnasayfa();
            ogr.Show();
            this.Hide();
        }
    }
}
