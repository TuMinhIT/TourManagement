namespace TourManagementApp.Views.TourOrder
{
    partial class TourOrderDetail
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
            label2 = new Label();
            tb_total = new TextBox();
            btn_close = new FontAwesome.Sharp.IconButton();
            dateTimePicker = new DateTimePicker();
            tb_CustomerID = new TextBox();
            label1 = new Label();
            tb_tourID = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            tb_prepay = new TextBox();
            tb_tourName = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            tb_CustomerName = new TextBox();
            btn_schedule = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(135, 255);
            label2.Name = "label2";
            label2.Size = new Size(143, 23);
            label2.TabIndex = 41;
            label2.Text = "Tổng thanh toán";
            // 
            // tb_total
            // 
            tb_total.Location = new Point(135, 281);
            tb_total.Name = "tb_total";
            tb_total.ReadOnly = true;
            tb_total.Size = new Size(241, 27);
            tb_total.TabIndex = 40;
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.IndianRed;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btn_close.ForeColor = SystemColors.ButtonFace;
            btn_close.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btn_close.IconColor = SystemColors.ButtonFace;
            btn_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_close.IconSize = 32;
            btn_close.Location = new Point(755, 399);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(115, 41);
            btn_close.TabIndex = 37;
            btn_close.Text = "Đóng";
            btn_close.TextAlign = ContentAlignment.MiddleLeft;
            btn_close.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Enabled = false;
            dateTimePicker.Location = new Point(493, 281);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(358, 27);
            dateTimePicker.TabIndex = 34;
            // 
            // tb_CustomerID
            // 
            tb_CustomerID.Location = new Point(135, 205);
            tb_CustomerID.Name = "tb_CustomerID";
            tb_CustomerID.ReadOnly = true;
            tb_CustomerID.Size = new Size(246, 27);
            tb_CustomerID.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(325, 9);
            label1.Name = "label1";
            label1.Size = new Size(243, 34);
            label1.TabIndex = 32;
            label1.Text = "Thông tin chi tiết ";
            // 
            // tb_tourID
            // 
            tb_tourID.Location = new Point(135, 110);
            tb_tourID.Name = "tb_tourID";
            tb_tourID.ReadOnly = true;
            tb_tourID.Size = new Size(246, 27);
            tb_tourID.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(135, 84);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 50;
            label3.Text = "Mã Tours";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(135, 332);
            label6.Name = "label6";
            label6.Size = new Size(84, 23);
            label6.TabIndex = 51;
            label6.Text = "Trả trước";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(493, 255);
            label7.Name = "label7";
            label7.Size = new Size(84, 23);
            label7.TabIndex = 52;
            label7.Text = "Ngày đặt";
            // 
            // tb_prepay
            // 
            tb_prepay.Location = new Point(135, 358);
            tb_prepay.Name = "tb_prepay";
            tb_prepay.ReadOnly = true;
            tb_prepay.Size = new Size(241, 27);
            tb_prepay.TabIndex = 54;
            // 
            // tb_tourName
            // 
            tb_tourName.Location = new Point(493, 110);
            tb_tourName.Multiline = true;
            tb_tourName.Name = "tb_tourName";
            tb_tourName.ReadOnly = true;
            tb_tourName.Size = new Size(358, 57);
            tb_tourName.TabIndex = 56;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(493, 84);
            label9.Name = "label9";
            label9.Size = new Size(76, 23);
            label9.TabIndex = 57;
            label9.Text = "Tên tour";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(135, 179);
            label10.Name = "label10";
            label10.Size = new Size(132, 23);
            label10.TabIndex = 58;
            label10.Text = "Mã khách hàng";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(493, 179);
            label11.Name = "label11";
            label11.Size = new Size(134, 23);
            label11.TabIndex = 59;
            label11.Text = "Tên khách hàng";
            // 
            // tb_CustomerName
            // 
            tb_CustomerName.Location = new Point(493, 205);
            tb_CustomerName.Name = "tb_CustomerName";
            tb_CustomerName.ReadOnly = true;
            tb_CustomerName.Size = new Size(358, 27);
            tb_CustomerName.TabIndex = 60;
            // 
            // btn_schedule
            // 
            btn_schedule.BackColor = SystemColors.MenuHighlight;
            btn_schedule.ForeColor = SystemColors.ButtonHighlight;
            btn_schedule.Location = new Point(493, 344);
            btn_schedule.Name = "btn_schedule";
            btn_schedule.Size = new Size(132, 29);
            btn_schedule.TabIndex = 61;
            btn_schedule.Text = "lịch trình";
            btn_schedule.UseVisualStyleBackColor = false;
            btn_schedule.Click += btn_schedule_Click_1;
            // 
            // TourOrderDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.halong_bay_4646615_640;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(903, 527);
            Controls.Add(btn_schedule);
            Controls.Add(tb_CustomerName);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(tb_tourName);
            Controls.Add(tb_prepay);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(tb_tourID);
            Controls.Add(label2);
            Controls.Add(tb_total);
            Controls.Add(btn_close);
            Controls.Add(dateTimePicker);
            Controls.Add(tb_CustomerID);
            Controls.Add(label1);
            Name = "TourOrderDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TourOrderDetail";
            Load += TourOrderDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox tb_total;
        private FontAwesome.Sharp.IconButton btn_close;
        private DateTimePicker dateTimePicker;
        private TextBox tb_CustomerID;
        private Label label1;
        private TextBox tb_tourID;
        private Label label3;
        private Label label6;
        private Label label7;
        private TextBox tb_prepay;
        private TextBox tb_tourName;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox tb_CustomerName;
        private Button btn_schedule;
    }
}