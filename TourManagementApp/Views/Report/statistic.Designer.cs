namespace TourManagementApp.Views.Report
{
    partial class statistic
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
            components = new System.ComponentModel.Container();
            btn_exportToPDF = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_exportToExcel = new Button();
            dateTimeTo = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            btn_xem = new Button();
            lb_detail = new Label();
            dataGridView = new DataGridView();
            btn_thongke = new Button();
            dateTimeFrom = new DateTimePicker();
            lb_tke = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_exportToPDF
            // 
            btn_exportToPDF.BackColor = Color.Purple;
            btn_exportToPDF.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exportToPDF.ForeColor = SystemColors.Control;
            btn_exportToPDF.Location = new Point(613, 546);
            btn_exportToPDF.Name = "btn_exportToPDF";
            btn_exportToPDF.Size = new Size(151, 45);
            btn_exportToPDF.TabIndex = 27;
            btn_exportToPDF.Text = "Xuất PDF";
            btn_exportToPDF.UseVisualStyleBackColor = false;
            // 
            // btn_exportToExcel
            // 
            btn_exportToExcel.BackColor = Color.Green;
            btn_exportToExcel.Font = new Font("Segoe UI Semibold", 11.8F, FontStyle.Bold);
            btn_exportToExcel.ForeColor = Color.White;
            btn_exportToExcel.Location = new Point(815, 546);
            btn_exportToExcel.Name = "btn_exportToExcel";
            btn_exportToExcel.Size = new Size(151, 45);
            btn_exportToExcel.TabIndex = 24;
            btn_exportToExcel.Text = "Xuất excel";
            btn_exportToExcel.UseVisualStyleBackColor = false;
            // 
            // dateTimeTo
            // 
            dateTimeTo.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimeTo.Location = new Point(195, 50);
            dateTimeTo.Name = "dateTimeTo";
            dateTimeTo.Size = new Size(325, 27);
            dateTimeTo.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.8F, FontStyle.Bold);
            label5.Location = new Point(3, 48);
            label5.Name = "label5";
            label5.Size = new Size(172, 28);
            label5.TabIndex = 22;
            label5.Text = "Thời gian bắt đầu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.8F, FontStyle.Bold);
            label4.Location = new Point(3, 120);
            label4.Name = "label4";
            label4.Size = new Size(141, 28);
            label4.TabIndex = 21;
            label4.Text = "Thời gian cuối";
            // 
            // btn_xem
            // 
            btn_xem.BackColor = SystemColors.Highlight;
            btn_xem.Font = new Font("Segoe UI Semibold", 11.8F, FontStyle.Bold);
            btn_xem.ForeColor = SystemColors.ButtonFace;
            btn_xem.Location = new Point(10, 542);
            btn_xem.Name = "btn_xem";
            btn_xem.Size = new Size(141, 47);
            btn_xem.TabIndex = 25;
            btn_xem.Text = "Xem biểu đồ";
            btn_xem.UseVisualStyleBackColor = false;
            // 
            // lb_detail
            // 
            lb_detail.AutoSize = true;
            lb_detail.Font = new Font("Segoe UI Semibold", 11.8F, FontStyle.Bold);
            lb_detail.Location = new Point(3, 195);
            lb_detail.Name = "lb_detail";
            lb_detail.Size = new Size(83, 28);
            lb_detail.TabIndex = 20;
            lb_detail.Text = "Chi tiết ";
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.ButtonFace;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(10, 226);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1024, 310);
            dataGridView.TabIndex = 19;
            // 
            // btn_thongke
            // 
            btn_thongke.BackColor = Color.Yellow;
            btn_thongke.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btn_thongke.Location = new Point(395, 164);
            btn_thongke.Name = "btn_thongke";
            btn_thongke.Size = new Size(125, 37);
            btn_thongke.TabIndex = 18;
            btn_thongke.Text = "Thống kê";
            btn_thongke.UseVisualStyleBackColor = false;
            // 
            // dateTimeFrom
            // 
            dateTimeFrom.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimeFrom.Location = new Point(195, 120);
            dateTimeFrom.Name = "dateTimeFrom";
            dateTimeFrom.Size = new Size(325, 27);
            dateTimeFrom.TabIndex = 17;
            // 
            // lb_tke
            // 
            lb_tke.AutoSize = true;
            lb_tke.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_tke.ForeColor = Color.FromArgb(0, 0, 192);
            lb_tke.Location = new Point(312, 6);
            lb_tke.Name = "lb_tke";
            lb_tke.Size = new Size(257, 41);
            lb_tke.TabIndex = 16;
            lb_tke.Text = "Thống kê số tour";
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_exportToExcel);
            panel1.Controls.Add(lb_detail);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateTimeTo);
            panel1.Controls.Add(btn_exportToPDF);
            panel1.Controls.Add(btn_thongke);
            panel1.Controls.Add(lb_tke);
            panel1.Controls.Add(dateTimeFrom);
            panel1.Controls.Add(dataGridView);
            panel1.Controls.Add(btn_xem);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 680);
            panel1.TabIndex = 28;
            // 
            // statistic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1062, 581);
            Controls.Add(panel1);
            Name = "statistic";
            Text = "statistic";
            Load += statistic_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_exportToPDF;
        private System.Windows.Forms.Timer timer1;
        private Button btn_exportToExcel;
        private DateTimePicker dateTimeTo;
        private Label label5;
        private Label label4;
        private Button btn_xem;
        private Label lb_detail;
        private DataGridView dataGridView;
        private Button btn_thongke;
        private DateTimePicker dateTimeFrom;
        private Label lb_tke;
        private Panel panel1;
    }
}