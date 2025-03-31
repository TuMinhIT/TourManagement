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

namespace TourManagementApp.Views.TourOrder
{
    public partial class TourOrderDetail : Form
    {
        private Booking _booking;
        public TourOrderDetail(Booking booking)
        {
            _booking = booking;
            InitializeComponent();
            _generate_data();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TourOrderDetail_Load(object sender, EventArgs e)
        {
            
        }

        private void _generate_data()
        {
            tb_CustomerID.Text = _booking.CustomerID;
            tb_CustomerName.Text = _booking.CustomerName;
            tb_tourID.Text = _booking.TourID.ToString();
            tb_tourName.Text = _booking.TourName;

            tb_total.Text = _booking.TotalAmount.ToString();
            tb_prepay.Text = _booking.PrePay.ToString();

            dateTimePicker.Value =_booking.BookingDate;
        }
    }
}
