namespace TourManagementApp.Views.Tour
{
    partial class TourOrderLayout
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
            panel2 = new Panel();
            panel_schedule = new Panel();
            btn_addSchedule = new FontAwesome.Sharp.IconButton();
            tb_number = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            dateTimePicker = new DateTimePicker();
            label2 = new Label();
            btn_list = new FontAwesome.Sharp.IconButton();
            dataGridView = new DataGridView();
            panel2.SuspendLayout();
            panel_schedule.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(panel_schedule);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(dataGridView);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1012, 602);
            panel2.TabIndex = 1;
            // 
            // panel_schedule
            // 
            panel_schedule.BackColor = SystemColors.GradientActiveCaption;
            panel_schedule.Controls.Add(btn_addSchedule);
            panel_schedule.Controls.Add(tb_number);
            panel_schedule.Controls.Add(label1);
            panel_schedule.Location = new Point(3, 533);
            panel_schedule.Name = "panel_schedule";
            panel_schedule.Size = new Size(482, 66);
            panel_schedule.TabIndex = 5;
            // 
            // btn_addSchedule
            // 
            btn_addSchedule.BackColor = Color.DodgerBlue;
            btn_addSchedule.FlatAppearance.BorderSize = 0;
            btn_addSchedule.FlatStyle = FlatStyle.Flat;
            btn_addSchedule.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_addSchedule.ForeColor = SystemColors.ButtonHighlight;
            btn_addSchedule.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btn_addSchedule.IconColor = Color.DeepSkyBlue;
            btn_addSchedule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_addSchedule.IconSize = 25;
            btn_addSchedule.Location = new Point(9, 15);
            btn_addSchedule.Name = "btn_addSchedule";
            btn_addSchedule.Size = new Size(169, 29);
            btn_addSchedule.TabIndex = 2;
            btn_addSchedule.Text = "Xem lịch trình";
            btn_addSchedule.TextAlign = ContentAlignment.MiddleLeft;
            btn_addSchedule.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_addSchedule.UseVisualStyleBackColor = false;
            btn_addSchedule.Click += btn_addSchedule_Click;
            // 
            // tb_number
            // 
            tb_number.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_number.ForeColor = SystemColors.InactiveCaptionText;
            tb_number.Location = new Point(334, 15);
            tb_number.Name = "tb_number";
            tb_number.Size = new Size(117, 34);
            tb_number.TabIndex = 3;
            tb_number.Text = "<trống>";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(184, 18);
            label1.Name = "label1";
            label1.Size = new Size(142, 23);
            label1.TabIndex = 4;
            label1.Text = "Cho đơn đặt của";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(dateTimePicker);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_list);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 46);
            panel1.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarMonthBackground = SystemColors.InactiveCaption;
            dateTimePicker.Location = new Point(750, 12);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 4;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(612, 9);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 3;
            label2.Text = "Lọc theo ngày";
            // 
            // btn_list
            // 
            btn_list.BackColor = Color.AliceBlue;
            btn_list.FlatAppearance.BorderSize = 0;
            btn_list.FlatStyle = FlatStyle.Flat;
            btn_list.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_list.ForeColor = SystemColors.Highlight;
            btn_list.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btn_list.IconColor = Color.Red;
            btn_list.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_list.IconSize = 30;
            btn_list.Location = new Point(3, 3);
            btn_list.Name = "btn_list";
            btn_list.Size = new Size(149, 33);
            btn_list.TabIndex = 0;
            btn_list.Text = "Xem tất cả";
            btn_list.TextAlign = ContentAlignment.MiddleLeft;
            btn_list.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_list.UseVisualStyleBackColor = false;
            btn_list.Click += btn_list_Click;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.LightGray;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.GridColor = SystemColors.ScrollBar;
            dataGridView.Location = new Point(0, 45);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1009, 482);
            dataGridView.TabIndex = 0;
            // 
            // TourOrderLayout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 602);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(1030, 649);
            Name = "TourOrderLayout";
            Text = "TourOrderLayout";
            Load += TourOrderLayout_Load;
            panel2.ResumeLayout(false);
            panel_schedule.ResumeLayout(false);
            panel_schedule.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private DataGridView dataGridView;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btn_list;
        private FontAwesome.Sharp.IconButton btn_addSchedule;
        private Label label1;
        private TextBox tb_number;
        private Panel panel_schedule;
        private Label label2;
        private DateTimePicker dateTimePicker;
    }
}