namespace TourManagementApp.Views.Tour
{
    partial class AddNewOrder
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
            tb_code = new TextBox();
            dateTimePicker = new DateTimePicker();
            lb_customer = new Label();
            btn_save = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            tb_total = new TextBox();
            label2 = new Label();
            tb_tourInf = new TextBox();
            label3 = new Label();
            btn_addCustomer = new FontAwesome.Sharp.IconButton();
            tb_prePay = new TextBox();
            label4 = new Label();
            cbb_status = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(231, 7);
            label1.Name = "label1";
            label1.Size = new Size(317, 34);
            label1.TabIndex = 0;
            label1.Text = "Thêm đơn đặt tour mới";
            // 
            // tb_code
            // 
            tb_code.Location = new Point(48, 239);
            tb_code.Name = "tb_code";
            tb_code.Size = new Size(331, 27);
            tb_code.TabIndex = 3;
            tb_code.Leave += load_customer_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(48, 350);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(331, 27);
            dateTimePicker.TabIndex = 7;
            // 
            // lb_customer
            // 
            lb_customer.AutoSize = true;
            lb_customer.BackColor = Color.Transparent;
            lb_customer.ForeColor = Color.Chocolate;
            lb_customer.Location = new Point(48, 269);
            lb_customer.Name = "lb_customer";
            lb_customer.Size = new Size(33, 20);
            lb_customer.TabIndex = 11;
            lb_customer.Text = "****";
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(41, 128, 185);
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btn_save.ForeColor = SystemColors.ButtonFace;
            btn_save.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            btn_save.IconColor = SystemColors.ButtonFace;
            btn_save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_save.IconSize = 32;
            btn_save.Location = new Point(243, 447);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(120, 41);
            btn_save.TabIndex = 16;
            btn_save.Text = "Lưu lại";
            btn_save.TextAlign = ContentAlignment.MiddleLeft;
            btn_save.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.IndianRed;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            iconButton1.ForeColor = SystemColors.ButtonFace;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            iconButton1.IconColor = SystemColors.ButtonFace;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.Location = new Point(416, 447);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(115, 41);
            iconButton1.TabIndex = 17;
            iconButton1.Text = "Hủy";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Transparent;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            iconButton2.ForeColor = Color.Navy;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Code;
            iconButton2.IconColor = Color.Navy;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 32;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(48, 188);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(258, 45);
            iconButton2.TabIndex = 18;
            iconButton2.Text = "Nhập mã khách hàng";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.Transparent;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            iconButton3.ForeColor = Color.Navy;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            iconButton3.IconColor = Color.Navy;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 32;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(48, 296);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(162, 48);
            iconButton3.TabIndex = 19;
            iconButton3.Text = "Ngày đặt";
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // tb_total
            // 
            tb_total.Location = new Point(473, 239);
            tb_total.Name = "tb_total";
            tb_total.Size = new Size(259, 27);
            tb_total.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(473, 213);
            label2.Name = "label2";
            label2.Size = new Size(143, 23);
            label2.TabIndex = 24;
            label2.Text = "Tổng thanh toán";
            // 
            // tb_tourInf
            // 
            tb_tourInf.Location = new Point(48, 105);
            tb_tourInf.Multiline = true;
            tb_tourInf.Name = "tb_tourInf";
            tb_tourInf.Size = new Size(331, 64);
            tb_tourInf.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(48, 67);
            label3.Name = "label3";
            label3.Size = new Size(119, 23);
            label3.TabIndex = 26;
            label3.Text = "Mã - Tên Tour";
            // 
            // btn_addCustomer
            // 
            btn_addCustomer.BackColor = Color.Transparent;
            btn_addCustomer.FlatAppearance.BorderSize = 0;
            btn_addCustomer.FlatStyle = FlatStyle.Flat;
            btn_addCustomer.ForeColor = Color.Transparent;
            btn_addCustomer.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btn_addCustomer.IconColor = Color.FromArgb(41, 128, 185);
            btn_addCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_addCustomer.IconSize = 30;
            btn_addCustomer.Location = new Point(321, 188);
            btn_addCustomer.Name = "btn_addCustomer";
            btn_addCustomer.Size = new Size(58, 39);
            btn_addCustomer.TabIndex = 27;
            btn_addCustomer.Text = "++";
            btn_addCustomer.UseVisualStyleBackColor = false;
            btn_addCustomer.Click += btn_addCustomer_Click;
            // 
            // tb_prePay
            // 
            tb_prePay.Location = new Point(473, 350);
            tb_prePay.Name = "tb_prePay";
            tb_prePay.Size = new Size(259, 27);
            tb_prePay.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(473, 311);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 29;
            label4.Text = "Trả trước";
            // 
            // cbb_status
            // 
            cbb_status.FormattingEnabled = true;
            cbb_status.Items.AddRange(new object[] { "Booked", "Completed", "Canceled" });
            cbb_status.Location = new Point(473, 141);
            cbb_status.Name = "cbb_status";
            cbb_status.Size = new Size(259, 28);
            cbb_status.TabIndex = 30;
            cbb_status.Text = "Booked";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(473, 106);
            label5.Name = "label5";
            label5.Size = new Size(92, 23);
            label5.TabIndex = 31;
            label5.Text = "Trạng thái";
            // 
            // AddNewOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = Properties.Resources.hon_doi_moi_phu_quoc_11;
            ClientSize = new Size(817, 522);
            Controls.Add(label5);
            Controls.Add(cbb_status);
            Controls.Add(label4);
            Controls.Add(tb_prePay);
            Controls.Add(btn_addCustomer);
            Controls.Add(label3);
            Controls.Add(tb_tourInf);
            Controls.Add(label2);
            Controls.Add(tb_total);
            Controls.Add(iconButton3);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(btn_save);
            Controls.Add(lb_customer);
            Controls.Add(dateTimePicker);
            Controls.Add(tb_code);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddNewOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewOrder";
            Load += AddNewOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_code;
        private DateTimePicker dateTimePicker;
        private Label lb_customer;
        private FontAwesome.Sharp.IconButton btn_save;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private TextBox tb_total;
        private Label label2;
        private TextBox tb_tourInf;
        private Label label3;
        private FontAwesome.Sharp.IconButton btn_addCustomer;
        private TextBox tb_prePay;
        private Label label4;
        private ComboBox cbb_status;
        private Label label5;
    }
}