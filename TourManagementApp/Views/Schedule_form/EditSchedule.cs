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

namespace TourManagementApp.Views.Schedule_form
{
    public partial class EditSchedule : Form
    {
        private Schedule _schedule;
        private Message message= new Message();
        public EditSchedule(Schedule schedule)
        {
            InitializeComponent();
            _schedule = schedule;   
            generate_data();
        }

        private void generate_data()
        {
            tb_customerName.Text = _schedule.CustomerName;
            tb_description.Text = _schedule.Description;
            tb_tourName.Text = _schedule.TourName;
            dateTimePicker_end.Value =_schedule.Day_End;
            dateTimePicker_start.Value =_schedule.Day_Start;
            cbb_payment.Text = _schedule.Status_pay;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
           if (message.MessageOKCancel("Bạn có muốn lưu sự thay đổi? "))
           {
                Schedule scheduleNew = new Schedule(_schedule.TourID, _schedule.TourName,
                _schedule.CustomerID, _schedule.CustomerName, dateTimePicker_start.Value,
                dateTimePicker_end.Value, cbb_status.Text, tb_description.Text);
           }

        }

    }
}
