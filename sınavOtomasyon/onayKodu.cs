using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
namespace sınavOtomasyon
{
    internal class onayKodu
    {
        Random random = new Random();
        String onaykodum;

        // onay kodu üretme fonksiyonu
        public void onay(TextBox mail, TextBox kod)
        {
            if(mail.Text == null)
            {   
                MessageBox.Show("mail adresinizi giriniz");
            }
            else
            {
                onaykodum = random.Next(10000, 99999).ToString();
                MailMessage mailMessage = new MailMessage(mail.Text, "adonmez856@gmail.com", "GÜVENLİK KODU DOĞRULAMA", "Güvenlik Kodu : " + onaykodum);
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential("adonmez856gmail.com", "Ad1967.ne");
           /*   mailMessage.From = new MailAddress(mail.Text);
                mailMessage.To.Add(mail.Text);
                mailMessage.Subject = "Güvenlik Kodu Doğrulama";
                mailMessage.Body = "Güvenlik Kodu : " + onaykodum;
                smtpClient.Send(mailMessage);
           */
                MessageBox.Show("kod gönderildi");
                
            }

            

        }


        //mail kontrol fonksiyonu
        public void onayKoduKontrol(TextBox kod)
        {
            if (kod.Text == onaykodum)
            {
                MessageBox.Show("Giriş yapıldı lütfen en kısa sürede şifrenizi değiştiriniz.");
            }
            else
            {
                MessageBox.Show("Onay kodunu yanlış girdiniz.");
            }

        }
    }
}
