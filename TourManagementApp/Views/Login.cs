using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourManagementApp.Services;
using TourManagementApp.Services.ImplServices;
using TourManagementApp.Views;
using TourManagementApp.Models;

namespace TourManagementApp.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            this.BackColor = Color.Magenta;  
            this.TransparencyKey = Color.Magenta; 
        }

        //Users user = userService.UserAuth(tb_userName.Text, tb_password.Text);
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
            Users user = userService.UserAuth("NV001", "1111");
            if (user != null)
            {
                //Layout layout = new Layout(user);
                //layout.ShowDialog();
                //this.Close();
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
