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
using TourManagementApp.Services;
using TourManagementApp.Services.ImplServices;

namespace TourManagementApp.Views.Schedule_form
{
    public partial class AddSchedule : Form
    {
        private Booking _booking;
        private ScheduleService _ScheduleService = new ImplScheduleService();
        private Message message = new Message();    
        public AddSchedule(Booking booking)
        {
            InitializeComponent();
            this._booking = booking;
            generate_data();
        }

        private void AddSchedule_Load(object sender, EventArgs e)
        {

        }

        private void generate_data()
        {
            tb_customerName.Text = _booking.CustomerName;
            tb_tourName.Text = _booking.TourName;
            tb_total.Text = _booking.TotalAmount.ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Schedule scheduleNew = new Schedule(_booking.TourID, _booking.TourName,
                _booking.CustomerID, _booking.CustomerName, dateTimePicker_start.Value,
                dateTimePicker_end.Value,cbb_status.Text ,int.Parse(tb_total.Text), tb_description.Text);
            if (_ScheduleService.AddNew(scheduleNew))
            {
                message.MessageOK("Thêm lịch trình thành công!");
                this.Close();
            }
        }
    }
}
