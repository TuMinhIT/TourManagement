namespace TourManagementApp.Views.Schedule_form
{
    partial class AddSchedule
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dateTimePicker_start = new DateTimePicker();
            dateTimePicker_end = new DateTimePicker();
            cbb_status = new ComboBox();
            btn_save = new FontAwesome.Sharp.IconButton();
            btn_cancel = new FontAwesome.Sharp.IconButton();
            tb_tourName = new TextBox();
            tb_customerName = new TextBox();
            groupBox1 = new GroupBox();
            lb_total = new Label();
            label9 = new Label();
            cbb_payment = new ComboBox();
            label8 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            tb_description = new TextBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 2;
            label1.Text = "Thêm lịch trình";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 43);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 1;
            label3.Text = "Tên tour";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 107);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 2;
            label4.Text = "Khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 192);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 3;
            label5.Text = "Ngày khởi hành";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 261);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 4;
            label6.Text = "Ngày kết thúc";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 320);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 5;
            label7.Text = "Tình trạng";
            // 
            // dateTimePicker_start
            // 
            dateTimePicker_start.Location = new Point(146, 187);
            dateTimePicker_start.Name = "dateTimePicker_start";
            dateTimePicker_start.Size = new Size(289, 27);
            dateTimePicker_start.TabIndex = 12;
            // 
            // dateTimePicker_end
            // 
            dateTimePicker_end.Location = new Point(146, 261);
            dateTimePicker_end.Name = "dateTimePicker_end";
            dateTimePicker_end.Size = new Size(288, 27);
            dateTimePicker_end.TabIndex = 13;
            // 
            // cbb_status
            // 
            cbb_status.FormattingEnabled = true;
            cbb_status.Items.AddRange(new object[] { "Booked", "Completed", "Canceled" });
            cbb_status.Location = new Point(146, 323);
            cbb_status.Name = "cbb_status";
            cbb_status.Size = new Size(288, 28);
            cbb_status.TabIndex = 14;
            cbb_status.Text = "Booked";
            // 
            // btn_save
            // 
            btn_save.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_save.IconColor = Color.Black;
            btn_save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_save.Location = new Point(671, 451);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(132, 29);
            btn_save.TabIndex = 18;
            btn_save.Text = "Lưu lịch trình";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_cancel.IconColor = Color.Black;
            btn_cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_cancel.Location = new Point(519, 451);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(104, 29);
            btn_cancel.TabIndex = 19;
            btn_cancel.Text = "Hủy";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // tb_tourName
            // 
            tb_tourName.Enabled = false;
            tb_tourName.Location = new Point(147, 40);
            tb_tourName.Name = "tb_tourName";
            tb_tourName.Size = new Size(288, 27);
            tb_tourName.TabIndex = 20;
            // 
            // tb_customerName
            // 
            tb_customerName.Enabled = false;
            tb_customerName.Location = new Point(147, 107);
            tb_customerName.Name = "tb_customerName";
            tb_customerName.Size = new Size(288, 27);
            tb_customerName.TabIndex = 21;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_total);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cbb_payment);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(tb_customerName);
            groupBox1.Controls.Add(tb_tourName);
            groupBox1.Controls.Add(btn_cancel);
            groupBox1.Controls.Add(btn_save);
            groupBox1.Controls.Add(cbb_status);
            groupBox1.Controls.Add(dateTimePicker_end);
            groupBox1.Controls.Add(dateTimePicker_start);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(38, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(878, 510);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // lb_total
            // 
            lb_total.AutoSize = true;
            lb_total.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_total.ForeColor = Color.FromArgb(0, 0, 192);
            lb_total.Location = new Point(163, 376);
            lb_total.Name = "lb_total";
            lb_total.Size = new Size(60, 28);
            lb_total.TabIndex = 27;
            lb_total.Text = "1200";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 383);
            label9.Name = "label9";
            label9.Size = new Size(118, 20);
            label9.TabIndex = 26;
            label9.Text = "Tổng thanh toán";
            // 
            // cbb_payment
            // 
            cbb_payment.FormattingEnabled = true;
            cbb_payment.Items.AddRange(new object[] { "Đã thanh toán", "Chưa thanh toán" });
            cbb_payment.Location = new Point(163, 421);
            cbb_payment.Name = "cbb_payment";
            cbb_payment.Size = new Size(199, 28);
            cbb_payment.TabIndex = 25;
            cbb_payment.Text = "Chưa thanh toán";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 429);
            label8.Name = "label8";
            label8.Size = new Size(83, 20);
            label8.TabIndex = 24;
            label8.Text = "Thanh toán";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tb_description);
            panel1.Location = new Point(470, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 370);
            panel1.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 7);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 24;
            label2.Text = "Mô tả";
            // 
            // tb_description
            // 
            tb_description.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_description.ForeColor = SystemColors.InactiveCaptionText;
            tb_description.Location = new Point(3, 41);
            tb_description.Multiline = true;
            tb_description.Name = "tb_description";
            tb_description.Size = new Size(368, 277);
            tb_description.TabIndex = 22;
            tb_description.Text = "Hãy mô tả";
            // 
            // AddSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(944, 566);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "AddSchedule";
            Text = "Schedule_form";
            Load += AddSchedule_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker_start;
        private DateTimePicker dateTimePicker_end;
        private ComboBox cbb_status;
        private FontAwesome.Sharp.IconButton btn_save;
        private FontAwesome.Sharp.IconButton btn_cancel;
        private TextBox tb_tourName;
        private TextBox tb_customerName;
        private GroupBox groupBox1;
        private TextBox tb_description;
        private Panel panel1;
        private Label label2;
        private Label label8;
        private ComboBox cbb_payment;
        private Label lb_total;
        private Label label9;
    }
}