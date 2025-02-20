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
            userName = new TextBox();
            password = new TextBox();
            checkRemember = new CheckBox();
            buttonLogin = new Button();
            lableForgot = new Label();
            buttonExit = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // userName
            // 
            userName.Location = new Point(127, 153);
            userName.Name = "userName";
            userName.Size = new Size(264, 27);
            userName.TabIndex = 0;
            // 
            // password
            // 
            password.Location = new Point(127, 219);
            password.Name = "password";
            password.Size = new Size(264, 27);
            password.TabIndex = 2;
            // 
            // checkRemember
            // 
            checkRemember.AutoSize = true;
            checkRemember.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkRemember.ForeColor = Color.FromArgb(41, 128, 185);
            checkRemember.Location = new Point(64, 265);
            checkRemember.Name = "checkRemember";
            checkRemember.Size = new Size(139, 24);
            checkRemember.TabIndex = 4;
            checkRemember.Text = "Nhớ đăng nhập";
            checkRemember.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(41, 128, 185);
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = SystemColors.ButtonFace;
            buttonLogin.Location = new Point(64, 327);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(137, 43);
            buttonLogin.TabIndex = 6;
            buttonLogin.Text = "Đăng nhập";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // lableForgot
            // 
            lableForgot.AutoSize = true;
            lableForgot.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lableForgot.ForeColor = Color.FromArgb(41, 128, 185);
            lableForgot.Location = new Point(275, 265);
            lableForgot.Name = "lableForgot";
            lableForgot.Size = new Size(116, 20);
            lableForgot.TabIndex = 7;
            lableForgot.Text = "Quên mật khẩu";
            lableForgot.Click += lableForgot_Click;
            // 
            // buttonExit
            // 
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            buttonExit.ForeColor = Color.FromArgb(41, 128, 185);
            buttonExit.Location = new Point(247, 327);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(113, 43);
            buttonExit.TabIndex = 9;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 483);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.final_removebg_preview1;
            pictureBox1.Location = new Point(36, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(144, 424);
            label7.Name = "label7";
            label7.Size = new Size(144, 19);
            label7.TabIndex = 14;
            label7.Text = "nhóm .net dev TDTU";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(196, 394);
            label6.Name = "label6";
            label6.Size = new Size(99, 19);
            label6.TabIndex = 13;
            label6.Text = "Phát triển bởi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(91, 265);
            label5.Name = "label5";
            label5.Size = new Size(178, 27);
            label5.TabIndex = 12;
            label5.Text = "nhớ cho khách";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(6, 219);
            label4.Name = "label4";
            label4.Size = new Size(275, 27);
            label4.TabIndex = 11;
            label4.Text = "đến những kỉ niệm đáng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(91, 175);
            label3.Name = "label3";
            label3.Size = new Size(191, 27);
            label3.TabIndex = 10;
            label3.Text = "Chúng ta mang";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(userName);
            panel2.Controls.Add(buttonExit);
            panel2.Controls.Add(password);
            panel2.Controls.Add(buttonLogin);
            panel2.Controls.Add(lableForgot);
            panel2.Controls.Add(checkRemember);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(432, 483);
            panel2.TabIndex = 10;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = SystemColors.ButtonFace;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.DarkKhaki;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Key;
            iconButton2.IconColor = Color.FromArgb(41, 128, 185);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 32;
            iconButton2.Location = new Point(27, 196);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(94, 72);
            iconButton2.TabIndex = 18;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = SystemColors.ButtonFace;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.DarkKhaki;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconButton1.IconColor = Color.FromArgb(41, 128, 185);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.Location = new Point(27, 130);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(94, 72);
            iconButton1.TabIndex = 17;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(41, 128, 185);
            label8.Location = new Point(60, 78);
            label8.Name = "label8";
            label8.Size = new Size(360, 34);
            label8.TabIndex = 15;
            label8.Text = "Đăng nhập vào tài khoản";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(41, 128, 185);
            button1.Location = new Point(392, 0);
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
            ClientSize = new Size(732, 483);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox userName;
        private TextBox password;
        private CheckBox checkRemember;
        private Button buttonLogin;
        private Label lableForgot;
        private Button buttonExit;
        private Panel panel1;
        private Label label3;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private Button button1;
        private Label label8;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private PictureBox pictureBox1;
    }
}