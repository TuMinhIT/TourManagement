namespace TourManagementApp.Views.Admin
{
    partial class EmployeeDetail
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
            pic_avatar = new PictureBox();
            tb_address = new TextBox();
            tb_code = new TextBox();
            tb_phone = new TextBox();
            tb_name = new TextBox();
            label1 = new Label();
            tb_email = new TextBox();
            panel = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            tb_note = new TextBox();
            btn_X = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_avatar).BeginInit();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // pic_avatar
            // 
            pic_avatar.BackColor = SystemColors.ActiveCaptionText;
            pic_avatar.Image = Properties.Resources.ccc;
            pic_avatar.Location = new Point(560, 65);
            pic_avatar.Name = "pic_avatar";
            pic_avatar.Size = new Size(203, 133);
            pic_avatar.SizeMode = PictureBoxSizeMode.Zoom;
            pic_avatar.TabIndex = 9;
            pic_avatar.TabStop = false;
            // 
            // tb_address
            // 
            tb_address.BackColor = SystemColors.ActiveCaption;
            tb_address.Enabled = false;
            tb_address.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tb_address.Location = new Point(63, 366);
            tb_address.Multiline = true;
            tb_address.Name = "tb_address";
            tb_address.PlaceholderText = "  địa chỉ";
            tb_address.Size = new Size(372, 80);
            tb_address.TabIndex = 8;
            // 
            // tb_code
            // 
            tb_code.BackColor = SystemColors.ActiveCaption;
            tb_code.Enabled = false;
            tb_code.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tb_code.Location = new Point(63, 125);
            tb_code.Name = "tb_code";
            tb_code.PlaceholderText = "  Mã nhân viên";
            tb_code.Size = new Size(363, 30);
            tb_code.TabIndex = 14;
            // 
            // tb_phone
            // 
            tb_phone.BackColor = SystemColors.ActiveCaption;
            tb_phone.Enabled = false;
            tb_phone.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tb_phone.Location = new Point(63, 287);
            tb_phone.Name = "tb_phone";
            tb_phone.PlaceholderText = "  Số điện thoại";
            tb_phone.Size = new Size(363, 30);
            tb_phone.TabIndex = 7;
            // 
            // tb_name
            // 
            tb_name.BackColor = SystemColors.ActiveCaption;
            tb_name.Enabled = false;
            tb_name.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tb_name.ForeColor = SystemColors.InactiveBorder;
            tb_name.Location = new Point(63, 47);
            tb_name.Name = "tb_name";
            tb_name.PlaceholderText = "  Họ và tên";
            tb_name.Size = new Size(363, 30);
            tb_name.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-66, -29);
            label1.Name = "label1";
            label1.Size = new Size(208, 31);
            label1.TabIndex = 17;
            label1.Text = "Thông tin cá nhân";
            // 
            // tb_email
            // 
            tb_email.BackColor = SystemColors.ActiveCaption;
            tb_email.Enabled = false;
            tb_email.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tb_email.Location = new Point(63, 203);
            tb_email.Name = "tb_email";
            tb_email.PlaceholderText = "  Email";
            tb_email.Size = new Size(363, 30);
            tb_email.TabIndex = 6;
            // 
            // panel
            // 
            panel.BackColor = Color.Transparent;
            panel.Controls.Add(iconButton4);
            panel.Controls.Add(iconButton6);
            panel.Controls.Add(iconButton3);
            panel.Controls.Add(iconButton2);
            panel.Controls.Add(iconButton1);
            panel.Controls.Add(tb_note);
            panel.Controls.Add(pic_avatar);
            panel.Controls.Add(tb_address);
            panel.Controls.Add(tb_code);
            panel.Controls.Add(tb_phone);
            panel.Controls.Add(tb_email);
            panel.Controls.Add(tb_name);
            panel.ForeColor = SystemColors.ControlText;
            panel.Location = new Point(12, 41);
            panel.Name = "panel";
            panel.Size = new Size(842, 471);
            panel.TabIndex = 19;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.Transparent;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.ForeColor = Color.Transparent;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            iconButton4.IconColor = Color.WhiteSmoke;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 32;
            iconButton4.Location = new Point(4, 125);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(53, 29);
            iconButton4.TabIndex = 38;
            iconButton4.UseVisualStyleBackColor = false;
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
            iconButton6.Location = new Point(4, 366);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(53, 29);
            iconButton6.TabIndex = 37;
            iconButton6.UseVisualStyleBackColor = false;
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
            iconButton3.Location = new Point(3, 287);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(53, 29);
            iconButton3.TabIndex = 34;
            iconButton3.UseVisualStyleBackColor = false;
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
            iconButton2.Location = new Point(3, 203);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(53, 29);
            iconButton2.TabIndex = 33;
            iconButton2.UseVisualStyleBackColor = false;
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
            iconButton1.Location = new Point(4, 47);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(53, 29);
            iconButton1.TabIndex = 32;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // tb_note
            // 
            tb_note.BackColor = SystemColors.ActiveCaption;
            tb_note.Enabled = false;
            tb_note.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tb_note.Location = new Point(452, 369);
            tb_note.Multiline = true;
            tb_note.Name = "tb_note";
            tb_note.PlaceholderText = "  Thông tin khác";
            tb_note.Size = new Size(347, 80);
            tb_note.TabIndex = 16;
            // 
            // btn_X
            // 
            btn_X.BackColor = Color.Transparent;
            btn_X.Enabled = false;
            btn_X.FlatAppearance.BorderSize = 0;
            btn_X.FlatStyle = FlatStyle.Flat;
            btn_X.Font = new Font("Verdana", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_X.ForeColor = Color.WhiteSmoke;
            btn_X.Location = new Point(829, -5);
            btn_X.Name = "btn_X";
            btn_X.Size = new Size(40, 40);
            btn_X.TabIndex = 20;
            btn_X.Text = "X";
            btn_X.UseVisualStyleBackColor = false;
            btn_X.Click += btn_X_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(322, -5);
            label2.Name = "label2";
            label2.Size = new Size(244, 38);
            label2.TabIndex = 21;
            label2.Text = "Thông tin chi tiết";
            // 
            // EmployeeDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.halong_bay_4646615_640;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(866, 545);
            Controls.Add(label2);
            Controls.Add(btn_X);
            Controls.Add(label1);
            Controls.Add(panel);
            Name = "EmployeeDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeDetail";
            Load += EmployeeDetail_Load;
            ((System.ComponentModel.ISupportInitialize)pic_avatar).EndInit();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pic_avatar;
        private TextBox tb_address;
        private TextBox tb_code;
        private TextBox tb_phone;
        private TextBox tb_name;
        private Label label1;
        private TextBox tb_email;
        private Panel panel;
        private TextBox tb_note;
        private Button btn_X;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Label label2;
    }
}