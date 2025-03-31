using Azure.Core;

using TourManagementApp.Models;
using TourManagementApp.Services;
using TourManagementApp.Services.ImplServices;

namespace TourManagementApp.Views.Schedule_form
{
    public partial class ScheduleItem : Form
    {
        private Schedule _schedule;
        private ScheduleService _scheduleService = new ImplScheduleService();
        private Message message = new Message();    
        public ScheduleItem(Schedule schedule)
        {
            InitializeComponent();
            _schedule = schedule;
            generate_data();
        }

        private void generate_data()
        {
            tb_customerName.Text = _schedule.CustomerName;
            tb_tourName.Text = _schedule.TourName;
            tb_description.Text = _schedule.Description;
            tb_cost.Text = _schedule.Total.ToString();
            tb_status.Text = _schedule.Status_pay;
           
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
         
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
        
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (message.MessageOKCancel("Bạn có chắc chắn muốn xóa!!!"))
            {
                _scheduleService.DeleteById(_schedule.ScheduleID);
                this.Close();
            }    
          
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            EditSchedule editSchedule = new EditSchedule(_schedule);
            editSchedule.ShowDialog();
            _scheduleService.GetById(_schedule.ScheduleID);
            generate_data();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
         
        }
    }
}
