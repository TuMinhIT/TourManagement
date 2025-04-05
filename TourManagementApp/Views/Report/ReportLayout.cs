using Microsoft.Data.SqlClient;
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
using TourManagementApp.Views.Tour;

namespace TourManagementApp.Views.Report
{
    public partial class ReportLayout : Form
    {

        private readonly ReportService reportService = new ReportService();
        
        private void OpenChildForm(Form childForm)
        {
            if (panel.Controls.Count > 0)
            {
                var currentChildForm = panel.Controls[0] as Form;
                currentChildForm?.Close();
            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public ReportLayout()
        {
            InitializeComponent();
            OpenChildForm(new statistic());
        }


     
        private void btn_fillter_Click(object sender, EventArgs e)
        {
            List<Schedule> bookedItems = new List<Schedule>();
            List<Schedule> completedItems = new List<Schedule>();

            DateTime startDate = dateStart.Value;
            DateTime endDate = dateEnd.Value;

            if (startDate > endDate)
            {
                MessageBox.Show("Ngày bắt đầu không được sau ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Dictionary<string, int> stats = reportService.GetStatistics(startDate, endDate);


            if (stats != null)
            {
                lb_sum.Text = stats["TotalRevenue"].ToString();
                lb_tour.Text = stats["TotalTours"].ToString();
                lb_completed.Text = stats["PaidTours"].ToString();
                lb_booked.Text = stats["UnpaidTours"].ToString();


                List<Schedule> schedules = reportService.GetSchedule(startDate, endDate);
         
                foreach (var schedule in schedules)
                {           
                    if (schedule.Status_pay == "Booked")
                    {
                        bookedItems.Add(schedule);
                    }
                    else if (schedule.Status_pay == "Completed")
                    {
                        completedItems.Add(schedule);
                    }
                }

                ShowOnDataGridView(bookedItems, completedItems);
            }
          
        }

        private void ShowOnDataGridView(List<Schedule> bookedItems, List<Schedule> completedItems)
        {
           
            dataGridViewBooked.DataSource = null;
            dataGridViewCompleted.DataSource = null;

        
            if (bookedItems != null && bookedItems.Count > 0)
            {
                dataGridViewBooked.DataSource = bookedItems.Select(s => new
                {
                    TourID = s.TourID,
                    TourName = s.TourName,
                    CustomerName = s.CustomerName,
                    StatusPay = s.Status_pay,
                    Total = s.Total
                }).ToList();
            }

            if (completedItems != null && completedItems.Count > 0)
            {
                dataGridViewCompleted.DataSource = completedItems.Select(s => new
                {
                    TourID = s.TourID,
                    TourName = s.TourName,
                    CustomerName = s.CustomerName,
                    StatusPay = s.Status_pay,
                    Total = s.Total
                }).ToList();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
