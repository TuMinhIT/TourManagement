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
            tb_name = new TextBox();
            tb_email = new TextBox();
            tb_phone = new TextBox();
            tb_address = new TextBox();
            tb_note = new TextBox();
            btn_x = new Button();
            cbb_gender = new ComboBox();
            tb_national = new TextBox();
            btn_save = new FontAwesome.Sharp.IconButton();
            btn_cancel = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(352, 18);
            label1.Name = "label1";
            label1.Size = new Size(318, 34);
            label1.TabIndex = 0;
            label1.Text = "Thêm khách hàng mới";
            // 
            // tb_name
            // 
            tb_name.BackColor = SystemColors.ActiveCaption;
            tb_name.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            tb_name.Location = new Point(99, 123);
            tb_name.Name = "tb_name";
            tb_name.PlaceholderText = "  Tên khách hàng";
            tb_name.Size = new Size(314, 30);
            tb_name.TabIndex = 2;
            // 
            // tb_email
            // 
            tb_email.BackColor = SystemColors.ActiveCaption;
            tb_email.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            tb_email.Location = new Point(99, 253);
            tb_email.Name = "tb_email";
            tb_email.PlaceholderText = "  Email";
            tb_email.Size = new Size(314, 30);
            tb_email.TabIndex = 5;
            // 
            // tb_phone
            // 
            tb_phone.BackColor = SystemColors.ActiveCaption;
            tb_phone.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tb_phone.Location = new Point(99, 328);
            tb_phone.MaxLength = 11;
            tb_phone.Name = "tb_phone";
            tb_phone.PlaceholderText = "  Số điện thoại";
            tb_phone.Size = new Size(314, 30);
            tb_phone.TabIndex = 6;
            // 
            // tb_address
            // 
            tb_address.BackColor = SystemColors.ActiveCaption;
            tb_address.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            tb_address.Location = new Point(542, 180);
            tb_address.Multiline = true;
            tb_address.Name = "tb_address";
            tb_address.PlaceholderText = "  Địa chỉ";
            tb_address.Size = new Size(400, 79);
            tb_address.TabIndex = 8;
            // 
            // tb_note
            // 
            tb_note.BackColor = SystemColors.ActiveCaption;
            tb_note.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            tb_note.Location = new Point(542, 320);
            tb_note.Multiline = true;
            tb_note.Name = "tb_note";
            tb_note.PlaceholderText = "  Thông tin khác(optional)";
            tb_note.Size = new Size(400, 88);
            tb_note.TabIndex = 10;
            // 
            // btn_x
            // 
            btn_x.BackColor = Color.Transparent;
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
            cbb_gender.BackColor = SystemColors.ActiveCaption;
            cbb_gender.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            cbb_gender.ForeColor = SystemColors.WindowText;
            cbb_gender.FormattingEnabled = true;
            cbb_gender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cbb_gender.Location = new Point(99, 180);
            cbb_gender.Name = "cbb_gender";
            cbb_gender.Size = new Size(314, 31);
            cbb_gender.TabIndex = 12;
            cbb_gender.Text = "Female";
            // 
            // tb_national
            // 
            tb_national.BackColor = SystemColors.ActiveCaption;
            tb_national.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            tb_national.Location = new Point(99, 396);
            tb_national.Name = "tb_national";
            tb_national.PlaceholderText = "  Quốc tịch";
            tb_national.Size = new Size(314, 30);
            tb_national.TabIndex = 14;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(41, 128, 185);
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_save.ForeColor = SystemColors.ControlLightLight;
            btn_save.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            btn_save.IconColor = SystemColors.ControlLightLight;
            btn_save.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btn_save.IconSize = 30;
            btn_save.ImageAlign = ContentAlignment.MiddleLeft;
            btn_save.Location = new Point(680, 463);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(119, 42);
            btn_save.TabIndex = 16;
            btn_save.Text = "Lưu";
            btn_save.TextAlign = ContentAlignment.MiddleLeft;
            btn_save.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = SystemColors.ControlDark;
            btn_cancel.FlatAppearance.BorderSize = 0;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_cancel.ForeColor = SystemColors.ControlLightLight;
            btn_cancel.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btn_cancel.IconColor = SystemColors.ControlLightLight;
            btn_cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_cancel.IconSize = 30;
            btn_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cancel.Location = new Point(829, 463);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(113, 42);
            btn_cancel.TabIndex = 17;
            btn_cancel.Text = "Hủy";
            btn_cancel.TextAlign = ContentAlignment.MiddleLeft;
            btn_cancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Transparent;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.VenusMars;
            iconButton2.IconColor = Color.WhiteSmoke;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 32;
            iconButton2.Location = new Point(25, 177);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(68, 35);
            iconButton2.TabIndex = 65;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.Transparent;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Phone;
            iconButton4.IconColor = Color.WhiteSmoke;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 32;
            iconButton4.Location = new Point(25, 317);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(68, 35);
            iconButton4.TabIndex = 64;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.Transparent;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            iconButton3.IconColor = Color.WhiteSmoke;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 32;
            iconButton3.Location = new Point(25, 253);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(68, 35);
            iconButton3.TabIndex = 63;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconButton1.IconColor = Color.WhiteSmoke;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.Location = new Point(25, 123);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(68, 35);
            iconButton1.TabIndex = 62;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton5
            // 
            iconButton5.BackColor = Color.Transparent;
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.Location;
            iconButton5.IconColor = Color.Coral;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 32;
            iconButton5.Location = new Point(468, 206);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(68, 35);
            iconButton5.TabIndex = 68;
            iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton6
            // 
            iconButton6.BackColor = Color.Transparent;
            iconButton6.FlatAppearance.BorderSize = 0;
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.Flag;
            iconButton6.IconColor = Color.WhiteSmoke;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.IconSize = 32;
            iconButton6.Location = new Point(25, 405);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(68, 35);
            iconButton6.TabIndex = 67;
            iconButton6.UseVisualStyleBackColor = false;
            // 
            // iconButton7
            // 
            iconButton7.BackColor = Color.Transparent;
            iconButton7.FlatAppearance.BorderSize = 0;
            iconButton7.FlatStyle = FlatStyle.Flat;
            iconButton7.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            iconButton7.IconColor = Color.Coral;
            iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton7.IconSize = 32;
            iconButton7.Location = new Point(468, 328);
            iconButton7.Name = "iconButton7";
            iconButton7.Size = new Size(68, 35);
            iconButton7.TabIndex = 69;
            iconButton7.UseVisualStyleBackColor = false;
            // 
            // AddNewCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = Properties.Resources.hon_doi_moi_phu_quoc_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(976, 534);
            ControlBox = false;
            Controls.Add(iconButton7);
            Controls.Add(iconButton5);
            Controls.Add(iconButton6);
            Controls.Add(iconButton2);
            Controls.Add(iconButton4);
            Controls.Add(iconButton3);
            Controls.Add(iconButton1);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(tb_national);
            Controls.Add(cbb_gender);
            Controls.Add(btn_x);
            Controls.Add(tb_note);
            Controls.Add(tb_address);
            Controls.Add(tb_phone);
            Controls.Add(tb_email);
            Controls.Add(tb_name);
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
        private TextBox tb_name;
        private TextBox tb_email;
        private TextBox tb_phone;
        private TextBox tb_address;
        private TextBox tb_note;
        private Button btn_x;
        private ComboBox cbb_gender;
        private TextBox tb_national;
        private FontAwesome.Sharp.IconButton btn_save;
        private FontAwesome.Sharp.IconButton btn_cancel;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton7;
    }
}