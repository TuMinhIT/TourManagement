namespace TourManagementApp.Views.Schedule_form
{
    partial class EditSchedule
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
            groupBox1 = new GroupBox();
            panel = new Panel();
            tb_total = new TextBox();
            tb_description = new TextBox();
            label2 = new Label();
            btn_cancel = new FontAwesome.Sharp.IconButton();
            tb_tourName = new TextBox();
            btn_update = new FontAwesome.Sharp.IconButton();
            cbb_status = new ComboBox();
            label7 = new Label();
            label9 = new Label();
            label3 = new Label();
            tb_customerName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker_start = new DateTimePicker();
            label6 = new Label();
            dateTimePicker_end = new DateTimePicker();
            groupBox1.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(panel);
            groupBox1.Location = new Point(-6, -2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(951, 574);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(41, 128, 185);
            panel.Controls.Add(tb_total);
            panel.Controls.Add(tb_description);
            panel.Controls.Add(label2);
            panel.Controls.Add(btn_cancel);
            panel.Controls.Add(tb_tourName);
            panel.Controls.Add(btn_update);
            panel.Controls.Add(cbb_status);
            panel.Controls.Add(label7);
            panel.Controls.Add(label9);
            panel.Controls.Add(label3);
            panel.Controls.Add(tb_customerName);
            panel.Controls.Add(label4);
            panel.Controls.Add(label5);
            panel.Controls.Add(dateTimePicker_start);
            panel.Controls.Add(label6);
            panel.Controls.Add(dateTimePicker_end);
            panel.Dock = DockStyle.Fill;
            panel.Font = new Font("Segoe UI", 10.2F);
            panel.Location = new Point(3, 23);
            panel.Name = "panel";
            panel.Size = new Size(945, 548);
            panel.TabIndex = 29;
            // 
            // tb_total
            // 
            tb_total.Enabled = false;
            tb_total.Font = new Font("Segoe UI", 10.2F);
            tb_total.Location = new Point(162, 309);
            tb_total.Name = "tb_total";
            tb_total.ReadOnly = true;
            tb_total.Size = new Size(289, 30);
            tb_total.TabIndex = 28;
            // 
            // tb_description
            // 
            tb_description.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_description.ForeColor = SystemColors.InactiveCaptionText;
            tb_description.Location = new Point(516, 92);
            tb_description.Multiline = true;
            tb_description.Name = "tb_description";
            tb_description.PlaceholderText = "Nhập thông tin mô tả";
            tb_description.Size = new Size(368, 318);
            tb_description.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(516, 45);
            label2.Name = "label2";
            label2.Size = new Size(49, 18);
            label2.TabIndex = 24;
            label2.Text = "Mô tả";
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = SystemColors.ControlDark;
            btn_cancel.FlatAppearance.BorderSize = 0;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancel.ForeColor = Color.White;
            btn_cancel.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btn_cancel.IconColor = Color.White;
            btn_cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_cancel.IconSize = 30;
            btn_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cancel.Location = new Point(713, 429);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(105, 39);
            btn_cancel.TabIndex = 19;
            btn_cancel.Text = "Đóng";
            btn_cancel.TextAlign = ContentAlignment.MiddleLeft;
            btn_cancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // tb_tourName
            // 
            tb_tourName.Enabled = false;
            tb_tourName.Font = new Font("Segoe UI", 10.2F);
            tb_tourName.Location = new Point(161, 45);
            tb_tourName.Name = "tb_tourName";
            tb_tourName.Size = new Size(289, 30);
            tb_tourName.TabIndex = 20;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.DarkBlue;
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.White;
            btn_update.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btn_update.IconColor = Color.White;
            btn_update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_update.IconSize = 30;
            btn_update.ImageAlign = ContentAlignment.MiddleLeft;
            btn_update.Location = new Point(552, 429);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(141, 39);
            btn_update.TabIndex = 18;
            btn_update.Text = "Cập nhật";
            btn_update.TextAlign = ContentAlignment.MiddleLeft;
            btn_update.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // cbb_status
            // 
            cbb_status.Font = new Font("Segoe UI", 10.2F);
            cbb_status.FormattingEnabled = true;
            cbb_status.Items.AddRange(new object[] { "Booked", "Completed", "Canceled" });
            cbb_status.Location = new Point(162, 373);
            cbb_status.Name = "cbb_status";
            cbb_status.Size = new Size(288, 31);
            cbb_status.TabIndex = 14;
            cbb_status.Text = "Booked";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(30, 379);
            label7.Name = "label7";
            label7.Size = new Size(77, 18);
            label7.TabIndex = 5;
            label7.Text = "Tình trạng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(30, 315);
            label9.Name = "label9";
            label9.Size = new Size(125, 18);
            label9.TabIndex = 26;
            label9.Text = "Tổng thanh toán";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 45);
            label3.Name = "label3";
            label3.Size = new Size(65, 18);
            label3.TabIndex = 1;
            label3.Text = "Tên tour";
            // 
            // tb_customerName
            // 
            tb_customerName.Enabled = false;
            tb_customerName.Font = new Font("Segoe UI", 10.2F);
            tb_customerName.Location = new Point(161, 106);
            tb_customerName.Name = "tb_customerName";
            tb_customerName.Size = new Size(289, 30);
            tb_customerName.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 112);
            label4.Name = "label4";
            label4.Size = new Size(97, 18);
            label4.TabIndex = 2;
            label4.Text = "Khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(30, 181);
            label5.Name = "label5";
            label5.Size = new Size(125, 18);
            label5.TabIndex = 3;
            label5.Text = "Ngày khởi hành";
            // 
            // dateTimePicker_start
            // 
            dateTimePicker_start.Location = new Point(161, 172);
            dateTimePicker_start.Name = "dateTimePicker_start";
            dateTimePicker_start.Size = new Size(289, 30);
            dateTimePicker_start.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(30, 245);
            label6.Name = "label6";
            label6.Size = new Size(110, 18);
            label6.TabIndex = 4;
            label6.Text = "Ngày kết thúc";
            // 
            // dateTimePicker_end
            // 
            dateTimePicker_end.Location = new Point(162, 245);
            dateTimePicker_end.Name = "dateTimePicker_end";
            dateTimePicker_end.Size = new Size(288, 30);
            dateTimePicker_end.TabIndex = 13;
            // 
            // EditSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 567);
            Controls.Add(groupBox1);
            Name = "EditSchedule";
            Text = "EditSchedule";
            groupBox1.ResumeLayout(false);
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label9;
        private Label label2;
        private TextBox tb_customerName;
        private TextBox tb_tourName;
        private FontAwesome.Sharp.IconButton btn_cancel;
        private FontAwesome.Sharp.IconButton btn_update;
        private ComboBox cbb_status;
        private DateTimePicker dateTimePicker_end;
        private DateTimePicker dateTimePicker_start;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel;
        private TextBox tb_description;
        private TextBox tb_total;
    }
}