using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        public AddNewEmployee()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
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
                    pw = tb_password.PlaceholderText;
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
