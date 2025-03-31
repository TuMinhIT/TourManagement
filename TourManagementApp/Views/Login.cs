using System;

using TourManagementApp.Services;
using TourManagementApp.Services.ImplServices;
using TourManagementApp.Views;
using TourManagementApp.Models;

namespace TourManagementApp.Views
{
    public partial class Login : Form
    {
        private string fullText = "Đăng nhập";
        private int currentCharIndex = 0;
        private System.Windows.Forms.Timer typingTimer;
        public Login()
        {
            InitializeComponent();

            this.BackColor = Color.Magenta;  
            this.TransparencyKey = Color.Magenta;

            SetupTypingEffect();
        }
        private void SetupTypingEffect()
        {
            label8.Text = "";
            typingTimer = new System.Windows.Forms.Timer();
            typingTimer.Interval = 100;
            typingTimer.Tick += TypingTimer_Tick;
            typingTimer.Start();
        }

        private void TypingTimer_Tick(object sender, EventArgs e)
        {
            //if (currentCharIndex < fullText.Length)
            //{
            //    label8.Text += fullText[currentCharIndex];
            //    currentCharIndex++;
            //}
            //else
            //{
            //    typingTimer.Stop();
            //    System.Threading.Tasks.Task.Delay(1000).ContinueWith(_ =>
            //    {
            //        this.Invoke(new Action(() =>
            //        {
            //            label8.Text = "";
            //            currentCharIndex = 0;
            //            typingTimer.Start();
            //        }));
            //    });
            //}
        }


       
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Message message = new Message();
            if (string.IsNullOrEmpty(tb_userName.Text) ||
                string.IsNullOrEmpty(tb_password.Text))
            {
                message.MessageOK("Xin nhập đầy đủ thông tin");
                return;
            }
            UserService userService = new ImplUserService();
            Users user = userService.UserAuth(tb_userName.Text, tb_password.Text);
            if (user != null)
            {
                Layout layout = new Layout(user);
                this.Hide();  
                layout.ShowDialog();
                this.Close(); 
            }
            else {
                message.MessageOK("Sai tên đăng nhập hoặc mật khẩu");
                return;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lableForgot_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void check_hide_CheckedChanged(object sender, EventArgs e)
        {
            if (check_hide.Checked == false)
            {
               tb_password.UseSystemPasswordChar = true;
            }
            else 
            {
                tb_password.UseSystemPasswordChar = false;
            }
        }

       
    }
}
