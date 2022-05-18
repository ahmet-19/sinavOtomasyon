using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace sınavOtomasyon
{
    internal class admGirisSorgu
    {
        Yönetici_ekranı yntc = new Yönetici_ekranı();
        Ogretmen_Ekranı ogrtmn = new Ogretmen_Ekranı();
        soruEkle ekle = new soruEkle();
       
        adminGiris frm = new adminGiris();
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-0T2BHER9;Initial Catalog=sınavgiris;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;
       
       
        
        // admin giriş sorgusu 
        public SqlDataReader admSorgu(TextBox adm, TextBox parola)
        {
            int ıd;
            ıd = Convert.ToInt32(adm.Text);
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from adminİnf where adminId='" + ıd + "' and adminPassword='" + parola.Text + "'";
            read = komut.ExecuteReader();

            if(read.Read() == true)
            {
                MessageBox.Show("Giriş başarılı");
                yntc.Show();
                frm.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");

            }
            baglanti.Close();
            return read;
           
        }
       
        
        
        
        // öğretmen giriş sorgusu
       
        public SqlDataReader ogrtmnSorgu(TextBox adm, TextBox parola)
        {
            int ıd;
            ıd = Convert.ToInt32(adm.Text);
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from ogrInfo where ogrId='" + ıd + "' and ogrPassword='" + parola.Text + "'";
            read = komut.ExecuteReader();

            if (read.Read() == true)

            {
                MessageBox.Show("Giriş başarılı");
                ekle.Show();
                frm.Hide();
            }

            else

            {
                MessageBox.Show("İd veya parola yanlış");

            }

            baglanti.Close();

            return read;

        }
    }
}
