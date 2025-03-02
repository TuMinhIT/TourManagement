using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using TourManagementApp.Models;
using TourManagementApp.Services;
using TourManagementApp.Services.ImplServices;

namespace TourManagementApp.Views.Customers
{
    public partial class CustomerDetail : Form
    {
        private Customer _customers;
        private CustomerService customerService = new ImplCustomerService();
        Message message = new Message();
        public CustomerDetail(Customer customer)
        {
            InitializeComponent();
            _customers = customer;
            panel.Enabled = false;
            btn_save.Hide();
        }

        private void btn_x_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _generate_data(Customer _customers)
        {
            tb_name.Text = _customers.FullName;
            tb_email.Text = _customers.Email;
            tb_national.Text = _customers.Nationality;
            tb_note.Text = _customers.Note;
            tb_phone.Text = _customers.PhoneNumber;
            tb_address.Text = _customers.Address;
            cbb_gender.Text = _customers.Gender;
            tb_code.Text = _customers.CustomerID;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_name.Text)
                || string.IsNullOrEmpty(tb_email.Text)
                || string.IsNullOrEmpty(cbb_gender.SelectedItem.ToString()))
            {
                string msg = "Vui lòng nhập đủ thông tin!";
                message.MessageOK(msg);
                return;
            }
            else
            {
                Customer newCustomer =
                new Customer(tb_name.Text, cbb_gender.SelectedItem.ToString(), tb_phone.Text,
                                tb_email.Text, tb_address.Text, tb_national.Text, tb_note.Text)
                { CustomerID = tb_code.Text };
              
                if (customerService.Update(newCustomer))
                {
                    string msg = $"Bạn đã cập nhật thành công ! \n";
                    message.MessageOK(msg);
                    _generate_data(newCustomer);
                }
            }
            btn_update.Show();
            btn_save.Hide();
            return;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            btn_update.Hide();
            btn_save.Show();
        }

        private void CustomerDetail_Load(object sender, EventArgs e)
        {
            _generate_data(_customers);
        }
    }
}
