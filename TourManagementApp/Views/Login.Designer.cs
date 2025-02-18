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
            label1 = new Label();
            password = new TextBox();
            label2 = new Label();
            checkRemember = new CheckBox();
            label3 = new Label();
            buttonLogin = new Button();
            lableForgot = new Label();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // userName
            // 
            userName.Location = new Point(102, 126);
            userName.Name = "userName";
            userName.Size = new Size(428, 27);
            userName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(102, 91);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập";
            // 
            // password
            // 
            password.Location = new Point(102, 212);
            password.Name = "password";
            password.Size = new Size(428, 27);
            password.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(102, 189);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 3;
            label2.Text = "Mật Khẩu";
            // 
            // checkRemember
            // 
            checkRemember.AutoSize = true;
            checkRemember.ForeColor = SystemColors.ButtonHighlight;
            checkRemember.Location = new Point(102, 258);
            checkRemember.Name = "checkRemember";
            checkRemember.Size = new Size(198, 24);
            checkRemember.TabIndex = 4;
            checkRemember.Text = "Nhớ thông tin đăng nhập";
            checkRemember.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 47);
            label3.Name = "label3";
            label3.Size = new Size(164, 20);
            label3.TabIndex = 5;
            label3.Text = "Sáng tạo thêm cho đẹp";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(102, 312);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(137, 43);
            buttonLogin.TabIndex = 6;
            buttonLogin.Text = "Đăng nhập";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // lableForgot
            // 
            lableForgot.AutoSize = true;
            lableForgot.ForeColor = SystemColors.ButtonHighlight;
            lableForgot.Location = new Point(421, 259);
            lableForgot.Name = "lableForgot";
            lableForgot.Size = new Size(109, 20);
            lableForgot.TabIndex = 7;
            lableForgot.Text = "Quên mật khẩu";
            lableForgot.Click += lableForgot_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(299, 312);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(113, 43);
            buttonExit.TabIndex = 9;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(655, 450);
            Controls.Add(buttonExit);
            Controls.Add(lableForgot);
            Controls.Add(buttonLogin);
            Controls.Add(label3);
            Controls.Add(checkRemember);
            Controls.Add(label2);
            Controls.Add(password);
            Controls.Add(label1);
            Controls.Add(userName);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userName;
        private Label label1;
        private TextBox password;
        private Label label2;
        private CheckBox checkRemember;
        private Label label3;
        private Button buttonLogin;
        private Label lableForgot;
        private Button buttonExit;
    }
}