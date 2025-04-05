using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourManagementApp.Models;
using TourManagementApp.Services.ImplServices;
using TourManagementApp.Services;
using System.Windows.Interop;
using System.Text.RegularExpressions;

namespace TourManagementApp.Views.Customers
{
    public partial class AddNewCustomer : Form
    {
        Message message = new Message();
        public AddNewCustomer()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
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

            if (tb_phone.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Số điện thoại không được chứa chữ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tb_phone.Text.Length > 11)
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CustomerService customerService = new ImplCustomerService();
            if (string.IsNullOrEmpty(tb_name.Text)
                || string.IsNullOrEmpty(tb_email.Text)
                || string.IsNullOrEmpty(cbb_gender.SelectedItem.ToString()))
            {
                string msg = "Vui lòng nhập đủ thông tin!";
                message.MessageOK(msg);
            }
            else
            {
                if (tb_phone.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Số điện thoại không được chứa chữ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Customer newCustomer = 
                    new Customer(tb_name.Text, cbb_gender.SelectedItem.ToString(), tb_phone.Text,
                                  tb_email.Text, tb_address.Text, tb_national.Text, tb_note.Text);
                if (customerService.AddNew(newCustomer))
                {
                    string msg = $"Bạn đã thêm thành công khách hàng mới! \n";
                    message.MessageOK(msg);
                    ResetForm();
                }
            }
        }

        private void ResetForm()
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
