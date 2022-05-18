using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınavOtomasyon
{
    public class kayıtSınır
    {
        public void kelimeSınır(TextBox tx1, TextBox tx2, TextBox tx3, TextBox tx4)
        {
            if (tx1.Text.Length >= 15)
            {
                MessageBox.Show("Ad 15 hane ile sınırlandırılmıştır !");
            }
            else if (tx2.Text.Length >= 15)
            {
                MessageBox.Show("Soyad 15 hane ile sınırlandırılmıştır !");
            }
            else if (tx4.Text.Length >= 25)
            {
                MessageBox.Show("şifre 25 hane ile sınırlandırılmıştır !");
            }

            else if (tx1.Text.Length == 0 || tx2.Text.Length == 0 || tx3.Text.Length == 0 || tx4.Text.Length == 0)
            {
                MessageBox.Show("Ad, Soyad, E-mail veya Parola kutucuklarından herhangi birini boş bırakamazsınız!");
            }
        }

    }
}

