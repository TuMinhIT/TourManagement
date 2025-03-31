namespace TourManagementApp.Views.Tour
{
    partial class AddNewTour
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
            cbb_type = new ComboBox();
            tb_description = new TextBox();
            cbb_transport = new ComboBox();
            label5 = new Label();
            tb_price = new TextBox();
            tb_name = new TextBox();
            btn_close = new FontAwesome.Sharp.IconButton();
            btn_add = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            button1 = new Button();
            pictureBox = new PictureBox();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            btn_loadImage = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(230, 4);
            label1.Name = "label1";
            label1.Size = new Size(393, 34);
            label1.TabIndex = 0;
            label1.Text = "Nhập thông tin cho tour mới";
            // 
            // cbb_type
            // 
            cbb_type.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            cbb_type.FormattingEnabled = true;
            cbb_type.Items.AddRange(new object[] { "Luxury", "Standard", "Budget" });
            cbb_type.Location = new Point(40, 167);
            cbb_type.Name = "cbb_type";
            cbb_type.Size = new Size(263, 31);
            cbb_type.TabIndex = 2;
            cbb_type.Text = "Standard";
            // 
            // tb_description
            // 
            tb_description.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            tb_description.Location = new Point(40, 391);
            tb_description.Multiline = true;
            tb_description.Name = "tb_description";
            tb_description.Size = new Size(436, 100);
            tb_description.TabIndex = 5;
            // 
            // cbb_transport
            // 
            cbb_transport.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            cbb_transport.FormattingEnabled = true;
            cbb_transport.Items.AddRange(new object[] { "Car", "Airplane" });
            cbb_transport.Location = new Point(40, 242);
            cbb_transport.Name = "cbb_transport";
            cbb_transport.Size = new Size(263, 31);
            cbb_transport.TabIndex = 4;
            cbb_transport.Text = "Car";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(145, 251);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 7;
            // 
            // tb_price
            // 
            tb_price.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            tb_price.Location = new Point(40, 317);
            tb_price.Name = "tb_price";
            tb_price.Size = new Size(263, 30);
            tb_price.TabIndex = 3;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            tb_name.Location = new Point(40, 81);
            tb_name.Multiline = true;
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(436, 39);
            tb_name.TabIndex = 1;
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.LightGray;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btn_close.ForeColor = SystemColors.ActiveCaptionText;
            btn_close.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btn_close.IconColor = Color.FromArgb(192, 0, 0);
            btn_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_close.IconSize = 32;
            btn_close.Location = new Point(435, 508);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(117, 42);
            btn_close.TabIndex = 9;
            btn_close.Text = "Hủy";
            btn_close.TextAlign = ContentAlignment.MiddleLeft;
            btn_close.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(41, 128, 185);
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btn_add.ForeColor = SystemColors.ButtonFace;
            btn_add.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btn_add.IconColor = SystemColors.ButtonFace;
            btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_add.IconSize = 32;
            btn_add.Location = new Point(275, 508);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(116, 42);
            btn_add.TabIndex = 6;
            btn_add.Text = "Lưu";
            btn_add.TextAlign = ContentAlignment.MiddleLeft;
            btn_add.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = SystemColors.GradientActiveCaption;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton3.ForeColor = Color.Blue;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Signature;
            iconButton3.IconColor = Color.FromArgb(41, 128, 185);
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 25;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(40, 35);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(117, 40);
            iconButton3.TabIndex = 20;
            iconButton3.Text = "Tên";
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = SystemColors.GradientActiveCaption;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            iconButton4.ForeColor = Color.Blue;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.FunnelDollar;
            iconButton4.IconColor = Color.FromArgb(41, 128, 185);
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 25;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(40, 126);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(79, 35);
            iconButton4.TabIndex = 22;
            iconButton4.Text = "Loại";
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = SystemColors.GradientActiveCaption;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            iconButton2.ForeColor = Color.Blue;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.TruckPlane;
            iconButton2.IconColor = Color.FromArgb(41, 128, 185);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 25;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(40, 201);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(150, 35);
            iconButton2.TabIndex = 23;
            iconButton2.Text = "Phương tiện";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton5
            // 
            iconButton5.BackColor = SystemColors.GradientActiveCaption;
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            iconButton5.ForeColor = Color.Blue;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            iconButton5.IconColor = Color.FromArgb(41, 128, 185);
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 25;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(40, 276);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(79, 35);
            iconButton5.TabIndex = 24;
            iconButton5.Text = "Giá";
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton7
            // 
            iconButton7.BackColor = SystemColors.GradientActiveCaption;
            iconButton7.FlatAppearance.BorderSize = 0;
            iconButton7.FlatStyle = FlatStyle.Flat;
            iconButton7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            iconButton7.ForeColor = Color.Blue;
            iconButton7.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            iconButton7.IconColor = Color.FromArgb(41, 128, 185);
            iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton7.IconSize = 25;
            iconButton7.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton7.Location = new Point(40, 350);
            iconButton7.Name = "iconButton7";
            iconButton7.Size = new Size(117, 35);
            iconButton7.TabIndex = 26;
            iconButton7.Text = "Mô tả";
            iconButton7.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton7.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(41, 128, 185);
            button1.Location = new Point(806, -2);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 27;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = SystemColors.ActiveCaption;
            pictureBox.Location = new Point(576, 116);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(214, 157);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 28;
            pictureBox.TabStop = false;
            // 
            // iconButton6
            // 
            iconButton6.BackColor = SystemColors.GradientActiveCaption;
            iconButton6.FlatAppearance.BorderSize = 0;
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            iconButton6.ForeColor = Color.Blue;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.FunnelDollar;
            iconButton6.IconColor = Color.FromArgb(41, 128, 185);
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.IconSize = 25;
            iconButton6.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton6.Location = new Point(564, 79);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(174, 35);
            iconButton6.TabIndex = 29;
            iconButton6.Text = "Hình ảnh";
            iconButton6.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton6.UseVisualStyleBackColor = false;
            // 
            // btn_loadImage
            // 
            btn_loadImage.BackColor = Color.FromArgb(41, 128, 185);
            btn_loadImage.FlatAppearance.BorderSize = 0;
            btn_loadImage.FlatStyle = FlatStyle.Flat;
            btn_loadImage.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btn_loadImage.ForeColor = SystemColors.ButtonFace;
            btn_loadImage.IconChar = FontAwesome.Sharp.IconChar.CheckToSlot;
            btn_loadImage.IconColor = SystemColors.ButtonHighlight;
            btn_loadImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_loadImage.IconSize = 32;
            btn_loadImage.Location = new Point(630, 275);
            btn_loadImage.Name = "btn_loadImage";
            btn_loadImage.Size = new Size(108, 34);
            btn_loadImage.TabIndex = 30;
            btn_loadImage.Text = "Thêm";
            btn_loadImage.TextAlign = ContentAlignment.MiddleLeft;
            btn_loadImage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_loadImage.UseVisualStyleBackColor = false;
            btn_loadImage.Click += btn_ImageLoad_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 322);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 31;
            label2.Text = "$";
            // 
            // AddNewTour
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(847, 574);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(btn_loadImage);
            Controls.Add(iconButton6);
            Controls.Add(pictureBox);
            Controls.Add(button1);
            Controls.Add(iconButton7);
            Controls.Add(iconButton5);
            Controls.Add(iconButton2);
            Controls.Add(iconButton4);
            Controls.Add(iconButton3);
            Controls.Add(btn_close);
            Controls.Add(btn_add);
            Controls.Add(tb_name);
            Controls.Add(tb_price);
            Controls.Add(label5);
            Controls.Add(cbb_transport);
            Controls.Add(tb_description);
            Controls.Add(cbb_type);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddNewTour";
            Text = "AddNewTour";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbb_type;
        private TextBox tb_description;
        private ComboBox cbb_transport;
        private Label label5;
        private TextBox tb_price;
        private TextBox tb_name;
        private FontAwesome.Sharp.IconButton btn_close;
        private FontAwesome.Sharp.IconButton btn_add;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton7;
        private Button button1;
        private PictureBox pictureBox;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton btn_loadImage;
        private Label label2;
    }
}