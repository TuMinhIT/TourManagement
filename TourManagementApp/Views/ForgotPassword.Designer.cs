namespace TourManagementApp.Views
{
    partial class ForgotPassword
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
            tb_email = new TextBox();
            btn_sent = new Button();
            btn_confirm = new Button();
            tb_code = new TextBox();
            panel = new Panel();
            btn_close_panel = new Button();
            label2 = new Label();
            cbx_showpwd = new CheckBox();
            tb_pwd = new TextBox();
            btn_save = new Button();
            tb_rpwd = new TextBox();
            btn_back = new Button();
            label1 = new Label();
            button3 = new Button();
            label3 = new Label();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // tb_email
            // 
            tb_email.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tb_email.ForeColor = Color.FromArgb(51, 51, 51);
            tb_email.Location = new Point(82, 107);
            tb_email.Name = "tb_email";
            tb_email.PlaceholderText = "Email";
            tb_email.Size = new Size(453, 34);
            tb_email.TabIndex = 1;
            // 
            // btn_sent
            // 
            btn_sent.BackColor = Color.FromArgb(0, 192, 0);
            btn_sent.FlatAppearance.BorderSize = 0;
            btn_sent.FlatStyle = FlatStyle.Flat;
            btn_sent.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btn_sent.ForeColor = Color.White;
            btn_sent.Location = new Point(424, 147);
            btn_sent.Name = "btn_sent";
            btn_sent.Size = new Size(111, 34);
            btn_sent.TabIndex = 2;
            btn_sent.Text = "Gửi mã";
            btn_sent.UseVisualStyleBackColor = false;
            btn_sent.Click += btn_sent_Click;
            // 
            // btn_confirm
            // 
            btn_confirm.BackColor = Color.FromArgb(0, 192, 0);
            btn_confirm.FlatAppearance.BorderSize = 0;
            btn_confirm.FlatStyle = FlatStyle.Flat;
            btn_confirm.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btn_confirm.ForeColor = SystemColors.ButtonFace;
            btn_confirm.Location = new Point(403, 216);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(111, 32);
            btn_confirm.TabIndex = 3;
            btn_confirm.Text = "Xác nhận";
            btn_confirm.UseVisualStyleBackColor = false;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // tb_code
            // 
            tb_code.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tb_code.Location = new Point(165, 216);
            tb_code.Name = "tb_code";
            tb_code.PlaceholderText = "Nhập mã";
            tb_code.Size = new Size(203, 34);
            tb_code.TabIndex = 4;
            // 
            // panel
            // 
            panel.BackColor = Color.SteelBlue;
            panel.Controls.Add(btn_close_panel);
            panel.Controls.Add(label2);
            panel.Controls.Add(cbx_showpwd);
            panel.Controls.Add(tb_pwd);
            panel.Controls.Add(btn_save);
            panel.Controls.Add(tb_rpwd);
            panel.Location = new Point(82, 61);
            panel.Margin = new Padding(3, 4, 3, 4);
            panel.Name = "panel";
            panel.Size = new Size(506, 303);
            panel.TabIndex = 13;
            // 
            // btn_close_panel
            // 
            btn_close_panel.FlatAppearance.BorderSize = 0;
            btn_close_panel.FlatStyle = FlatStyle.Flat;
            btn_close_panel.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close_panel.ForeColor = Color.FromArgb(192, 0, 0);
            btn_close_panel.Location = new Point(463, 3);
            btn_close_panel.Name = "btn_close_panel";
            btn_close_panel.Size = new Size(40, 40);
            btn_close_panel.TabIndex = 16;
            btn_close_panel.Text = "X";
            btn_close_panel.UseVisualStyleBackColor = false;
            btn_close_panel.Click += btn_close_panel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(143, 11);
            label2.Name = "label2";
            label2.Size = new Size(194, 34);
            label2.TabIndex = 15;
            label2.Text = "Đổi mật khẩu";
            // 
            // cbx_showpwd
            // 
            cbx_showpwd.AutoSize = true;
            cbx_showpwd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cbx_showpwd.ForeColor = Color.FromArgb(51, 51, 51);
            cbx_showpwd.Location = new Point(32, 184);
            cbx_showpwd.Margin = new Padding(3, 4, 3, 4);
            cbx_showpwd.Name = "cbx_showpwd";
            cbx_showpwd.Size = new Size(152, 24);
            cbx_showpwd.TabIndex = 10;
            cbx_showpwd.Text = "HIỆN MẬT KHẨU";
            cbx_showpwd.UseVisualStyleBackColor = true;
            cbx_showpwd.CheckedChanged += cbx_showpwd_CheckedChanged;
            // 
            // tb_pwd
            // 
            tb_pwd.BackColor = SystemColors.Window;
            tb_pwd.BorderStyle = BorderStyle.FixedSingle;
            tb_pwd.Font = new Font("Microsoft Sans Serif", 12F);
            tb_pwd.Location = new Point(32, 68);
            tb_pwd.Margin = new Padding(3, 4, 3, 4);
            tb_pwd.Name = "tb_pwd";
            tb_pwd.PlaceholderText = "Nhập mật khẩu mới";
            tb_pwd.Size = new Size(423, 30);
            tb_pwd.TabIndex = 5;
            tb_pwd.UseSystemPasswordChar = true;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Navy;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(209, 249);
            btn_save.Margin = new Padding(3, 4, 3, 4);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(105, 38);
            btn_save.TabIndex = 8;
            btn_save.Text = "LƯU";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // tb_rpwd
            // 
            tb_rpwd.BackColor = SystemColors.Window;
            tb_rpwd.BorderStyle = BorderStyle.FixedSingle;
            tb_rpwd.Font = new Font("Microsoft Sans Serif", 12F);
            tb_rpwd.Location = new Point(32, 136);
            tb_rpwd.Margin = new Padding(3, 4, 3, 4);
            tb_rpwd.Name = "tb_rpwd";
            tb_rpwd.PlaceholderText = "Nhập lại mật khẩu";
            tb_rpwd.Size = new Size(423, 30);
            tb_rpwd.TabIndex = 6;
            tb_rpwd.UseSystemPasswordChar = true;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.White;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btn_back.ForeColor = Color.FromArgb(51, 51, 51);
            btn_back.Location = new Point(567, 372);
            btn_back.Margin = new Padding(3, 4, 3, 4);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(124, 34);
            btn_back.TabIndex = 14;
            btn_back.Text = "Quay lại";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(82, 82);
            label1.Name = "label1";
            label1.Size = new Size(111, 22);
            label1.TabIndex = 0;
            label1.Text = "Nhập email";
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(41, 128, 185);
            button3.Location = new Point(638, -7);
            button3.Name = "button3";
            button3.Size = new Size(40, 40);
            button3.TabIndex = 15;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(253, 22);
            label3.Name = "label3";
            label3.Size = new Size(180, 27);
            label3.TabIndex = 16;
            label3.Text = "Quên mật khẩu";
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(703, 432);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(btn_back);
            Controls.Add(panel);
            Controls.Add(tb_code);
            Controls.Add(btn_confirm);
            Controls.Add(btn_sent);
            Controls.Add(tb_email);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quên mật khẩu";
            Load += ForgotPassword_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tb_email;
        private Button btn_sent;
        private Button btn_confirm;
        private TextBox tb_code;
        private Panel panel;
        private Label label2;
        private CheckBox cbx_showpwd;
        private TextBox tb_pwd;
        private Button btn_save;
        private TextBox tb_rpwd;
        private Button btn_back;
        private Label label1;
        private Button btn_close_panel;
        private Button button3;
        private Label label3;
    }
}