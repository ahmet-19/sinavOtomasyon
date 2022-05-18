using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace sınavOtomasyon
{
    public class girisSorgu { 
    
    }

    //Data Source=LAPTOP-0T2BHER9;Initial Catalog=sınavgiris;Integrated Security=True
    public class girisSorgusu { 
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-0T2BHER9;Initial Catalog=sınavgiris;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;
        public SqlDataReader kullanıcı(TextBox mail,TextBox Parola)
        {
            ogrenciAnasayfa frm = new ogrenciAnasayfa();
            ogrenciGiris frm1 = new ogrenciGiris();
            baglanti.Open();
            komut = new SqlCommand();   
            komut.Connection = baglanti;
            komut.CommandText = "select *from Users where Mail='" + mail.Text + "' and Password='" + Parola.Text + "'";
            read = komut.ExecuteReader();

            if (read.Read() == true)

            {   
                frm.Show();
                frm1.Hide();
                MessageBox.Show("Giriş başarılı");
                
            }

            else

            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Hata");

            }

            baglanti.Close();

            return read;

        }
        /*
         if (read.Read() == true)
         {
             string pass = read["Password"].ToString;
             if (Parola.Text == read["Password"])
             {
                 MessageBox.Show("Giris Başarılı");
                 frm.Show();
                 frm1.Hide();
             }
             else
             {
                 MessageBox.Show("şifrenizi Kontrol ediniz!");
             }
         }
         else
         {
             MessageBox.Show("Bilgilerinizi Kontrol Ediniz!");
         }
         
        baglanti.Close();
            return read; 
            */
        }
    }
    


