namespace TourManagementApp.Views.Admin
{
    partial class AddNewEmployee
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
            btn_add = new Button();
            btn_cancel = new Button();
            tb_email = new TextBox();
            tb_name = new TextBox();
            label1 = new Label();
            tb_address = new TextBox();
            tb_phone = new TextBox();
            tb_password = new TextBox();
            tb_note = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Green;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_add.ForeColor = SystemColors.ButtonHighlight;
            btn_add.Location = new Point(214, 516);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(113, 50);
            btn_add.TabIndex = 16;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.Crimson;
            btn_cancel.FlatAppearance.BorderSize = 0;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_cancel.Location = new Point(361, 516);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(119, 50);
            btn_cancel.TabIndex = 15;
            btn_cancel.Text = "Hủy";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // tb_email
            // 
            tb_email.BackColor = SystemColors.InactiveCaption;
            tb_email.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            tb_email.ForeColor = SystemColors.ButtonFace;
            tb_email.Location = new Point(125, 127);
            tb_email.Name = "tb_email";
            tb_email.PlaceholderText = "  Email(*)";
            tb_email.Size = new Size(416, 30);
            tb_email.TabIndex = 12;
            // 
            // tb_name
            // 
            tb_name.BackColor = SystemColors.InactiveCaption;
            tb_name.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            tb_name.ForeColor = SystemColors.ButtonFace;
            tb_name.Location = new Point(125, 68);
            tb_name.Name = "tb_name";
            tb_name.PlaceholderText = "  Họ và tên";
            tb_name.Size = new Size(416, 30);
            tb_name.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(224, 9);
            label1.Name = "label1";
            label1.Size = new Size(231, 34);
            label1.TabIndex = 17;
            label1.Text = "Thêm nhân viên";
            // 
            // tb_address
            // 
            tb_address.BackColor = SystemColors.InactiveCaption;
            tb_address.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            tb_address.ForeColor = SystemColors.ButtonFace;
            tb_address.Location = new Point(125, 258);
            tb_address.Multiline = true;
            tb_address.Name = "tb_address";
            tb_address.PlaceholderText = "  Địa chỉ";
            tb_address.Size = new Size(416, 66);
            tb_address.TabIndex = 20;
            // 
            // tb_phone
            // 
            tb_phone.BackColor = SystemColors.InactiveCaption;
            tb_phone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            tb_phone.ForeColor = SystemColors.ButtonFace;
            tb_phone.Location = new Point(123, 186);
            tb_phone.Name = "tb_phone";
            tb_phone.PlaceholderText = "  Số điện thoại";
            tb_phone.Size = new Size(418, 30);
            tb_phone.TabIndex = 21;
            // 
            // tb_password
            // 
            tb_password.BackColor = SystemColors.InactiveCaption;
            tb_password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            tb_password.ForeColor = SystemColors.ButtonFace;
            tb_password.Location = new Point(125, 463);
            tb_password.Name = "tb_password";
            tb_password.PlaceholderText = "  Cấp mật khẩu mặc định: 1111";
            tb_password.Size = new Size(416, 30);
            tb_password.TabIndex = 23;
            // 
            // tb_note
            // 
            tb_note.BackColor = SystemColors.InactiveCaption;
            tb_note.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            tb_note.ForeColor = SystemColors.ButtonFace;
            tb_note.Location = new Point(125, 358);
            tb_note.Multiline = true;
            tb_note.Name = "tb_note";
            tb_note.PlaceholderText = "Thông tin khác";
            tb_note.Size = new Size(416, 66);
            tb_note.TabIndex = 25;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.Transparent;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconButton1.IconColor = Color.WhiteSmoke;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.Location = new Point(66, 68);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(53, 29);
            iconButton1.TabIndex = 26;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Transparent;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.Transparent;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.EnvelopeOpen;
            iconButton2.IconColor = Color.WhiteSmoke;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 32;
            iconButton2.Location = new Point(66, 130);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(53, 29);
            iconButton2.TabIndex = 27;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.Transparent;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.ForeColor = Color.Transparent;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Phone;
            iconButton3.IconColor = Color.WhiteSmoke;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 32;
            iconButton3.Location = new Point(64, 189);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(53, 29);
            iconButton3.TabIndex = 28;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.Transparent;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.ForeColor = Color.Transparent;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconButton4.IconColor = Color.WhiteSmoke;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 32;
            iconButton4.Location = new Point(64, 443);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(53, 29);
            iconButton4.TabIndex = 29;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton5
            // 
            iconButton5.BackColor = Color.Transparent;
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.ForeColor = Color.Transparent;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            iconButton5.IconColor = Color.WhiteSmoke;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 32;
            iconButton5.Location = new Point(64, 358);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(53, 29);
            iconButton5.TabIndex = 30;
            iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton6
            // 
            iconButton6.BackColor = Color.Transparent;
            iconButton6.FlatAppearance.BorderSize = 0;
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.ForeColor = Color.Transparent;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.Location;
            iconButton6.IconColor = Color.WhiteSmoke;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.IconSize = 32;
            iconButton6.Location = new Point(64, 261);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(53, 29);
            iconButton6.TabIndex = 31;
            iconButton6.UseVisualStyleBackColor = false;
            // 
            // AddNewEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 128, 185);
            ClientSize = new Size(679, 594);
            Controls.Add(iconButton6);
            Controls.Add(iconButton5);
            Controls.Add(iconButton4);
            Controls.Add(iconButton3);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(tb_note);
            Controls.Add(tb_password);
            Controls.Add(tb_phone);
            Controls.Add(tb_address);
            Controls.Add(label1);
            Controls.Add(btn_add);
            Controls.Add(btn_cancel);
            Controls.Add(tb_email);
            Controls.Add(tb_name);
            ForeColor = Color.White;
            Name = "AddNewEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm mới nhân viên";
            Load += AddNewEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_add;
        private Button btn_cancel;
        private TextBox tb_email;
        private TextBox tb_name;
        private Label label1;
        private TextBox tb_address;
        private TextBox tb_phone;
        private TextBox tb_password;
        private TextBox tb_note;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
    }
}