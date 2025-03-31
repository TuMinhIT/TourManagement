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
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(336, 4);
            label1.Name = "label1";
            label1.Size = new Size(255, 38);
            label1.TabIndex = 0;
            label1.Text = "Thông tin cá nhân";
            // 
            // tb_name
            // 
            tb_name.BackColor = SystemColors.ActiveCaption;
            tb_name.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tb_name.Location = new Point(428, 52);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(363, 30);
            tb_name.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(426, 18);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 2;
            label2.Text = "Họ và tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(428, 152);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(428, 321);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 4;
            label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(428, 233);
            label5.Name = "label5";
            label5.Size = new Size(139, 25);
            label5.TabIndex = 5;
            label5.Text = "Số điện thoại";
            // 
            // tb_email
            // 
            tb_email.BackColor = SystemColors.ActiveCaption;
            tb_email.Enabled = false;
            tb_email.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tb_email.Location = new Point(428, 186);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(363, 30);
            tb_email.TabIndex = 6;
            // 
            // tb_phone
            // 
            tb_phone.BackColor = SystemColors.ActiveCaption;
            tb_phone.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            tb_phone.Location = new Point(426, 274);
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new Size(363, 30);
            tb_phone.TabIndex = 7;
            // 
            // tb_address
            // 
            tb_address.BackColor = SystemColors.ActiveCaption;
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
            btn_fix.BackColor = Color.Transparent;
            btn_fix.FlatAppearance.BorderSize = 0;
            btn_fix.FlatStyle = FlatStyle.Flat;
            btn_fix.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_fix.ForeColor = Color.MediumBlue;
            btn_fix.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btn_fix.IconColor = Color.Navy;
            btn_fix.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_fix.IconSize = 30;
            btn_fix.ImageAlign = ContentAlignment.MiddleLeft;
            btn_fix.Location = new Point(807, 6);
            btn_fix.Name = "btn_fix";
            btn_fix.Size = new Size(151, 38);
            btn_fix.TabIndex = 11;
            btn_fix.Text = "Chỉnh sửa";
            btn_fix.TextAlign = ContentAlignment.MiddleLeft;
            btn_fix.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_fix.UseVisualStyleBackColor = false;
            btn_fix.Click += btn_fix_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.SeaShell;
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.Indigo;
            btn_update.IconChar = FontAwesome.Sharp.IconChar.Highlighter;
            btn_update.IconColor = Color.Black;
            btn_update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_update.IconSize = 30;
            btn_update.ImageAlign = ContentAlignment.MiddleLeft;
            btn_update.Location = new Point(597, 445);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(170, 38);
            btn_update.TabIndex = 12;
            btn_update.Text = "Cập nhật";
            btn_update.TextAlign = ContentAlignment.MiddleLeft;
            btn_update.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_changeAva
            // 
            btn_changeAva.BackColor = Color.Transparent;
            btn_changeAva.FlatAppearance.BorderSize = 0;
            btn_changeAva.FlatStyle = FlatStyle.Flat;
            btn_changeAva.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_changeAva.ForeColor = Color.Black;
            btn_changeAva.IconChar = FontAwesome.Sharp.IconChar.Images;
            btn_changeAva.IconColor = Color.Black;
            btn_changeAva.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_changeAva.IconSize = 30;
            btn_changeAva.ImageAlign = ContentAlignment.MiddleLeft;
            btn_changeAva.Location = new Point(43, 242);
            btn_changeAva.Name = "btn_changeAva";
            btn_changeAva.Size = new Size(152, 37);
            btn_changeAva.TabIndex = 13;
            btn_changeAva.Text = "Đổi avata";
            btn_changeAva.TextAlign = ContentAlignment.MiddleLeft;
            btn_changeAva.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_changeAva.UseVisualStyleBackColor = false;
            btn_changeAva.Click += btn_changeAva_Click;
            // 
            // tb_code
            // 
            tb_code.BackColor = SystemColors.ActiveCaption;
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
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(426, 85);
            label7.Name = "label7";
            label7.Size = new Size(142, 25);
            label7.TabIndex = 15;
            label7.Text = "Mã nhân viên";
            // 
            // panel
            // 
            panel.BackColor = Color.SteelBlue;
            panel.BackgroundImage = Properties.Resources.halong_bay_4646615_640;
            panel.BackgroundImageLayout = ImageLayout.Stretch;
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
            panel.Location = new Point(57, 60);
            panel.Name = "panel";
            panel.Size = new Size(809, 493);
            panel.TabIndex = 16;
            // 
            // tb_note
            // 
            tb_note.AutoSize = true;
            tb_note.BackColor = Color.Transparent;
            tb_note.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_note.ForeColor = Color.Black;
            tb_note.Location = new Point(3, 315);
            tb_note.Name = "tb_note";
            tb_note.Size = new Size(175, 31);
            tb_note.TabIndex = 17;
            tb_note.Text = "Thông tin khác";
            // 
            // note
            // 
            note.BackColor = SystemColors.ActiveCaption;
            note.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            BackgroundImageLayout = ImageLayout.Stretch;
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