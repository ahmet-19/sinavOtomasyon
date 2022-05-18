using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
/*
namespace sınavOtomasyon
{
    internal class OgrGirisKontrol
    {
        
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-0T2BHER9;Initial Catalog=sınavgiris;Integrated Security=True");
        SqlCommand cmd = new SqlCommand("select * from Users");
        public bool ogrenciGirisKontrol(TextBox email, TextBox parola)
        {
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            bool sonuc = false;
            String kullanıcıEmail = email.ToString();
            String kullanıcıParola = parola.ToString();
            while (reader.Read())
            {
                if (reader["Mail"] == kullanıcıEmail && reader["Password"] == kullanıcıParola)
                {
                    sonuc = true;
                    break;
                }
                
            }
            return sonuc;
        }
    }
    
}
*/