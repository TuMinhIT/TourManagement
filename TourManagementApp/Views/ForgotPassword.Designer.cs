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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            panel_mkm = new Panel();
            label2 = new Label();
            cbx_showpwd = new CheckBox();
            tb_pwd = new TextBox();
            btn_confirm = new Button();
            tb_rpwd = new TextBox();
            btn_back = new Button();
            button3 = new Button();
            panel_mkm.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(274, 30);
            label1.Name = "label1";
            label1.Size = new Size(225, 34);
            label1.TabIndex = 0;
            label1.Text = "Quên mật khẩu";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 99);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Email";
            textBox1.Size = new Size(520, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(117, 145);
            button1.Name = "button1";
            button1.Size = new Size(136, 39);
            button1.TabIndex = 2;
            button1.Text = "Gửi mã";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(41, 128, 185);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(526, 200);
            button2.Name = "button2";
            button2.Size = new Size(111, 32);
            button2.TabIndex = 3;
            button2.Text = "Xác nhận";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(434, 155);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Nhập mã";
            textBox2.Size = new Size(203, 27);
            textBox2.TabIndex = 4;
            // 
            // panel_mkm
            // 
            panel_mkm.BackColor = Color.FromArgb(41, 128, 185);
            panel_mkm.Controls.Add(label2);
            panel_mkm.Controls.Add(cbx_showpwd);
            panel_mkm.Controls.Add(tb_pwd);
            panel_mkm.Controls.Add(btn_confirm);
            panel_mkm.Controls.Add(tb_rpwd);
            panel_mkm.Location = new Point(131, 250);
            panel_mkm.Margin = new Padding(3, 4, 3, 4);
            panel_mkm.Name = "panel_mkm";
            panel_mkm.Size = new Size(506, 303);
            panel_mkm.TabIndex = 13;
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
            cbx_showpwd.ForeColor = Color.White;
            cbx_showpwd.Location = new Point(32, 196);
            cbx_showpwd.Margin = new Padding(3, 4, 3, 4);
            cbx_showpwd.Name = "cbx_showpwd";
            cbx_showpwd.Size = new Size(152, 24);
            cbx_showpwd.TabIndex = 10;
            cbx_showpwd.Text = "HIỆN MẬT KHẨU";
            cbx_showpwd.UseVisualStyleBackColor = true;
            // 
            // tb_pwd
            // 
            tb_pwd.BackColor = SystemColors.Window;
            tb_pwd.BorderStyle = BorderStyle.FixedSingle;
            tb_pwd.Font = new Font("Microsoft Sans Serif", 14F);
            tb_pwd.Location = new Point(32, 68);
            tb_pwd.Margin = new Padding(3, 4, 3, 4);
            tb_pwd.Name = "tb_pwd";
            tb_pwd.PlaceholderText = "Nhập mật khẩu mới";
            tb_pwd.Size = new Size(423, 34);
            tb_pwd.TabIndex = 5;
            tb_pwd.UseSystemPasswordChar = true;
            // 
            // btn_confirm
            // 
            btn_confirm.BackColor = Color.Black;
            btn_confirm.FlatAppearance.BorderSize = 0;
            btn_confirm.FlatStyle = FlatStyle.Flat;
            btn_confirm.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btn_confirm.ForeColor = Color.White;
            btn_confirm.Location = new Point(123, 236);
            btn_confirm.Margin = new Padding(3, 4, 3, 4);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(221, 41);
            btn_confirm.TabIndex = 8;
            btn_confirm.Text = "HOÀN TẤT";
            btn_confirm.UseVisualStyleBackColor = false;
            // 
            // tb_rpwd
            // 
            tb_rpwd.BackColor = SystemColors.Window;
            tb_rpwd.BorderStyle = BorderStyle.FixedSingle;
            tb_rpwd.Font = new Font("Microsoft Sans Serif", 14F);
            tb_rpwd.Location = new Point(32, 136);
            tb_rpwd.Margin = new Padding(3, 4, 3, 4);
            tb_rpwd.Name = "tb_rpwd";
            tb_rpwd.PlaceholderText = "Nhập lại mật khẩu";
            tb_rpwd.Size = new Size(423, 34);
            tb_rpwd.TabIndex = 6;
            tb_rpwd.UseSystemPasswordChar = true;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Black;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(601, 565);
            btn_back.Margin = new Padding(3, 4, 3, 4);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(124, 44);
            btn_back.TabIndex = 14;
            btn_back.Text = "Quay lại";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(41, 128, 185);
            button3.Location = new Point(781, 0);
            button3.Name = "button3";
            button3.Size = new Size(40, 40);
            button3.TabIndex = 15;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(821, 622);
            ControlBox = false;
            Controls.Add(button3);
            Controls.Add(btn_back);
            Controls.Add(panel_mkm);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPassword";
            panel_mkm.ResumeLayout(false);
            panel_mkm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Panel panel_mkm;
        private Label label2;
        private CheckBox cbx_showpwd;
        private TextBox tb_pwd;
        private Button btn_confirm;
        private TextBox tb_rpwd;
        private Button btn_back;
        private Button button3;
    }
}