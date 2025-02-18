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
            panel_top = new Panel();
            label_userName = new Label();
            label1 = new Label();
            bnt_notifications = new Button();
            pictureBoxLogo = new PictureBox();
            panel_left = new Panel();
            btn_exit = new Button();
            btn_report = new Button();
            btn_tour = new Button();
            btn_customer = new Button();
            btn_schedule = new Button();
            btn_home = new Button();
            panel_main = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panel_left.SuspendLayout();
            panel_main.SuspendLayout();
            SuspendLayout();
            // 
            // panel_top
            // 
            panel_top.BackColor = Color.Navy;
            panel_top.Controls.Add(label_userName);
            panel_top.Controls.Add(label1);
            panel_top.Controls.Add(bnt_notifications);
            panel_top.Controls.Add(pictureBoxLogo);
            panel_top.Location = new Point(1, 3);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(1177, 51);
            panel_top.TabIndex = 0;
            // 
            // label_userName
            // 
            label_userName.AutoSize = true;
            label_userName.ForeColor = SystemColors.Control;
            label_userName.Location = new Point(880, 18);
            label_userName.Name = "label_userName";
            label_userName.Size = new Size(75, 20);
            label_userName.TabIndex = 11;
            label_userName.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ScrollBar;
            label1.Location = new Point(794, 18);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 10;
            label1.Text = "Xin chào";
            // 
            // bnt_notifications
            // 
            bnt_notifications.Location = new Point(1035, 9);
            bnt_notifications.Name = "bnt_notifications";
            bnt_notifications.Size = new Size(134, 29);
            bnt_notifications.TabIndex = 9;
            bnt_notifications.Text = "icon họp thư";
            bnt_notifications.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(3, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(200, 64);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 8;
            pictureBoxLogo.TabStop = false;
            // 
            // panel_left
            // 
            panel_left.BackColor = SystemColors.AppWorkspace;
            panel_left.Controls.Add(btn_exit);
            panel_left.Controls.Add(btn_report);
            panel_left.Controls.Add(btn_tour);
            panel_left.Controls.Add(btn_customer);
            panel_left.Controls.Add(btn_schedule);
            panel_left.Controls.Add(btn_home);
            panel_left.Location = new Point(1, 60);
            panel_left.Name = "panel_left";
            panel_left.Size = new Size(204, 578);
            panel_left.TabIndex = 1;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(3, 399);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(194, 43);
            btn_exit.TabIndex = 8;
            btn_exit.Text = "Thoát";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_report
            // 
            btn_report.Location = new Point(0, 329);
            btn_report.Name = "btn_report";
            btn_report.Size = new Size(194, 43);
            btn_report.TabIndex = 7;
            btn_report.Text = "Báo cáo thống kê";
            btn_report.UseVisualStyleBackColor = true;
            btn_report.Click += btn_report_Click;
            // 
            // btn_tour
            // 
            btn_tour.Location = new Point(0, 120);
            btn_tour.Name = "btn_tour";
            btn_tour.Size = new Size(194, 43);
            btn_tour.TabIndex = 4;
            btn_tour.Text = "Tour";
            btn_tour.UseVisualStyleBackColor = true;
            btn_tour.Click += btn_tour_Click;
            // 
            // btn_customer
            // 
            btn_customer.Location = new Point(0, 190);
            btn_customer.Name = "btn_customer";
            btn_customer.Size = new Size(194, 43);
            btn_customer.TabIndex = 3;
            btn_customer.Text = "Khách hàng";
            btn_customer.UseVisualStyleBackColor = true;
            btn_customer.Click += btn_customer_Click;
            // 
            // btn_schedule
            // 
            btn_schedule.Location = new Point(0, 260);
            btn_schedule.Name = "btn_schedule";
            btn_schedule.Size = new Size(194, 43);
            btn_schedule.TabIndex = 2;
            btn_schedule.Text = "Lịch trình";
            btn_schedule.UseVisualStyleBackColor = true;
            btn_schedule.Click += btn_schedule_Click;
            // 
            // btn_home
            // 
            btn_home.Location = new Point(3, 41);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(194, 43);
            btn_home.TabIndex = 1;
            btn_home.Text = "Trang chủ";
            btn_home.UseVisualStyleBackColor = true;
            btn_home.Click += btn_home_Click;
            // 
            // panel_main
            // 
            panel_main.AutoScroll = true;
            panel_main.Controls.Add(panel8);
            panel_main.Controls.Add(panel9);
            panel_main.Controls.Add(panel7);
            panel_main.Controls.Add(panel6);
            panel_main.Controls.Add(panel5);
            panel_main.Controls.Add(panel4);
            panel_main.Location = new Point(204, 60);
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
            // Layout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(panel_main);
            Controls.Add(panel_left);
            Controls.Add(panel_top);
            Name = "Layout";
            Text = "Layout";
            panel_top.ResumeLayout(false);
            panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panel_left.ResumeLayout(false);
            panel_main.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_top;
        private Panel panel_left;
        private Panel panel_main;
        private Label label_userName;
        private Label label1;
        private Button bnt_notifications;
        private PictureBox pictureBoxLogo;
        private Button btn_tour;
        private Button btn_customer;
        private Button btn_schedule;
        private Button btn_home;
        private Panel panel8;
        private Panel panel9;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Button btn_report;
        private Button btn_exit;
    }
}