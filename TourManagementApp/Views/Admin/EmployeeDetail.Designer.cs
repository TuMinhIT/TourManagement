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
            label7 = new Label();
            pic_avatar = new PictureBox();
            tb_address = new TextBox();
            tb_code = new TextBox();
            label4 = new Label();
            tb_phone = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            tb_name = new TextBox();
            label1 = new Label();
            tb_email = new TextBox();
            panel = new Panel();
            btn_X = new Button();
            label6 = new Label();
            tb_note = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pic_avatar).BeginInit();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(14, 98);
            label7.Name = "label7";
            label7.Size = new Size(159, 31);
            label7.TabIndex = 15;
            label7.Text = "Mã nhân viên";
            // 
            // pic_avatar
            // 
            pic_avatar.BackColor = SystemColors.ActiveCaptionText;
            pic_avatar.Image = Properties.Resources.ccc;
            pic_avatar.Location = new Point(489, 36);
            pic_avatar.Name = "pic_avatar";
            pic_avatar.Size = new Size(203, 229);
            pic_avatar.SizeMode = PictureBoxSizeMode.Zoom;
            pic_avatar.TabIndex = 9;
            pic_avatar.TabStop = false;
            // 
            // tb_address
            // 
            tb_address.Enabled = false;
            tb_address.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tb_address.Location = new Point(14, 373);
            tb_address.Multiline = true;
            tb_address.Name = "tb_address";
            tb_address.Size = new Size(372, 80);
            tb_address.TabIndex = 8;
            // 
            // tb_code
            // 
            tb_code.Enabled = false;
            tb_code.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tb_code.Location = new Point(14, 132);
            tb_code.Name = "tb_code";
            tb_code.Size = new Size(363, 30);
            tb_code.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 336);
            label4.Name = "label4";
            label4.Size = new Size(86, 31);
            label4.TabIndex = 4;
            label4.Text = "địa chỉ";
            // 
            // tb_phone
            // 
            tb_phone.Enabled = false;
            tb_phone.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tb_phone.Location = new Point(14, 294);
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new Size(363, 30);
            tb_phone.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 243);
            label5.Name = "label5";
            label5.Size = new Size(157, 31);
            label5.TabIndex = 5;
            label5.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 20);
            label2.Name = "label2";
            label2.Size = new Size(117, 31);
            label2.TabIndex = 2;
            label2.Text = "Họ và tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 165);
            label3.Name = "label3";
            label3.Size = new Size(73, 31);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // tb_name
            // 
            tb_name.Enabled = false;
            tb_name.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tb_name.Location = new Point(14, 54);
            tb_name.Name = "tb_name";
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
            tb_email.Enabled = false;
            tb_email.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tb_email.Location = new Point(14, 210);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(363, 30);
            tb_email.TabIndex = 6;
            // 
            // panel
            // 
            panel.Controls.Add(btn_X);
            panel.Controls.Add(label6);
            panel.Controls.Add(tb_note);
            panel.Controls.Add(pic_avatar);
            panel.Controls.Add(label7);
            panel.Controls.Add(tb_address);
            panel.Controls.Add(tb_code);
            panel.Controls.Add(label4);
            panel.Controls.Add(tb_phone);
            panel.Controls.Add(label5);
            panel.Controls.Add(tb_email);
            panel.Controls.Add(label2);
            panel.Controls.Add(label3);
            panel.Controls.Add(tb_name);
            panel.Location = new Point(46, 28);
            panel.Name = "panel";
            panel.Size = new Size(810, 475);
            panel.TabIndex = 19;
            // 
            // btn_X
            // 
            btn_X.FlatAppearance.BorderSize = 0;
            btn_X.FlatStyle = FlatStyle.Flat;
            btn_X.Font = new Font("Verdana", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_X.ForeColor = Color.Black;
            btn_X.Location = new Point(767, 3);
            btn_X.Name = "btn_X";
            btn_X.Size = new Size(40, 40);
            btn_X.TabIndex = 20;
            btn_X.Text = "X";
            btn_X.UseVisualStyleBackColor = false;
            btn_X.Click += btn_X_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(427, 322);
            label6.Name = "label6";
            label6.Size = new Size(175, 31);
            label6.TabIndex = 19;
            label6.Text = "Thông tin khác";
            // 
            // tb_note
            // 
            tb_note.Enabled = false;
            tb_note.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tb_note.Location = new Point(427, 373);
            tb_note.Multiline = true;
            tb_note.Name = "tb_note";
            tb_note.Size = new Size(372, 80);
            tb_note.TabIndex = 16;
            // 
            // EmployeeDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 530);
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
        private Label label7;
        private PictureBox pic_avatar;
        private TextBox tb_address;
        private TextBox tb_code;
        private Label label4;
        private TextBox tb_phone;
        private Label label5;
        private Label label2;
        private Label label3;
        private TextBox tb_name;
        private Label label1;
        private TextBox tb_email;
        private Panel panel;
        private TextBox tb_note;
        private Label label6;
        private Button btn_X;
    }
}