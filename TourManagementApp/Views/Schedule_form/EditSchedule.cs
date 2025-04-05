using System;

using TourManagementApp.Models;
using TourManagementApp.Services;
using TourManagementApp.Services.ImplServices;

namespace TourManagementApp.Views.Schedule_form
{
    public partial class EditSchedule : Form
    {
        private Schedule _schedule;
        private Message message= new Message();
        private ScheduleService _scheduleService = new ImplScheduleService();
        public EditSchedule(Schedule schedule)
        {
            InitializeComponent();
            _schedule = schedule;   
            generate_data();
        }

        private void generate_data()
        {
            tb_total.Text= _schedule.Total.ToString();
            tb_customerName.Text = _schedule.CustomerName;
            tb_description.Text = _schedule.Description;
            tb_tourName.Text = _schedule.TourName;
            dateTimePicker_end.Value =_schedule.Day_End;
            dateTimePicker_start.Value =_schedule.Day_Start;
            cbb_status.Text = _schedule.Status_pay;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();                         
        }

        
        private void btn_update_Click(object sender, EventArgs e)
        {  
            if (dateTimePicker_end.Value <= dateTimePicker_start.Value)
            {
                message.MessageWarning("lỗi cập nhật");
                return;
            }
            Schedule scheduleNew = new Schedule(_schedule.ScheduleID,_schedule.TourID, _schedule.TourName,
            _schedule.CustomerID, _schedule.CustomerName, dateTimePicker_start.Value,
            dateTimePicker_end.Value, cbb_status.Text,int.Parse(tb_total.Text), tb_description.Text);
            if (_scheduleService.Update(scheduleNew))
            {
                message.MessageOK("Cập nhật thành công!");
                return ;
            };       
        }

    }
}
