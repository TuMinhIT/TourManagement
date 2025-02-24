using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HOMEPAGE.Services
{
    public class EmailServices
    {
        private string? subject { get; set; }
        private string? body { get; set; }
        private string fromAddress { get; set; }
        private string fromPassword { get; set; }
        public EmailServices() {
         this.subject= string.Empty;
          this.body= string.Empty;
            this.fromAddress= string.Empty;
            this.fromPassword= string.Empty;
        }
        public EmailServices(string? subject, string? body)
        {
            this.subject = subject;
            this.body = body;
            this.fromAddress = "Vominhtu1212004@gmail.com";
            this.fromPassword = "zyypoelolqfaarpi";
        }

        public bool ValidateEmail(string email)
        {
            Regex EmailRegex = new (@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
            return EmailRegex.IsMatch(email);   
        }
        public void SendEmail(string toEmail)
        {
            try
            {
                MailMessage mail = new(fromAddress, toEmail, subject, body);
                string smtpServer = "";
                if (toEmail.Contains("@gmail.com"))
                {
                    smtpServer = "smtp.gmail.com";
                }
                else if (toEmail.Contains("@outlook.com") || toEmail.Contains("@hotmail.com"))
                {
                    smtpServer = "smtp-mail.outlook.com";
                }
                else if (toEmail.Contains("@yahoo.com"))
                {
                    smtpServer = "smtp.mail.yahoo.com";
                }
                SmtpClient client = new(smtpServer, 587)
                {
                    EnableSsl = true,
                    Credentials = new NetworkCredential(fromAddress, fromPassword)
                };

                client.Send(mail);
                MessageBox.Show("Email đã được gửi thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể gửi email. Lỗi: " + ex.Message);
            }
        }
    }
}
