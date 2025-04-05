using System;
using System.Collections.Generic;

using TourManagementApp.Views.Customers;
using TourManagementApp.Models;
using TourManagementApp.Services;
using TourManagementApp.Services.ImplServices;
using System.Drawing.Text;
namespace TourManagementApp.Views.Tour
{
    public partial class AddNewOrder : Form
    {
        private int tourID =1;
        private string tourName ="null";
        private string total = "null";
        private readonly CustomerService _customerService = new ImplCustomerService();
        private readonly TourService _tourService = new ImplTourService();
        private readonly BookingService _bookingService = new ImplBookingService();
        private List<Customer> _customerList = new List<Customer>();
        private readonly Message message = new Message();
        
        public AddNewOrder(int tourID, string tourName, string total)
        {
            InitializeComponent();
            this.tourID = tourID;
            this.tourName = tourName;
            this.total = total;
            _customerList = _customerService.getAllCustomer();
            getCustomer(_customerList);
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
            tb_tourInf.Text = "Mã tour: " + tourID.ToString() + "---" + tourName;
            tb_total.Text = total;
        }
        
        private string _cusName;
        private void btn_save_Click(object sender, EventArgs e)
        {   
            if (string.IsNullOrEmpty(tb_total.Text) || 
                cbb_customer.Text =="<trống>")
            {
                message.MessageOK("Xin hãy nhập đủ thông tin!");
                return;
            }

            int total = int.TryParse(tb_total.Text, out int t) ? t : 0;
            int prePay = int.TryParse(tb_prePay.Text, out int p) ? p : 0;
            string status = "Booked";

            if (total == prePay)
            {
                status = "Completed";
            }else if (total < prePay)
            {
                message.MessageWarning("Số tiền thanh toán không hợp lệ!");
                return;
            }

            Booking newBooking = new
                Booking(cbb_customer.Text, _cusName, tourID, tourName, dateTimePicker.Value,
                status,
                total, prePay);
            if (_bookingService.AddNew(newBooking))
            {
                message.MessageOK("Thêm thành công! ");
                this.Close();
            }

        }
        
        private void cbb_customer_Leave(object sender, EventArgs e)
        {
            string selectedText = cbb_customer.Text;

            bool exists = cbb_customer.Items.Contains(selectedText);

            if (!exists)
            {
                lb_customer.Text = "Giá trị nhập không hợp lệ, vui lòng chọn trong danh sách!";
                lb_customer.ForeColor = Color.Red;
                cbb_customer.Focus();
            }
            else
            {              
                Customer customer = _customerList.FirstOrDefault(c => c.CustomerID == selectedText);

                if (customer != null)
                {
                    lb_customer.Text = $"{selectedText}  {customer.FullName}";
                    lb_customer.ForeColor = Color.Black;
                    _cusName = customer.FullName;
                }
            }
            
        }


        private void load_customer_Click(object sender, EventArgs e)
        {
          
        }


        private void lb_customer_Click(object sender, EventArgs e)
        {

        }

        private void getCustomer(List<Customer> _customerList)
        {
            cbb_customer.Items.Clear(); 

            foreach (Customer customer in _customerList)
            {
                string id = customer.CustomerID; 
                cbb_customer.Items.Add(id);
            }
        }
    }
}
