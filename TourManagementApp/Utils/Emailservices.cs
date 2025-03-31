
using System.Net.Mail;
using System.Net;

using System.Text.RegularExpressions;

namespace TourManagementApp.Utils
{
    public class EmailServices
    {
        private string? subject { get; set; }
        private string? body { get; set; }
        private string fromAddress { get; set; }
        private string fromPassword { get; set; }

        public string GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        public void SendOTP(string toEmail, string otp)
        {
            if (!ValidateEmail(toEmail))
            {
                MessageBox.Show("Email không hợp lệ!");
                return;
            }

            subject = "Xác thực tài khoản";
            body = $"Mã xác thực của bạn là: {otp}";

            SendEmail(toEmail);
        }

        public EmailServices()
        {
            subject = string.Empty;
            body = string.Empty;
            fromAddress = "Vominhtu1212004@gmail.com";
            fromPassword = "zyypoelolqfaarpi";
        }
        public EmailServices(string? subject, string? body)
        {
            this.subject = subject;
            this.body = body;
            fromAddress = "Vominhtu1212004@gmail.com";
            fromPassword = "zyypoelolqfaarpi";
        }
        public bool ValidateEmail(string email)
        {
            Regex EmailRegex = new(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
            return EmailRegex.IsMatch(email);
        }
        public void SendEmail(string toEmail)
        {
            try
            {       
                MailMessage mail = new(fromAddress, toEmail, subject, body);
                SmtpClient client = new("smtp.gmail.com", 587)
                {
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress, fromPassword)
                };

                client.Send(mail);
                MessageBox.Show("Mã OTP đã được gửi. Vui lòng kiểm tra email.");
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Địa chỉ email không hợp lệ!");
            }
            catch (SmtpException smtpEx)
            {
                MessageBox.Show("Lỗi SMTP: " + smtpEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể gửi email. Lỗi: " + ex.Message);
            }
        }

    }
}
