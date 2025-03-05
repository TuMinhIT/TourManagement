namespace TourManagementApp.Views.Account
{
    partial class AccountLayout
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tb_email = new TextBox();
            tb_phone = new TextBox();
            tb_address = new TextBox();
            pic_avatar = new PictureBox();
            btn_fix = new FontAwesome.Sharp.IconButton();
            btn_update = new FontAwesome.Sharp.IconButton();
            btn_changeAva = new FontAwesome.Sharp.IconButton();
            tb_code = new TextBox();
            label7 = new Label();
            panel = new Panel();
            tb_note = new Label();
            note = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pic_avatar).BeginInit();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 1);
            label1.Name = "label1";
            label1.Size = new Size(208, 31);
            label1.TabIndex = 0;
            label1.Text = "Thông tin cá nhân";
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tb_name.Location = new Point(428, 52);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(363, 30);
            tb_name.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(426, 18);
            label2.Name = "label2";
            label2.Size = new Size(117, 31);
            label2.TabIndex = 2;
            label2.Text = "Họ và tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(428, 152);
            label3.Name = "label3";
            label3.Size = new Size(73, 31);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(428, 315);
            label4.Name = "label4";
            label4.Size = new Size(86, 31);
            label4.TabIndex = 4;
            label4.Text = "địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(428, 233);
            label5.Name = "label5";
            label5.Size = new Size(157, 31);
            label5.TabIndex = 5;
            label5.Text = "Số điện thoại";
            // 
            // tb_email
            // 
            tb_email.Enabled = false;
            tb_email.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tb_email.Location = new Point(428, 186);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(363, 30);
            tb_email.TabIndex = 6;
            // 
            // tb_phone
            // 
            tb_phone.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tb_phone.Location = new Point(428, 267);
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new Size(363, 30);
            tb_phone.TabIndex = 7;
            // 
            // tb_address
            // 
            tb_address.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tb_address.Location = new Point(428, 355);
            tb_address.Multiline = true;
            tb_address.Name = "tb_address";
            tb_address.Size = new Size(362, 71);
            tb_address.TabIndex = 8;
            // 
            // pic_avatar
            // 
            pic_avatar.BackColor = SystemColors.ActiveCaptionText;
            pic_avatar.Image = Properties.Resources.ccc;
            pic_avatar.Location = new Point(15, 3);
            pic_avatar.Name = "pic_avatar";
            pic_avatar.Size = new Size(195, 233);
            pic_avatar.SizeMode = PictureBoxSizeMode.Zoom;
            pic_avatar.TabIndex = 9;
            pic_avatar.TabStop = false;
            // 
            // btn_fix
            // 
            btn_fix.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_fix.IconColor = Color.Black;
            btn_fix.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_fix.Location = new Point(830, 1);
            btn_fix.Name = "btn_fix";
            btn_fix.Size = new Size(120, 38);
            btn_fix.TabIndex = 11;
            btn_fix.Text = "Chỉnh sửa";
            btn_fix.UseVisualStyleBackColor = true;
            btn_fix.Click += btn_fix_Click;
            // 
            // btn_update
            // 
            btn_update.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_update.IconColor = Color.Black;
            btn_update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_update.Location = new Point(585, 451);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(120, 38);
            btn_update.TabIndex = 12;
            btn_update.Text = "Cập nhật";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_changeAva
            // 
            btn_changeAva.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_changeAva.IconColor = Color.Black;
            btn_changeAva.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_changeAva.Location = new Point(58, 246);
            btn_changeAva.Name = "btn_changeAva";
            btn_changeAva.Size = new Size(104, 37);
            btn_changeAva.TabIndex = 13;
            btn_changeAva.Text = "Đổi avata";
            btn_changeAva.UseVisualStyleBackColor = true;
            btn_changeAva.Click += btn_changeAva_Click;
            // 
            // tb_code
            // 
            tb_code.Enabled = false;
            tb_code.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tb_code.Location = new Point(428, 119);
            tb_code.Name = "tb_code";
            tb_code.Size = new Size(363, 30);
            tb_code.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(426, 85);
            label7.Name = "label7";
            label7.Size = new Size(159, 31);
            label7.TabIndex = 15;
            label7.Text = "Mã nhân viên";
            // 
            // panel
            // 
            panel.BackColor = Color.SteelBlue;
            panel.Controls.Add(tb_note);
            panel.Controls.Add(note);
            panel.Controls.Add(pic_avatar);
            panel.Controls.Add(btn_update);
            panel.Controls.Add(label7);
            panel.Controls.Add(btn_changeAva);
            panel.Controls.Add(tb_address);
            panel.Controls.Add(tb_code);
            panel.Controls.Add(label4);
            panel.Controls.Add(tb_phone);
            panel.Controls.Add(label5);
            panel.Controls.Add(tb_email);
            panel.Controls.Add(label2);
            panel.Controls.Add(label3);
            panel.Controls.Add(tb_name);
            panel.Location = new Point(48, 45);
            panel.Name = "panel";
            panel.Size = new Size(818, 504);
            panel.TabIndex = 16;
            // 
            // tb_note
            // 
            tb_note.AutoSize = true;
            tb_note.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_note.Location = new Point(3, 315);
            tb_note.Name = "tb_note";
            tb_note.Size = new Size(175, 31);
            tb_note.TabIndex = 17;
            tb_note.Text = "Thông tin khác";
            // 
            // note
            // 
            note.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            note.Location = new Point(3, 359);
            note.Multiline = true;
            note.Name = "note";
            note.Size = new Size(372, 67);
            note.TabIndex = 16;
            note.TextChanged += textBox1_TextChanged;
            // 
            // AccountLayout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.ccc;
            ClientSize = new Size(962, 599);
            Controls.Add(panel);
            Controls.Add(btn_fix);
            Controls.Add(label1);
            MinimumSize = new Size(971, 583);
            Name = "AccountLayout";
            Text = "AccountLayout";
            Load += AccountLayout_Load;
            ((System.ComponentModel.ISupportInitialize)pic_avatar).EndInit();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_name;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tb_email;
        private TextBox tb_phone;
        private TextBox tb_address;
        private PictureBox pic_avatar;
        private FontAwesome.Sharp.IconButton btn_fix;
        private FontAwesome.Sharp.IconButton btn_update;
        private FontAwesome.Sharp.IconButton btn_changeAva;
        private TextBox tb_code;
        private Label label7;
        private Panel panel;
        private Label tb_note;
        private TextBox note;
    }
}