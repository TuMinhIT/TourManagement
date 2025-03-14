namespace TourManagementApp.Views
{
    partial class Login
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
            tb_userName = new TextBox();
            tb_password = new TextBox();
            check_hide = new CheckBox();
            buttonLogin = new Button();
            lb_forgot = new Label();
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tb_userName
            // 
            tb_userName.Location = new Point(139, 176);
            tb_userName.Name = "tb_userName";
            tb_userName.PlaceholderText = "Mã nhân viên";
            tb_userName.Size = new Size(351, 27);
            tb_userName.TabIndex = 0;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(139, 242);
            tb_password.Name = "tb_password";
            tb_password.PlaceholderText = "Mật khẩu";
            tb_password.Size = new Size(351, 27);
            tb_password.TabIndex = 2;
            tb_password.UseSystemPasswordChar = true;
            // 
            // check_hide
            // 
            check_hide.AutoSize = true;
            check_hide.BackColor = Color.Transparent;
            check_hide.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            check_hide.ForeColor = Color.FromArgb(41, 128, 185);
            check_hide.Location = new Point(139, 295);
            check_hide.Name = "check_hide";
            check_hide.Size = new Size(133, 24);
            check_hide.TabIndex = 4;
            check_hide.Text = "Hiện mật khẩu";
            check_hide.UseVisualStyleBackColor = false;
            check_hide.CheckedChanged += check_hide_CheckedChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(41, 128, 185);
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = SystemColors.ButtonFace;
            buttonLogin.Location = new Point(188, 347);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(137, 43);
            buttonLogin.TabIndex = 6;
            buttonLogin.Text = "Đăng nhập";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // lb_forgot
            // 
            lb_forgot.AutoSize = true;
            lb_forgot.BackColor = Color.Transparent;
            lb_forgot.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_forgot.ForeColor = Color.FromArgb(41, 128, 185);
            lb_forgot.Location = new Point(346, 292);
            lb_forgot.Name = "lb_forgot";
            lb_forgot.Size = new Size(144, 25);
            lb_forgot.TabIndex = 7;
            lb_forgot.Text = "Quên mật khẩu";
            lb_forgot.Click += lableForgot_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Transparent;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            buttonExit.ForeColor = Color.FromArgb(41, 128, 185);
            buttonExit.Location = new Point(355, 347);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(113, 43);
            buttonExit.TabIndex = 9;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.final_removebg_preview1;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.BackgroundImage = Properties.Resources.mau_background_vali_du_lich_110856208;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(tb_userName);
            panel2.Controls.Add(buttonExit);
            panel2.Controls.Add(tb_password);
            panel2.Controls.Add(buttonLogin);
            panel2.Controls.Add(lb_forgot);
            panel2.Controls.Add(check_hide);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(642, 451);
            panel2.TabIndex = 10;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Transparent;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.DarkKhaki;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Key;
            iconButton2.IconColor = Color.FromArgb(41, 128, 185);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 32;
            iconButton2.Location = new Point(80, 235);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(53, 34);
            iconButton2.TabIndex = 18;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.DarkKhaki;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconButton1.IconColor = Color.FromArgb(41, 128, 185);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.Location = new Point(80, 170);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(53, 38);
            iconButton1.TabIndex = 17;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(41, 128, 185);
            label8.Location = new Point(139, 101);
            label8.Name = "label8";
            label8.Size = new Size(360, 34);
            label8.TabIndex = 15;
            label8.Text = "Đăng nhập vào tài khoản";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(41, 128, 185);
            button1.Location = new Point(599, 3);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 10;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(642, 451);
            ControlBox = false;
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tb_userName;
        private TextBox tb_password;
        private CheckBox check_hide;
        private Button buttonLogin;
        private Label lb_forgot;
        private Button buttonExit;
        private Panel panel2;
        private Button button1;
        private Label label8;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private PictureBox pictureBox1;
    }
}