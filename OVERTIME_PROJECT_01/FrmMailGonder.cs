using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace OVERTIME_PROJECT_01
{
    public partial class FrmMailGonder : Form
    {

        public FrmMailGonder()
        {
            InitializeComponent();
        }


        private void ccCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ccCheck.Checked == true)
            {
                ccTextBox.Enabled = true;
            }
            else
            {
                if (ccTextBox.Enabled == true)
                {
                    ccTextBox.Enabled = false;
                    ccTextBox.Clear();
                }
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            SendMail(emailText.Text);
            emailText.Clear();
            ccTextBox.Clear();
        }


        private void SendMail(string toMailAdress)
        {
            try
            {
                MailMessage mail = new MailMessage();
                var fromMailAdress = new MailAddress(@"engindenizmuhendis@gmail.com","fromMessage");
                var toMailAddress = new MailAddress(toMailAdress.Trim(), "toMessage");                
                const string password = "Ebr565400.";
                const string subject = "HAFTALIK FAZLANDAN MESAİ RAPORU";
                const string body = "Mail gönderildi";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromMailAdress.Address, password)                
                };

                var message = new MailMessage(fromMailAdress, toMailAddress)
                {
                    Subject = subject,
                    Body = body
                };

                if (ccCheck.Checked)
                {
                    MailAddress copy = new MailAddress(ccTextBox.Text);
                    message.CC.Add(copy);
                }

                message.Attachments.Add(new Attachment(@"C:\Users\Angel Diesel\Desktop\Reports\report.pdf"));
                string userState = "test message";

                smtp.SendAsync(message, userState);
                //smtp.SendCompleted += new SendCompletedEventHandler(SendCompletedCallBack);

                // bu kullanımı araştır
                smtp.SendCompleted += (sender, e) =>
                {
                    SendCompletedCallBack(sender, e);
                    smtp.Dispose();
                    message.Dispose();
                };

                //burakengin@burulas.com.tr
                //sedattulumdas@burulas.com.tr
                // using stream reader ya da stream writer da kullanılabilir çünkü kullanıldıktan sonra ram'i temizler                z
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        

        // burada gönderdiğimiz mail mesajının durumunu kontrol ediyoruz
        private static void SendCompletedCallBack(object sender, AsyncCompletedEventArgs e)
        {        
            string token = (string)e.UserState;
            if (e.Cancelled)
            {
                MessageBox.Show("Gönderi İptal Edildi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (e.Error != null)
            {
                MessageBox.Show("Gönderide Hata Oluştu", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Mailler Başarılı Bir Şekilde Gönderildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

    }
}
