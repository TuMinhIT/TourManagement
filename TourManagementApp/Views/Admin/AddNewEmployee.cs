using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourManagementApp.Database;
using TourManagementApp.Models;
using TourManagementApp.Services;
using TourManagementApp.Services.ImplServices;

namespace TourManagementApp.Views.Admin
{
    public partial class AddNewEmployee : Form
    {
        private readonly Message message = new Message();
        public AddNewEmployee()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tb_email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                message.MessageOK("Email không hợp lệ!");
                return;
            }
            if (string.IsNullOrWhiteSpace(tb_phone.Text) || !tb_phone.Text.All(char.IsDigit))
            {
                message.MessageOK("Số điện thoại không hợp lệ!");
                return;
            }

            UserService userService = new ImplUserService();
            if (string.IsNullOrEmpty(tb_name.Text) || string.IsNullOrEmpty(tb_email.Text))
            {
                string msg = "Vui lòng nhập đủ thông tin";
                MessageBox.Show(msg);
            }
            else
            {
                string pw = tb_password.Text;
                if (string.IsNullOrEmpty(pw))
                {
                    pw = "1111";
                }
                Users user = new Users(pw, "Staff", tb_name.Text,
                   tb_address.Text, tb_phone.Text, tb_email.Text,tb_note.Text );

                string newUserId = userService.RegisterUser(user);

                string msg = $"Bạn đã thêm thành công nhân viên mới! \nTài khoảng đăng nhập\n" +
                    $" Mã nhân viên:  {newUserId}\n Mật khẩu mặc định: {pw} ";
                MessageBox.Show(msg);
                ResetForm();
            }
        }

        private void ResetForm()
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AddNewEmployee_Load(object sender, EventArgs e)
        {

        }

    }
}
