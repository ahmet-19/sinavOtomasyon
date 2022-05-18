using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sınavOtomasyon
{
    internal class sınavGirisAlgo
    {

        List<string> sorulink = new List<string>();
        List<string> dogrucevap = new List<string>();
        SqlDataReader read;
        Random rndm = new Random();
        SqlCommand cmd;
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-0T2BHER9;Initial Catalog=sınavgiris;Integrated Security=True");

        public void soruget()
        {

            /*
            conn.Open();
            for (int i = 0; i < 10; i++)
            {
                int rnd = rndm.Next(1, 100);
                SqlCommand cmd = new SqlCommand("select PicturePath from Users where QuestionId='" + rnd + "'", conn);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    // sorulink.Add(read["PicturePath"].ToString);

                }
                conn.Close();

            }
          */


        }

        public List<sorular> sor()
        {
            List<sorular> sorulist = new List<sorular>();
            int sayı = rndm.Next(1,100);
            string sql = "select PıcturePath from questins where QuestionId = '" + sayı + "'";
            conn.Open();
            cmd = new SqlCommand(sql, conn);  
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                sorular sr = new sorular();
                sr.ıd = reader[0].ToString();
                sr.sd = reader[1].ToString();
                sr.BölümId = reader[2].ToString();
                sr.ımg = reader[3].ToString();
                sr.Idogru = reader[4].ToString();
            }
            conn.Close();
            return sorulist;
        }

            public void dondur()
        {
            for (int i = 0; i<10; i++)
            {
                sor();
            }
        }

    }
}



    