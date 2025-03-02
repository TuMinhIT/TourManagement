namespace TourManagementApp.Views.Customers
{
    partial class CustomerDetail
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
            panel = new Panel();
            label8 = new Label();
            tb_code = new TextBox();
            label7 = new Label();
            tb_national = new TextBox();
            tb_gender = new Label();
            cbb_gender = new ComboBox();
            tb_note = new TextBox();
            label6 = new Label();
            tb_address = new TextBox();
            label5 = new Label();
            tb_phone = new TextBox();
            tb_email = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tb_name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btn_update = new FontAwesome.Sharp.IconButton();
            btn_save = new FontAwesome.Sharp.IconButton();
            btn_x = new Button();
            btn_close = new FontAwesome.Sharp.IconButton();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = SystemColors.ActiveCaption;
            panel.Controls.Add(label8);
            panel.Controls.Add(tb_code);
            panel.Controls.Add(label7);
            panel.Controls.Add(tb_national);
            panel.Controls.Add(tb_gender);
            panel.Controls.Add(cbb_gender);
            panel.Controls.Add(tb_note);
            panel.Controls.Add(label6);
            panel.Controls.Add(tb_address);
            panel.Controls.Add(label5);
            panel.Controls.Add(tb_phone);
            panel.Controls.Add(tb_email);
            panel.Controls.Add(label4);
            panel.Controls.Add(label3);
            panel.Controls.Add(tb_name);
            panel.Controls.Add(label2);
            panel.Controls.Add(label1);
            panel.Location = new Point(12, 23);
            panel.Name = "panel";
            panel.Size = new Size(983, 527);
            panel.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(41, 128, 185);
            label8.Location = new Point(34, 168);
            label8.Name = "label8";
            label8.Size = new Size(157, 28);
            label8.TabIndex = 53;
            label8.Text = "Mã khách hàng";
            // 
            // tb_code
            // 
            tb_code.Enabled = false;
            tb_code.Location = new Point(34, 199);
            tb_code.Name = "tb_code";
            tb_code.Size = new Size(422, 27);
            tb_code.TabIndex = 52;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(41, 128, 185);
            label7.Location = new Point(498, 103);
            label7.Name = "label7";
            label7.Size = new Size(103, 28);
            label7.TabIndex = 51;
            label7.Text = "Quốc tịch";
            // 
            // tb_national
            // 
            tb_national.Location = new Point(498, 134);
            tb_national.Name = "tb_national";
            tb_national.Size = new Size(406, 27);
            tb_national.TabIndex = 50;
            // 
            // tb_gender
            // 
            tb_gender.AutoSize = true;
            tb_gender.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tb_gender.ForeColor = Color.FromArgb(41, 128, 185);
            tb_gender.Location = new Point(34, 229);
            tb_gender.Name = "tb_gender";
            tb_gender.Size = new Size(95, 28);
            tb_gender.TabIndex = 49;
            tb_gender.Text = "Giới tính";
            // 
            // cbb_gender
            // 
            cbb_gender.FormattingEnabled = true;
            cbb_gender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cbb_gender.Location = new Point(34, 269);
            cbb_gender.Name = "cbb_gender";
            cbb_gender.Size = new Size(249, 28);
            cbb_gender.TabIndex = 48;
            cbb_gender.Text = "Female";
            // 
            // tb_note
            // 
            tb_note.Location = new Point(498, 358);
            tb_note.Multiline = true;
            tb_note.Name = "tb_note";
            tb_note.Size = new Size(434, 88);
            tb_note.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(41, 128, 185);
            label6.Location = new Point(498, 308);
            label6.Name = "label6";
            label6.Size = new Size(247, 28);
            label6.TabIndex = 45;
            label6.Text = "Thông tin khác(optional)";
            // 
            // tb_address
            // 
            tb_address.Location = new Point(498, 218);
            tb_address.Multiline = true;
            tb_address.Name = "tb_address";
            tb_address.Size = new Size(434, 79);
            tb_address.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(41, 128, 185);
            label5.Location = new Point(498, 173);
            label5.Name = "label5";
            label5.Size = new Size(78, 28);
            label5.TabIndex = 43;
            label5.Text = "Địa chỉ";
            // 
            // tb_phone
            // 
            tb_phone.Location = new Point(34, 419);
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new Size(406, 27);
            tb_phone.TabIndex = 42;
            // 
            // tb_email
            // 
            tb_email.Enabled = false;
            tb_email.Location = new Point(34, 349);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(406, 27);
            tb_email.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(41, 128, 185);
            label4.Location = new Point(34, 379);
            label4.Name = "label4";
            label4.Size = new Size(138, 28);
            label4.TabIndex = 40;
            label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(41, 128, 185);
            label3.Location = new Point(34, 308);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 39;
            label3.Text = "Email";
            // 
            // tb_name
            // 
            tb_name.Location = new Point(34, 114);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(422, 27);
            tb_name.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(34, 74);
            label2.Name = "label2";
            label2.Size = new Size(160, 28);
            label2.TabIndex = 37;
            label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(341, 32);
            label1.Name = "label1";
            label1.Size = new Size(235, 34);
            label1.TabIndex = 36;
            label1.Text = "Thông tin chi tiết";
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Blue;
            btn_update.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_update.IconColor = Color.Black;
            btn_update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_update.Location = new Point(371, 552);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(125, 42);
            btn_update.TabIndex = 53;
            btn_update.Text = "Chỉnh sửa";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(255, 255, 128);
            btn_save.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_save.IconColor = Color.Black;
            btn_save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_save.Location = new Point(371, 556);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(125, 42);
            btn_save.TabIndex = 52;
            btn_save.Text = "Lưu";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_x
            // 
            btn_x.FlatAppearance.BorderSize = 0;
            btn_x.FlatStyle = FlatStyle.Flat;
            btn_x.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_x.ForeColor = Color.FromArgb(41, 128, 185);
            btn_x.Location = new Point(990, -2);
            btn_x.Name = "btn_x";
            btn_x.Size = new Size(40, 40);
            btn_x.TabIndex = 47;
            btn_x.Text = "X";
            btn_x.UseVisualStyleBackColor = false;
            btn_x.Click += btn_x_Click;
            // 
            // btn_close
            // 
            btn_close.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_close.IconColor = Color.Black;
            btn_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_close.Location = new Point(551, 563);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(108, 29);
            btn_close.TabIndex = 54;
            btn_close.Text = "Đóng";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_x_Click;
            // 
            // CustomerDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1042, 606);
            Controls.Add(btn_close);
            Controls.Add(btn_update);
            Controls.Add(panel);
            Controls.Add(btn_save);
            Controls.Add(btn_x);
            Name = "CustomerDetail";
            Text = "CustomerDetail";
            Load += CustomerDetail_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private FontAwesome.Sharp.IconButton btn_save;
        private Label label7;
        private TextBox tb_national;
        private Label tb_gender;
        private ComboBox cbb_gender;
        private Button btn_x;
        private TextBox tb_note;
        private Label label6;
        private TextBox tb_address;
        private Label label5;
        private TextBox tb_phone;
        private TextBox tb_email;
        private Label label4;
        private Label label3;
        private TextBox tb_name;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btn_update;
        private Label label8;
        private TextBox tb_code;
        private FontAwesome.Sharp.IconButton btn_close;
    }
}