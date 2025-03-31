namespace TourManagementApp.Views.Report
{
    partial class ReportLayout
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
            panel1 = new Panel();
            dataGridViewBooked = new DataGridView();
            dataGridViewCompleted = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            lb_sum = new Label();
            label2 = new Label();
            lb_tour = new Label();
            lb_booked = new Label();
            lb_completed = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            btn_fillter = new Button();
            dateEnd = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            dateStart = new DateTimePicker();
            panel = new Panel();
            label8 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooked).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompleted).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(dataGridViewBooked);
            panel1.Controls.Add(dataGridViewCompleted);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btn_fillter);
            panel1.Controls.Add(dateEnd);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateStart);
            panel1.Location = new Point(3, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(943, 641);
            panel1.TabIndex = 2;
            // 
            // dataGridViewBooked
            // 
            dataGridViewBooked.BackgroundColor = SystemColors.InactiveCaption;
            dataGridViewBooked.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooked.Location = new Point(34, 466);
            dataGridViewBooked.Name = "dataGridViewBooked";
            dataGridViewBooked.RowHeadersWidth = 51;
            dataGridViewBooked.Size = new Size(861, 145);
            dataGridViewBooked.TabIndex = 33;
            // 
            // dataGridViewCompleted
            // 
            dataGridViewCompleted.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCompleted.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCompleted.Location = new Point(34, 257);
            dataGridViewCompleted.Name = "dataGridViewCompleted";
            dataGridViewCompleted.RowHeadersWidth = 51;
            dataGridViewCompleted.Size = new Size(861, 135);
            dataGridViewCompleted.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lb_sum);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lb_booked);
            panel2.Controls.Add(lb_tour);
            panel2.Controls.Add(lb_completed);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(34, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(861, 71);
            panel2.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(138, 23);
            label1.TabIndex = 22;
            label1.Text = "Tổng doanh thu";
            // 
            // lb_sum
            // 
            lb_sum.AutoSize = true;
            lb_sum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_sum.ForeColor = Color.Black;
            lb_sum.Location = new Point(49, 38);
            lb_sum.Name = "lb_sum";
            lb_sum.Size = new Size(24, 28);
            lb_sum.TabIndex = 27;
            lb_sum.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(251, 15);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 23;
            label2.Text = "Tổng số tour";
            label2.Click += label2_Click;
            // 
            // lb_tour
            // 
            lb_tour.AutoSize = true;
            lb_tour.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_tour.ForeColor = Color.Black;
            lb_tour.Location = new Point(293, 38);
            lb_tour.Name = "lb_tour";
            lb_tour.Size = new Size(24, 28);
            lb_tour.TabIndex = 28;
            lb_tour.Text = "0";
            // 
            // lb_booked
            // 
            lb_booked.AutoSize = true;
            lb_booked.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_booked.ForeColor = Color.Black;
            lb_booked.Location = new Point(755, 43);
            lb_booked.Name = "lb_booked";
            lb_booked.Size = new Size(24, 28);
            lb_booked.TabIndex = 30;
            lb_booked.Text = "0";
            // 
            // lb_completed
            // 
            lb_completed.AutoSize = true;
            lb_completed.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_completed.ForeColor = Color.Black;
            lb_completed.Location = new Point(510, 38);
            lb_completed.Name = "lb_completed";
            lb_completed.Size = new Size(24, 28);
            lb_completed.TabIndex = 29;
            lb_completed.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 4);
            label7.Name = "label7";
            label7.Size = new Size(116, 28);
            label7.TabIndex = 26;
            label7.Text = "Lọc dữ liệu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(651, 15);
            label4.Name = "label4";
            label4.Size = new Size(207, 23);
            label4.TabIndex = 25;
            label4.Text = "Số tour chưa hoàn thành";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(417, 15);
            label3.Name = "label3";
            label3.Size = new Size(189, 23);
            label3.TabIndex = 24;
            label3.Text = "Số tour đã hoàn thành";
            // 
            // btn_fillter
            // 
            btn_fillter.BackColor = Color.FromArgb(0, 192, 0);
            btn_fillter.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_fillter.ForeColor = SystemColors.ButtonFace;
            btn_fillter.Location = new Point(789, 58);
            btn_fillter.Name = "btn_fillter";
            btn_fillter.Size = new Size(106, 35);
            btn_fillter.TabIndex = 21;
            btn_fillter.Text = "xem";
            btn_fillter.UseVisualStyleBackColor = false;
            btn_fillter.Click += btn_fillter_Click;
            // 
            // dateEnd
            // 
            dateEnd.Location = new Point(493, 66);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(250, 27);
            dateEnd.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.Location = new Point(388, 72);
            label6.Name = "label6";
            label6.Size = new Size(86, 23);
            label6.TabIndex = 15;
            label6.Text = "Đến ngày";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.Location = new Point(9, 66);
            label5.Name = "label5";
            label5.Size = new Size(75, 23);
            label5.TabIndex = 14;
            label5.Text = "Từ ngày";
            // 
            // dateStart
            // 
            dateStart.Location = new Point(86, 66);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(250, 27);
            dateStart.TabIndex = 13;
            // 
            // panel
            // 
            panel.BackColor = SystemColors.ActiveBorder;
            panel.Location = new Point(3, 644);
            panel.Name = "panel";
            panel.Size = new Size(940, 351);
            panel.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(34, 231);
            label8.Name = "label8";
            label8.Size = new Size(250, 23);
            label8.TabIndex = 31;
            label8.Text = "Danh sách tour đã hoàn thành";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label9.ForeColor = Color.Maroon;
            label9.Location = new Point(34, 420);
            label9.Name = "label9";
            label9.Size = new Size(268, 23);
            label9.TabIndex = 31;
            label9.Text = "Danh sách tour chưa hoàn thành";
            // 
            // ReportLayout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(962, 599);
            Controls.Add(panel);
            Controls.Add(panel1);
            Name = "ReportLayout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo cáo doanh thu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooked).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompleted).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label5;
        private DateTimePicker dateStart;
        private Label label6;
        private DateTimePicker dateEnd;
        private Panel panel;
        private Button btn_fillter;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label lb_booked;
        private Label lb_completed;
        private Label lb_tour;
        private Label lb_sum;
        private Panel panel2;
        private DataGridView dataGridViewBooked;
        private DataGridView dataGridViewCompleted;
        private Label label9;
        private Label label8;
    }
}