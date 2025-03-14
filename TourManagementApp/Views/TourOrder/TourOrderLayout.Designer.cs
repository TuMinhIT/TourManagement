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
            cbb_status = new ComboBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
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
            panel_schedule.BackColor = SystemColors.InactiveCaption;
            panel_schedule.Controls.Add(btn_addSchedule);
            panel_schedule.Controls.Add(tb_number);
            panel_schedule.Controls.Add(label1);
            panel_schedule.Location = new Point(35, 524);
            panel_schedule.Name = "panel_schedule";
            panel_schedule.Size = new Size(466, 66);
            panel_schedule.TabIndex = 5;
            // 
            // btn_addSchedule
            // 
            btn_addSchedule.BackColor = Color.DarkCyan;
            btn_addSchedule.FlatAppearance.BorderSize = 0;
            btn_addSchedule.FlatStyle = FlatStyle.Flat;
            btn_addSchedule.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_addSchedule.ForeColor = SystemColors.ButtonHighlight;
            btn_addSchedule.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btn_addSchedule.IconColor = SystemColors.ButtonHighlight;
            btn_addSchedule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_addSchedule.IconSize = 25;
            btn_addSchedule.Location = new Point(9, 15);
            btn_addSchedule.Name = "btn_addSchedule";
            btn_addSchedule.Size = new Size(147, 29);
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
            tb_number.ForeColor = SystemColors.MenuHighlight;
            tb_number.Location = new Point(321, 17);
            tb_number.Name = "tb_number";
            tb_number.Size = new Size(88, 34);
            tb_number.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(162, 19);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 4;
            label1.Text = "Cho đơn đặt của";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(cbb_status);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(btn_list);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 96);
            panel1.TabIndex = 1;
            // 
            // cbb_status
            // 
            cbb_status.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cbb_status.ForeColor = SystemColors.ButtonHighlight;
            cbb_status.FormattingEnabled = true;
            cbb_status.Items.AddRange(new object[] { "Booked", "Completed", "Canceled", "Tất cã" });
            cbb_status.Location = new Point(536, 32);
            cbb_status.Name = "cbb_status";
            cbb_status.Size = new Size(232, 36);
            cbb_status.TabIndex = 2;
            cbb_status.Text = "Tất cã";
            cbb_status.TextChanged += cbb_change;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(255, 128, 0);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            iconButton1.ForeColor = SystemColors.ButtonHighlight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Filter;
            iconButton1.IconColor = SystemColors.ButtonHighlight;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(259, 22);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(242, 46);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "Lọc theo trạng thái";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // btn_list
            // 
            btn_list.BackColor = Color.DarkCyan;
            btn_list.FlatAppearance.BorderSize = 0;
            btn_list.FlatStyle = FlatStyle.Flat;
            btn_list.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_list.ForeColor = SystemColors.ButtonHighlight;
            btn_list.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btn_list.IconColor = SystemColors.ButtonHighlight;
            btn_list.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_list.IconSize = 30;
            btn_list.Location = new Point(24, 22);
            btn_list.Name = "btn_list";
            btn_list.Size = new Size(167, 41);
            btn_list.TabIndex = 0;
            btn_list.Text = "Xem tất cả";
            btn_list.TextAlign = ContentAlignment.MiddleLeft;
            btn_list.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_list.UseVisualStyleBackColor = false;
            btn_list.Click += btn_list_Click;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.LightSkyBlue;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.GridColor = SystemColors.ScrollBar;
            dataGridView.Location = new Point(8, 122);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(992, 384);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private DataGridView dataGridView;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btn_list;
        private ComboBox cbb_status;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btn_addSchedule;
        private Label label1;
        private TextBox tb_number;
        private Panel panel_schedule;
    }
}