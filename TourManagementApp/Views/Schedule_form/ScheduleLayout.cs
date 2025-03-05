using System;

using TourManagementApp.Models;
using TourManagementApp.Services;
using TourManagementApp.Services.ImplServices;
using TourManagementApp.Views.Tour;

namespace TourManagementApp.Views.Schedule_form
{
    public partial class ScheduleLayout : Form
    {
        private List<Schedule> list_schedule = new List<Schedule> ();
        private readonly ScheduleService _scheduleService = 
            new ImplScheduleService();   
        public ScheduleLayout()
        {
            list_schedule = _scheduleService.getAll();

            InitializeComponent();
            generate_data(list_schedule);
        }

        private void ScheduleLayout_Load(object sender, EventArgs e)
        {

        }

        private void generate_data(List<Schedule> schedules)
        {
            panel_main.Controls.Clear();
            foreach (Schedule item in schedules)
            {
                ScheduleItem subForm = new ScheduleItem(item);
                subForm.TopLevel = false;
                subForm.FormBorderStyle = FormBorderStyle.None;
                subForm.Dock = DockStyle.Top;
                panel_main.Controls.Add(subForm);
                subForm.Show();
            }
        }



    }
}
