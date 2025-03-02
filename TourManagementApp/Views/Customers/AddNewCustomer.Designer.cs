namespace TourManagementApp.Views.Customers
{
    partial class AddNewCustomer
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
            label2 = new Label();
            tb_name = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tb_email = new TextBox();
            tb_phone = new TextBox();
            label5 = new Label();
            tb_address = new TextBox();
            label6 = new Label();
            tb_note = new TextBox();
            btn_x = new Button();
            cbb_gender = new ComboBox();
            tb_gender = new Label();
            tb_national = new TextBox();
            label7 = new Label();
            btn_save = new FontAwesome.Sharp.IconButton();
            btn_cancel = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(2, 0);
            label1.Name = "label1";
            label1.Size = new Size(318, 34);
            label1.TabIndex = 0;
            label1.Text = "Thêm khách hàng mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(46, 62);
            label2.Name = "label2";
            label2.Size = new Size(160, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng";
            // 
            // tb_name
            // 
            tb_name.Location = new Point(46, 93);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(422, 27);
            tb_name.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(41, 128, 185);
            label3.Location = new Point(46, 192);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(41, 128, 185);
            label4.Location = new Point(46, 267);
            label4.Name = "label4";
            label4.Size = new Size(138, 28);
            label4.TabIndex = 4;
            label4.Text = "Số điện thoại";
            // 
            // tb_email
            // 
            tb_email.Location = new Point(46, 223);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(406, 27);
            tb_email.TabIndex = 5;
            // 
            // tb_phone
            // 
            tb_phone.Location = new Point(46, 298);
            tb_phone.MaxLength = 11;
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new Size(406, 27);
            tb_phone.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(41, 128, 185);
            label5.Location = new Point(510, 132);
            label5.Name = "label5";
            label5.Size = new Size(78, 28);
            label5.TabIndex = 7;
            label5.Text = "Địa chỉ";
            // 
            // tb_address
            // 
            tb_address.Location = new Point(510, 177);
            tb_address.Multiline = true;
            tb_address.Name = "tb_address";
            tb_address.Size = new Size(434, 79);
            tb_address.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(41, 128, 185);
            label6.Location = new Point(510, 267);
            label6.Name = "label6";
            label6.Size = new Size(247, 28);
            label6.TabIndex = 9;
            label6.Text = "Thông tin khác(optional)";
            // 
            // tb_note
            // 
            tb_note.Location = new Point(510, 317);
            tb_note.Multiline = true;
            tb_note.Name = "tb_note";
            tb_note.Size = new Size(434, 88);
            tb_note.TabIndex = 10;
            // 
            // btn_x
            // 
            btn_x.FlatAppearance.BorderSize = 0;
            btn_x.FlatStyle = FlatStyle.Flat;
            btn_x.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_x.ForeColor = Color.FromArgb(41, 128, 185);
            btn_x.Location = new Point(934, 0);
            btn_x.Name = "btn_x";
            btn_x.Size = new Size(40, 40);
            btn_x.TabIndex = 11;
            btn_x.Text = "X";
            btn_x.UseVisualStyleBackColor = false;
            btn_x.Click += button1_Click;
            // 
            // cbb_gender
            // 
            cbb_gender.FormattingEnabled = true;
            cbb_gender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cbb_gender.Location = new Point(46, 154);
            cbb_gender.Name = "cbb_gender";
            cbb_gender.Size = new Size(249, 28);
            cbb_gender.TabIndex = 12;
            cbb_gender.Text = "Female";
            // 
            // tb_gender
            // 
            tb_gender.AutoSize = true;
            tb_gender.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tb_gender.ForeColor = Color.FromArgb(41, 128, 185);
            tb_gender.Location = new Point(46, 123);
            tb_gender.Name = "tb_gender";
            tb_gender.Size = new Size(95, 28);
            tb_gender.TabIndex = 13;
            tb_gender.Text = "Giới tính";
            // 
            // tb_national
            // 
            tb_national.Location = new Point(46, 378);
            tb_national.Name = "tb_national";
            tb_national.Size = new Size(406, 27);
            tb_national.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(41, 128, 185);
            label7.Location = new Point(46, 347);
            label7.Name = "label7";
            label7.Size = new Size(103, 28);
            label7.TabIndex = 15;
            label7.Text = "Quốc tịch";
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Lime;
            btn_save.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_save.IconColor = Color.Black;
            btn_save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_save.Location = new Point(567, 463);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(125, 42);
            btn_save.TabIndex = 16;
            btn_save.Text = "Lưu";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = SystemColors.ControlDark;
            btn_cancel.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_cancel.IconColor = Color.Black;
            btn_cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_cancel.Location = new Point(741, 463);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(113, 42);
            btn_cancel.TabIndex = 17;
            btn_cancel.Text = "Hủy";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // AddNewCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(976, 534);
            ControlBox = false;
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(label7);
            Controls.Add(tb_national);
            Controls.Add(tb_gender);
            Controls.Add(cbb_gender);
            Controls.Add(btn_x);
            Controls.Add(tb_note);
            Controls.Add(label6);
            Controls.Add(tb_address);
            Controls.Add(label5);
            Controls.Add(tb_phone);
            Controls.Add(tb_email);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tb_name);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddNewCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_name;
        private Label label3;
        private Label label4;
        private TextBox tb_email;
        private TextBox tb_phone;
        private Label label5;
        private TextBox tb_address;
        private Label label6;
        private TextBox tb_note;
        private Button btn_x;
        private ComboBox cbb_gender;
        private Label tb_gender;
        private TextBox tb_national;
        private Label label7;
        private FontAwesome.Sharp.IconButton btn_save;
        private FontAwesome.Sharp.IconButton btn_cancel;
    }
}