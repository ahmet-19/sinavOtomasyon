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
    internal class ogrtmnEkle
    {
        SqlConnection baglantı = new SqlConnection("Data Source=LAPTOP-0T2BHER9;Initial Catalog=sınavgiris;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;

        public void Ekle(TextBox ıd, TextBox parola)
        {
            baglantı.Open();
            komut = new SqlCommand();
            komut.Connection = baglantı;
            komut.CommandText = "insert into ogrInfo(ogrId, ogrPassword) values('" + ıd.Text + "','" +parola.Text + "')";
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kayıt Oluşturuldu.");
        }
    }
}
