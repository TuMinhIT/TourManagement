namespace TourManagementApp.Views
{
    partial class Layout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_notifications = new FontAwesome.Sharp.IconButton();
            label_userName = new Label();
            label1 = new Label();
            btnHome = new PictureBox();
            panel_main = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel_left = new Panel();
            btn_exit = new FontAwesome.Sharp.IconButton();
            btn_report = new FontAwesome.Sharp.IconButton();
            btn_schedule = new FontAwesome.Sharp.IconButton();
            btn_customer = new FontAwesome.Sharp.IconButton();
            btn_tour = new FontAwesome.Sharp.IconButton();
            btn_home = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            panel1 = new Panel();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panel_main.SuspendLayout();
            panel_left.SuspendLayout();
            panelLogo.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            SuspendLayout();
            // 
            // btn_notifications
            // 
            btn_notifications.FlatAppearance.BorderSize = 0;
            btn_notifications.FlatStyle = FlatStyle.Flat;
            btn_notifications.Font = new Font("Century Gothic", 10.2F);
            btn_notifications.ForeColor = SystemColors.ButtonFace;
            btn_notifications.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            btn_notifications.IconColor = SystemColors.ButtonFace;
            btn_notifications.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_notifications.IconSize = 32;
            btn_notifications.Location = new Point(791, 14);
            btn_notifications.Name = "btn_notifications";
            btn_notifications.Size = new Size(94, 29);
            btn_notifications.TabIndex = 12;
            btn_notifications.UseVisualStyleBackColor = true;
            btn_notifications.Click += bnt_notifications_Click_1;
            // 
            // label_userName
            // 
            label_userName.AutoSize = true;
            label_userName.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label_userName.ForeColor = SystemColors.ButtonFace;
            label_userName.Location = new Point(641, 14);
            label_userName.Name = "label_userName";
            label_userName.Size = new Size(91, 19);
            label_userName.TabIndex = 11;
            label_userName.Text = "Username";
            label_userName.Click += label_userName_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(498, 14);
            label1.Name = "label1";
            label1.Size = new Size(83, 19);
            label1.TabIndex = 10;
            label1.Text = "Xin chào";
            // 
            // btnHome
            // 
            btnHome.Image = Properties.Resources.final_removebg_preview;
            btnHome.Location = new Point(12, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(193, 93);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // panel_main
            // 
            panel_main.AutoScroll = true;
            panel_main.BackColor = SystemColors.ButtonFace;
            panel_main.Controls.Add(panel8);
            panel_main.Controls.Add(panel9);
            panel_main.Controls.Add(panel7);
            panel_main.Controls.Add(panel6);
            panel_main.Controls.Add(panel5);
            panel_main.Controls.Add(panel4);
            panel_main.Location = new Point(220, 60);
            panel_main.MaximumSize = new Size(1000, 580);
            panel_main.MinimumSize = new Size(970, 580);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(970, 580);
            panel_main.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ActiveCaption;
            panel8.Location = new Point(352, 297);
            panel8.Name = "panel8";
            panel8.Size = new Size(250, 194);
            panel8.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ActiveCaption;
            panel9.Location = new Point(629, 297);
            panel9.Name = "panel9";
            panel9.Size = new Size(250, 194);
            panel9.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaption;
            panel7.Location = new Point(68, 297);
            panel7.Name = "panel7";
            panel7.Size = new Size(250, 194);
            panel7.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaption;
            panel6.Location = new Point(620, 55);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 178);
            panel6.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Location = new Point(336, 55);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 178);
            panel5.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Location = new Point(59, 55);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 178);
            panel4.TabIndex = 0;
            // 
            // panel_left
            // 
            panel_left.BackColor = Color.FromArgb(30, 31, 68);
            panel_left.Controls.Add(btn_exit);
            panel_left.Controls.Add(btn_report);
            panel_left.Controls.Add(btn_schedule);
            panel_left.Controls.Add(btn_customer);
            panel_left.Controls.Add(btn_tour);
            panel_left.Controls.Add(btn_home);
            panel_left.Controls.Add(panelLogo);
            panel_left.Dock = DockStyle.Left;
            panel_left.Location = new Point(0, 0);
            panel_left.Name = "panel_left";
            panel_left.Size = new Size(220, 653);
            panel_left.TabIndex = 1;
            // 
            // btn_exit
            // 
            btn_exit.Dock = DockStyle.Top;
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = SystemColors.ButtonFace;
            btn_exit.IconChar = FontAwesome.Sharp.IconChar.XTwitter;
            btn_exit.IconColor = SystemColors.ButtonFace;
            btn_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_exit.IconSize = 32;
            btn_exit.ImageAlign = ContentAlignment.MiddleLeft;
            btn_exit.Location = new Point(0, 425);
            btn_exit.Name = "btn_exit";
            btn_exit.Padding = new Padding(10, 0, 20, 0);
            btn_exit.Size = new Size(220, 60);
            btn_exit.TabIndex = 22;
            btn_exit.Text = "Thoát";
            btn_exit.TextAlign = ContentAlignment.MiddleLeft;
            btn_exit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click_2;
            // 
            // btn_report
            // 
            btn_report.Dock = DockStyle.Top;
            btn_report.FlatAppearance.BorderSize = 0;
            btn_report.FlatStyle = FlatStyle.Flat;
            btn_report.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_report.ForeColor = SystemColors.ButtonFace;
            btn_report.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            btn_report.IconColor = SystemColors.ButtonFace;
            btn_report.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_report.IconSize = 32;
            btn_report.ImageAlign = ContentAlignment.MiddleLeft;
            btn_report.Location = new Point(0, 365);
            btn_report.Name = "btn_report";
            btn_report.Padding = new Padding(10, 0, 20, 0);
            btn_report.Size = new Size(220, 60);
            btn_report.TabIndex = 21;
            btn_report.Text = "Báo cáo thống kê";
            btn_report.TextAlign = ContentAlignment.MiddleLeft;
            btn_report.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_report.UseVisualStyleBackColor = true;
            btn_report.Click += btn_report_Click_2;
            // 
            // btn_schedule
            // 
            btn_schedule.Dock = DockStyle.Top;
            btn_schedule.FlatAppearance.BorderSize = 0;
            btn_schedule.FlatStyle = FlatStyle.Flat;
            btn_schedule.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_schedule.ForeColor = SystemColors.ButtonFace;
            btn_schedule.IconChar = FontAwesome.Sharp.IconChar.MapMarkerAlt;
            btn_schedule.IconColor = SystemColors.ButtonFace;
            btn_schedule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_schedule.IconSize = 32;
            btn_schedule.ImageAlign = ContentAlignment.MiddleLeft;
            btn_schedule.Location = new Point(0, 305);
            btn_schedule.Name = "btn_schedule";
            btn_schedule.Padding = new Padding(10, 0, 20, 0);
            btn_schedule.Size = new Size(220, 60);
            btn_schedule.TabIndex = 20;
            btn_schedule.Text = "Lịch trình";
            btn_schedule.TextAlign = ContentAlignment.MiddleLeft;
            btn_schedule.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_schedule.UseVisualStyleBackColor = true;
            btn_schedule.Click += btn_schedule_Click_2;
            // 
            // btn_customer
            // 
            btn_customer.Dock = DockStyle.Top;
            btn_customer.FlatAppearance.BorderSize = 0;
            btn_customer.FlatStyle = FlatStyle.Flat;
            btn_customer.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_customer.ForeColor = SystemColors.ButtonFace;
            btn_customer.IconChar = FontAwesome.Sharp.IconChar.UsersRays;
            btn_customer.IconColor = SystemColors.ButtonFace;
            btn_customer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_customer.IconSize = 32;
            btn_customer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_customer.Location = new Point(0, 245);
            btn_customer.Name = "btn_customer";
            btn_customer.Padding = new Padding(10, 0, 20, 0);
            btn_customer.Size = new Size(220, 60);
            btn_customer.TabIndex = 19;
            btn_customer.Text = "Khách hàng";
            btn_customer.TextAlign = ContentAlignment.MiddleLeft;
            btn_customer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_customer.UseVisualStyleBackColor = true;
            btn_customer.Click += btn_customer_Click;
            // 
            // btn_tour
            // 
            btn_tour.Dock = DockStyle.Top;
            btn_tour.FlatAppearance.BorderSize = 0;
            btn_tour.FlatStyle = FlatStyle.Flat;
            btn_tour.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_tour.ForeColor = SystemColors.ButtonFace;
            btn_tour.IconChar = FontAwesome.Sharp.IconChar.Plane;
            btn_tour.IconColor = SystemColors.ButtonFace;
            btn_tour.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_tour.IconSize = 32;
            btn_tour.ImageAlign = ContentAlignment.MiddleLeft;
            btn_tour.Location = new Point(0, 185);
            btn_tour.Name = "btn_tour";
            btn_tour.Padding = new Padding(10, 0, 20, 0);
            btn_tour.Size = new Size(220, 60);
            btn_tour.TabIndex = 18;
            btn_tour.Text = "Tour";
            btn_tour.TextAlign = ContentAlignment.MiddleLeft;
            btn_tour.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_tour.UseVisualStyleBackColor = true;
            btn_tour.Click += btn_tour_Click_1;
            // 
            // btn_home
            // 
            btn_home.Dock = DockStyle.Top;
            btn_home.FlatAppearance.BorderSize = 0;
            btn_home.FlatStyle = FlatStyle.Flat;
            btn_home.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_home.ForeColor = SystemColors.ButtonFace;
            btn_home.IconChar = FontAwesome.Sharp.IconChar.House;
            btn_home.IconColor = SystemColors.ButtonFace;
            btn_home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_home.IconSize = 32;
            btn_home.ImageAlign = ContentAlignment.MiddleLeft;
            btn_home.Location = new Point(0, 125);
            btn_home.Name = "btn_home";
            btn_home.Padding = new Padding(10, 0, 20, 0);
            btn_home.Size = new Size(220, 60);
            btn_home.TabIndex = 17;
            btn_home.Text = "Trang Chủ";
            btn_home.TextAlign = ContentAlignment.MiddleLeft;
            btn_home.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_home.UseVisualStyleBackColor = true;
            btn_home.Click += btn_home_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 125);
            panelLogo.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 31, 68);
            panel1.Controls.Add(iconCurrentChildForm);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_notifications);
            panel1.Controls.Add(label_userName);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(220, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 54);
            panel1.TabIndex = 16;
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(30, 31, 68);
            iconCurrentChildForm.ForeColor = Color.MediumPurple;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.Location = new Point(35, 11);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(32, 32);
            iconCurrentChildForm.TabIndex = 23;
            iconCurrentChildForm.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(922, 0);
            button1.Name = "button1";
            button1.Size = new Size(40, 39);
            button1.TabIndex = 13;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Layout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            ControlBox = false;
            Controls.Add(panel_main);
            Controls.Add(panel1);
            Controls.Add(panel_left);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Layout";
            Text = "Layout";
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panel_main.ResumeLayout(false);
            panel_left.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_main;
        private Label label_userName;
        private Label label1;
        private Panel panel8;
        private Panel panel9;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton btn_homeasdasd;
        private FontAwesome.Sharp.IconButton btn_reportasdas;
        private FontAwesome.Sharp.IconButton btn_notifications;
        private PictureBox btnHome;
        private Panel panel_left;
        private Panel panelLogo;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btn_home;
        private FontAwesome.Sharp.IconButton btn_tour;
        private FontAwesome.Sharp.IconButton btn_customer;
        private FontAwesome.Sharp.IconButton btn_schedule;
        private FontAwesome.Sharp.IconButton btn_report;
        private FontAwesome.Sharp.IconButton btn_exit;
        private Button button1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
    }
}