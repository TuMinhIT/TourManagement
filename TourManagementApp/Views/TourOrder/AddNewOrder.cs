using System;
using System.Collections.Generic;

using TourManagementApp.Views.Customers;
using TourManagementApp.Models;
using TourManagementApp.Services;
using TourManagementApp.Services.ImplServices;
namespace TourManagementApp.Views.Tour
{
    public partial class AddNewOrder : Form
    {
        private int tourID;
        private string tourName;
        private readonly CustomerService _customerService = new ImplCustomerService();
        private readonly TourService _tourService = new ImplTourService();
        private readonly BookingService _bookingService = new ImplBookingService();
        private readonly Message message = new Message();
        public AddNewOrder(int tourID, string tourName)
        {
            InitializeComponent();
            this.tourID = tourID;
            this.tourName = tourName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            AddNewCustomer addNewCustomer = new AddNewCustomer();
            addNewCustomer.ShowDialog();
        }

        private void AddNewOrder_Load(object sender, EventArgs e)
        {
            tb_tourInf.Text = "Mã tour: "+tourID.ToString() + "----" + tourName;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_total.Text) || string.IsNullOrEmpty(tb_code.Text)
                || string.IsNullOrEmpty(cbb_status.Text) ||
                dateTimePicker.Value == null)
            {
                message.MessageOK("Xin hãy nhập đủ thông tin!");
                return;
            }

            int total = int.TryParse(tb_total.Text, out int t) ? t : 0;
            int prePay = int.TryParse(tb_prePay.Text, out int p) ? p : 0;

            Booking newBooking = new
                Booking(tb_code.Text,_cusName ,tourID,tourName ,dateTimePicker.Value,
                cbb_status.SelectedItem.ToString(),
                total, prePay);
            if (_bookingService.AddNew(newBooking))
            {
                message.MessageOK("Thêm thành công! ");
                reset();
            }

        }

        private string _cusName;
        private void load_customer_Click(object sender, EventArgs e)
        {
            Customer customer = _customerService.GetById(tb_code.Text);
            if (customer != null)
            {
                _cusName = customer.FullName;
                lb_customer.Text = customer.FullName.ToString() + "___" + customer.Email;
            }
            else
            {
                message.MessageWarning("Mã khách hàng không tồn tại!");
            }
        }

        private void reset()
        {
            tb_code.Text = string.Empty;
            tb_prePay.Text = string.Empty;
            tb_total.Text = string.Empty;
            cbb_status.Text = "Booked";
            lb_customer = new Label();

        }

    }
}
