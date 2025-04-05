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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Layout));
            label_userName = new Label();
            label1 = new Label();
            btnHome = new PictureBox();
            panel_main = new Panel();
            pictureBox_main = new PictureBox();
            panel_left = new Panel();
            btn_account = new FontAwesome.Sharp.IconButton();
            btn_employees = new FontAwesome.Sharp.IconButton();
            btn_report = new FontAwesome.Sharp.IconButton();
            btn_schedule = new FontAwesome.Sharp.IconButton();
            btn_order = new FontAwesome.Sharp.IconButton();
            btn_exit = new FontAwesome.Sharp.IconButton();
            btn_customer = new FontAwesome.Sharp.IconButton();
            btn_tour = new FontAwesome.Sharp.IconButton();
            btn_home = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            panel1 = new Panel();
            btn_X = new Button();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_main).BeginInit();
            panel_left.SuspendLayout();
            panelLogo.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            SuspendLayout();
            // 
            // label_userName
            // 
            label_userName.AutoSize = true;
            label_userName.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label_userName.ForeColor = SystemColors.ButtonFace;
            label_userName.Location = new Point(732, 21);
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
            label1.Location = new Point(609, 21);
            label1.Name = "label1";
            label1.Size = new Size(83, 19);
            label1.TabIndex = 10;
            label1.Text = "Xin chào";
            // 
            // btnHome
            // 
            btnHome.Image = Properties.Resources.final_removebg_preview;
            btnHome.Location = new Point(3, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(211, 101);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            // 
            // panel_main
            // 
            panel_main.AutoScroll = true;
            panel_main.BackColor = SystemColors.GradientActiveCaption;
            panel_main.Controls.Add(pictureBox_main);
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(220, 54);
            panel_main.MaximumSize = new Size(1030, 650);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(1030, 649);
            panel_main.TabIndex = 2;
            // 
            // pictureBox_main
            // 
            pictureBox_main.BackgroundImage = Properties.Resources.bbb;
            pictureBox_main.InitialImage = (Image)resources.GetObject("pictureBox_main.InitialImage");
            pictureBox_main.Location = new Point(59, 35);
            pictureBox_main.Name = "pictureBox_main";
            pictureBox_main.Size = new Size(941, 588);
            pictureBox_main.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox_main.TabIndex = 0;
            pictureBox_main.TabStop = false;
            // 
            // panel_left
            // 
            panel_left.BackColor = Color.FromArgb(30, 31, 68);
            panel_left.Controls.Add(btn_account);
            panel_left.Controls.Add(btn_employees);
            panel_left.Controls.Add(btn_report);
            panel_left.Controls.Add(btn_schedule);
            panel_left.Controls.Add(btn_order);
            panel_left.Controls.Add(btn_exit);
            panel_left.Controls.Add(btn_customer);
            panel_left.Controls.Add(btn_tour);
            panel_left.Controls.Add(btn_home);
            panel_left.Controls.Add(panelLogo);
            panel_left.Dock = DockStyle.Left;
            panel_left.Location = new Point(0, 0);
            panel_left.Name = "panel_left";
            panel_left.Size = new Size(220, 703);
            panel_left.TabIndex = 1;
            // 
            // btn_account
            // 
            btn_account.Dock = DockStyle.Top;
            btn_account.FlatAppearance.BorderSize = 0;
            btn_account.FlatStyle = FlatStyle.Flat;
            btn_account.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_account.ForeColor = SystemColors.ButtonFace;
            btn_account.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_account.IconColor = SystemColors.ButtonFace;
            btn_account.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_account.IconSize = 32;
            btn_account.ImageAlign = ContentAlignment.MiddleLeft;
            btn_account.Location = new Point(0, 545);
            btn_account.Name = "btn_account";
            btn_account.Padding = new Padding(10, 0, 20, 0);
            btn_account.Size = new Size(220, 60);
            btn_account.TabIndex = 20;
            btn_account.Text = "Quản lí taì khoảng";
            btn_account.TextAlign = ContentAlignment.MiddleLeft;
            btn_account.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_account.UseVisualStyleBackColor = true;
            btn_account.Click += btn_account_Click;
            // 
            // btn_employees
            // 
            btn_employees.Dock = DockStyle.Top;
            btn_employees.FlatAppearance.BorderSize = 0;
            btn_employees.FlatStyle = FlatStyle.Flat;
            btn_employees.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_employees.ForeColor = SystemColors.ButtonFace;
            btn_employees.IconChar = FontAwesome.Sharp.IconChar.Child;
            btn_employees.IconColor = SystemColors.ButtonFace;
            btn_employees.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_employees.IconSize = 32;
            btn_employees.ImageAlign = ContentAlignment.MiddleLeft;
            btn_employees.Location = new Point(0, 485);
            btn_employees.Name = "btn_employees";
            btn_employees.Padding = new Padding(10, 0, 20, 0);
            btn_employees.Size = new Size(220, 60);
            btn_employees.TabIndex = 23;
            btn_employees.Text = "Quản lí nhân viên";
            btn_employees.TextAlign = ContentAlignment.MiddleLeft;
            btn_employees.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_employees.UseVisualStyleBackColor = true;
            btn_employees.Click += btn_employees_Click;
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
            btn_report.Location = new Point(0, 425);
            btn_report.Name = "btn_report";
            btn_report.Padding = new Padding(10, 0, 20, 0);
            btn_report.Size = new Size(220, 60);
            btn_report.TabIndex = 21;
            btn_report.Text = "Báo cáo thống kê";
            btn_report.TextAlign = ContentAlignment.MiddleLeft;
            btn_report.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_report.UseVisualStyleBackColor = true;
            btn_report.Click += btn_report_Click;
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
            btn_schedule.Location = new Point(0, 365);
            btn_schedule.Name = "btn_schedule";
            btn_schedule.Padding = new Padding(10, 0, 20, 0);
            btn_schedule.Size = new Size(220, 60);
            btn_schedule.TabIndex = 20;
            btn_schedule.Text = "Lịch trình";
            btn_schedule.TextAlign = ContentAlignment.MiddleLeft;
            btn_schedule.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_schedule.UseVisualStyleBackColor = true;
            btn_schedule.Click += btn_schedule_Click;
            // 
            // btn_order
            // 
            btn_order.Dock = DockStyle.Top;
            btn_order.FlatAppearance.BorderSize = 0;
            btn_order.FlatStyle = FlatStyle.Flat;
            btn_order.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_order.ForeColor = SystemColors.ButtonFace;
            btn_order.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            btn_order.IconColor = SystemColors.ButtonFace;
            btn_order.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_order.IconSize = 32;
            btn_order.ImageAlign = ContentAlignment.MiddleLeft;
            btn_order.Location = new Point(0, 305);
            btn_order.Name = "btn_order";
            btn_order.Padding = new Padding(10, 0, 20, 0);
            btn_order.Size = new Size(220, 60);
            btn_order.TabIndex = 9;
            btn_order.Text = "Đơn đặt Tour";
            btn_order.TextAlign = ContentAlignment.MiddleLeft;
            btn_order.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_order.UseVisualStyleBackColor = true;
            btn_order.Click += btn_order_Click;
            // 
            // btn_exit
            // 
            btn_exit.Dock = DockStyle.Bottom;
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = SystemColors.ButtonFace;
            btn_exit.IconChar = FontAwesome.Sharp.IconChar.XTwitter;
            btn_exit.IconColor = SystemColors.ButtonFace;
            btn_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_exit.IconSize = 32;
            btn_exit.ImageAlign = ContentAlignment.MiddleLeft;
            btn_exit.Location = new Point(0, 643);
            btn_exit.Name = "btn_exit";
            btn_exit.Padding = new Padding(10, 0, 20, 0);
            btn_exit.Size = new Size(220, 60);
            btn_exit.TabIndex = 22;
            btn_exit.Text = "Thoát";
            btn_exit.TextAlign = ContentAlignment.MiddleLeft;
            btn_exit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_X_Click;
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
            btn_customer.TabIndex = 12;
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
            btn_tour.TabIndex = 11;
            btn_tour.Text = "Tours";
            btn_tour.TextAlign = ContentAlignment.MiddleLeft;
            btn_tour.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_tour.UseVisualStyleBackColor = true;
            btn_tour.Click += btn_tour_Click;
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
            btn_home.TabIndex = 10;
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
            panel1.Controls.Add(btn_X);
            panel1.Controls.Add(iconCurrentChildForm);
            panel1.Controls.Add(label_userName);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(220, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1033, 54);
            panel1.TabIndex = 16;
            // 
            // btn_X
            // 
            btn_X.FlatAppearance.BorderSize = 0;
            btn_X.FlatStyle = FlatStyle.Flat;
            btn_X.Font = new Font("Verdana", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_X.ForeColor = Color.White;
            btn_X.Location = new Point(981, 8);
            btn_X.Name = "btn_X";
            btn_X.Size = new Size(40, 40);
            btn_X.TabIndex = 14;
            btn_X.Text = "X";
            btn_X.UseVisualStyleBackColor = false;
            btn_X.Click += btn_X_Click;
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
            // Layout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 703);
            ControlBox = false;
            Controls.Add(panel_main);
            Controls.Add(panel1);
            Controls.Add(panel_left);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(1200, 700);
            Name = "Layout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Layout";
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_main).EndInit();
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
        private FontAwesome.Sharp.IconButton btn_homeasdasd;
        private FontAwesome.Sharp.IconButton btn_reportasdas;
        private PictureBox btnHome;
        private Panel panel_left;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btn_home;
        private FontAwesome.Sharp.IconButton btn_tour;
        private FontAwesome.Sharp.IconButton btn_customer;
        private FontAwesome.Sharp.IconButton btn_schedule;
        private FontAwesome.Sharp.IconButton btn_report;
        private FontAwesome.Sharp.IconButton btn_exit;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Panel panelLogo;
        private Button btn_X;
        private FontAwesome.Sharp.IconButton btn_employees;
        private FontAwesome.Sharp.IconButton btn_account;
        private FontAwesome.Sharp.IconButton btn_order;
        private PictureBox pictureBox_main;
    }
}