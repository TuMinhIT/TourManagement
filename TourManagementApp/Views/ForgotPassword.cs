using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TourManagementApp.Models;
using TourManagementApp.Services;
using TourManagementApp.Services.ImplServices;
using TourManagementApp.Utils;
using System.Text.RegularExpressions;

namespace TourManagementApp.Views
{
    public partial class ForgotPassword : Form
    {
        private readonly UserService _userService = new ImplUserService();
        private readonly Message message = new Message();
        private readonly EmailServices _emailServices = new EmailServices();
        private Users currentUser;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            tb_code.Enabled = false;
            btn_confirm.Enabled = false;
            panel.Hide();
        }
        string otp;
        private void btn_sent_Click(object sender, EventArgs e)
        {

            if (!Regex.IsMatch(tb_email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                message.MessageOK("Email không hợp lệ!");
                return;
            }


            currentUser = _userService.GetByEmail(tb_email.Text);
            if (currentUser != null)
            {
                string userEmail = tb_email.Text.Trim();
                otp = _emailServices.GenerateOTP();
                _emailServices.SendOTP(userEmail, otp);
                btn_confirm.Enabled = true;
                tb_code.Enabled = true;
            }
            else
            {
                message.MessageWarning("Email chưa có tài khoảng!!");
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string inputOTP = tb_code.Text.Trim();

            if (inputOTP == otp) 
            {
                panel.Show();
            }
            else
            {
                message.MessageOK("Mã OTP không chính xác, vui lòng thử lại!");
            }

        }

        private void btn_close_panel_Click(object sender, EventArgs e)
        {
            panel.Hide();
        }

        private void cbx_showpwd_CheckedChanged(object sender, EventArgs e)
        {

            if (!cbx_showpwd.Checked)
            {
                tb_pwd.UseSystemPasswordChar = true;
                tb_rpwd.UseSystemPasswordChar = true;
            }
            else
            {
                tb_pwd.UseSystemPasswordChar = false;
                tb_rpwd.UseSystemPasswordChar = false;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (tb_pwd.Text != tb_rpwd.Text)
            {
                message.MessageWarning("Mật khẩu không hợp lệ!!");
                return;
            }
            if (string.IsNullOrEmpty(tb_rpwd.Text))
            {
                message.MessageWarning("Mật khẩu không để trống!!");
                return;
            }

            if (currentUser != null)
            {
                currentUser.Password = tb_rpwd.Text;    
                flag = _userService.changePassword(currentUser);
                if (flag)
                {
                    message.MessageOK("Đổi mật khẩu thành công" +
                        " - mã nhân viên của bạn là " + currentUser.UserID +
                        " mời bạn đăng nhập!!");
                    this.Close();
                }
            }
        }
    }
}
