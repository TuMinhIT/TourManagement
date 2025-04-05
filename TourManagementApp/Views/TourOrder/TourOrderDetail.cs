using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using TourManagementApp.Models;
using TourManagementApp.Services;
using TourManagementApp.Services.ImplServices;
using TourManagementApp.Views.Schedule_form;


namespace TourManagementApp.Views.TourOrder
{
    public partial class TourOrderDetail : Form
    {
        private Booking _booking;
        private ScheduleService _scheduleService = new ImplScheduleService();
        private Message message = new Message();
        private BookingService _bookingService = new ImplBookingService();
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
        private string cusID;
        private int tourID;
        private void _generate_data()
        {
            tb_CustomerID.Text = _booking.CustomerID;
            tb_CustomerName.Text = _booking.CustomerName;
            tb_tourID.Text = _booking.TourID.ToString();
            tb_tourName.Text = _booking.TourName;
            cusID = tb_CustomerID.Text;
            tourID = _booking.TourID;
            tb_total.Text = _booking.TotalAmount.ToString();
            tb_prepay.Text = _booking.PrePay.ToString();

            dateTimePicker.Value = _booking.BookingDate;


        }

        private void btn_schedule_Click(object sender, EventArgs e)
        {
    
        }

        private void btn_schedule_Click_1(object sender, EventArgs e)
        {
            Schedule getSchedule = _scheduleService.getByTourID(tourID, cusID);
            if (getSchedule == null)
            {
                if (message.MessageOKCancel("Tour chưa có lịch trình bạn có muốn thêm không?"))
                {
                    AddSchedule addSchedule = new AddSchedule(_bookingService.GetByID(_booking.BookingID));
                    addSchedule.ShowDialog();
                }
            }
            else
            {
                EditSchedule editSchedule = new EditSchedule(getSchedule);
                editSchedule.ShowDialog();
            }
        }
    }
}
