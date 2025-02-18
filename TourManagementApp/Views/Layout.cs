using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourManagementApp.Views.Tour;
using TourManagementApp.Views.Customers;
using TourManagementApp.Views.Report;
using TourManagementApp.Views.Schedule;

namespace TourManagementApp.Views
{
    public partial class Layout : Form
    {

        private void OpenChildForm(Form childForm)
        {
            if (panel_main.Controls.Count > 0)
            {
                var currentChildForm = panel_main.Controls[0] as Form;
                currentChildForm?.Close();
            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public Layout()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            if (panel_main.Controls.Count > 0)
            {
                var currentChildForm = panel_main.Controls[0] as Form;
                currentChildForm?.Close();
            }
        }

        private void btn_tour_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Tourlayout());
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerLayout());
        }

   

        private void btn_report_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportLayout());
        }

     

        private void btn_schedule_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ScheduleLayout());
        }
    }
}
