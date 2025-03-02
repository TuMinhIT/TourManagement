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
            lb_ten = new Label();
            tb_name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tb_address = new TextBox();
            tb_phone = new TextBox();
            label4 = new Label();
            tb_password = new TextBox();
            label5 = new Label();
            tb_note = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Blue;
            btn_add.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btn_add.ForeColor = SystemColors.ButtonHighlight;
            btn_add.Location = new Point(224, 512);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 37);
            btn_add.TabIndex = 16;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.FromArgb(224, 224, 224);
            btn_cancel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btn_cancel.Location = new Point(367, 512);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(94, 37);
            btn_cancel.TabIndex = 15;
            btn_cancel.Text = "Hủy";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // tb_email
            // 
            tb_email.Font = new Font("Segoe UI", 10.2F);
            tb_email.Location = new Point(125, 127);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(453, 30);
            tb_email.TabIndex = 12;
            // 
            // lb_ten
            // 
            lb_ten.AutoSize = true;
            lb_ten.Font = new Font("Segoe UI", 10.2F);
            lb_ten.Location = new Point(123, 42);
            lb_ten.Name = "lb_ten";
            lb_ten.Size = new Size(79, 23);
            lb_ten.TabIndex = 10;
            lb_ten.Text = "Họ tên(*)";
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 10.2F);
            tb_name.Location = new Point(125, 68);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(416, 30);
            tb_name.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(133, 23);
            label1.TabIndex = 17;
            label1.Text = "Thêm nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(123, 101);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 18;
            label2.Text = "Email(*)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(123, 219);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 19;
            label3.Text = "Địa chỉ";
            // 
            // tb_address
            // 
            tb_address.Font = new Font("Segoe UI", 10.2F);
            tb_address.Location = new Point(125, 245);
            tb_address.Multiline = true;
            tb_address.Name = "tb_address";
            tb_address.Size = new Size(400, 66);
            tb_address.TabIndex = 20;
            // 
            // tb_phone
            // 
            tb_phone.Font = new Font("Segoe UI", 10.2F);
            tb_phone.Location = new Point(123, 186);
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new Size(443, 30);
            tb_phone.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(123, 160);
            label4.Name = "label4";
            label4.Size = new Size(111, 23);
            label4.TabIndex = 22;
            label4.Text = "Số điện thoại";
            // 
            // tb_password
            // 
            tb_password.Font = new Font("Segoe UI", 10.2F);
            tb_password.Location = new Point(125, 463);
            tb_password.Name = "tb_password";
            tb_password.PlaceholderText = "1111";
            tb_password.Size = new Size(193, 30);
            tb_password.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(123, 437);
            label5.Name = "label5";
            label5.Size = new Size(210, 23);
            label5.TabIndex = 24;
            label5.Text = "Cấp mật khẩu mặc định(*)";
            // 
            // tb_note
            // 
            tb_note.Font = new Font("Segoe UI", 10.2F);
            tb_note.Location = new Point(125, 358);
            tb_note.Multiline = true;
            tb_note.Name = "tb_note";
            tb_note.Size = new Size(382, 66);
            tb_note.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(123, 332);
            label6.Name = "label6";
            label6.Size = new Size(124, 23);
            label6.TabIndex = 26;
            label6.Text = "Thông tin khác";
            // 
            // AddNewEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 594);
            Controls.Add(label6);
            Controls.Add(tb_note);
            Controls.Add(label5);
            Controls.Add(tb_password);
            Controls.Add(label4);
            Controls.Add(tb_phone);
            Controls.Add(tb_address);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_add);
            Controls.Add(btn_cancel);
            Controls.Add(tb_email);
            Controls.Add(lb_ten);
            Controls.Add(tb_name);
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
        private Label lb_ten;
        private TextBox tb_name;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_address;
        private TextBox tb_phone;
        private Label label4;
        private TextBox tb_password;
        private Label label5;
        private TextBox tb_note;
        private Label label6;
    }
}