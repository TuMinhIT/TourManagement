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
using TourManagementApp.Views.Schedule_form;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using TourManagementApp.Views.Admin;
using TourManagementApp.Models;
using TourManagementApp.Views.Account;

namespace TourManagementApp.Views
{
    public partial class Layout : Form
    {

        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        private Users _user;
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

        public Layout(Users user)
        {
            this._user = user;
            InitializeComponent();
            initForm();
        }
        private void initForm()
        {
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panel_left.Controls.Add(leftBorderBtn);
            label_userName.Text = _user.FullName;
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
        }

        private void label_userName_Click(object sender, EventArgs e) { }

        private void btn_home_Click(object sender, EventArgs e)
        {
            if (panel_main.Controls.Count > 0)
            {
                var currentChildForm = panel_main.Controls[0] as Form;
                currentChildForm?.Close();
            }

            ActivateButton(sender, RGBColors.color1);
        }

        private void btn_tour_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Tourlayout());
            ActivateButton(sender, RGBColors.color5);
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerLayout());
            ActivateButton(sender, RGBColors.color2);
        }

        private void btn_schedule_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ScheduleLayout() );
            ActivateButton(sender, RGBColors.color3);
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportLayout());
            ActivateButton(sender, RGBColors.color4);
        }

        private void btn_employees_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeesLayout());
            ActivateButton(sender, RGBColors.color2);
        }
        private void btn_account_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AccountLayout(_user));
            ActivateButton(sender, RGBColors.color1);
        }
        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TourOrderLayout());
            ActivateButton(sender, RGBColors.color1);
        }
    }
}
